using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;

namespace ResHelper
{
    public partial class MainHelper : Form
    {
        string can_not_copy_path = Environment.CurrentDirectory + "/can_not_copy.txt";
        string[] inc = { ".js", ".json" };
        string[] exc = { ".settings", ".cocos-project", "CocosProject", "resources", "jsonConfig" };
        static string[] dirMaps = { "ResourceFont.js", "ResourceImage.js", "ResourceJson.js", "ResourcePlist.js", "ResourceShader.js", "ResourceSoundMusic.js", };
        static string[] varMaps = { "resSoundMusic", "resShader", "resPlist", "resJson", "resImg", "resFont" };
        static string[] ex = { ".jpg", "png", "json", "mp3", "plist", "xml", "ttf", "TTF" };
        static string paternStr = @"[\w\/]+\.(?:" + String.Join("|", ex) + ")\b";
        static string paternMapStr = @"(" + String.Join("|", varMaps) + ")";
        static string[] searchPath = { "res" };
        static string output = Environment.CurrentDirectory + "/output/";
        static string selectedDir = "";
        static int countCopy = 0;
        //cache data
        static List<string> lFile = new List<string>();
        static List<FoundInfo> listFoundInfo = new List<FoundInfo>();
        static List<FoundInfo> listNotFoundInfo = new List<FoundInfo>();
        static List<FoundInfo> listMapInfo = new List<FoundInfo>();
        static Dictionary<string, string> mapDict = new Dictionary<string, string>();
        private string searchExistedFile(string abPath)
        {
            string p = selectedDir + "/" + abPath;
            if (File.Exists(p))
            {
                return abPath;
            }
            foreach (string sPath in searchPath)
            {
                p = selectedDir + "/" + sPath + "/" + abPath;
                if (File.Exists(p))
                {
                    return sPath + "/" + abPath;
                }
            }
            return null;
        }
        private void copyFiles(string[] arrABPath, string filename)
        {
            int c = 0;
            FoundInfo notF = null;
            foreach (string file in arrABPath)
            {
                string fromPath = searchExistedFile(file);
                if (fromPath != null)
                {
                    //Console.WriteLine("Copy from " + fromPath);
                    string desPath = output + fromPath;
                    //Console.WriteLine("To" + desPath);
                    FileHelper.checkExistedDir(desPath);
                    lbText.Text = "Copy " + (++c) + "/" + arrABPath.Length;
                    if (!File.Exists(desPath))
                    {
                        lbText.Text += " from " + fromPath + "\nTo" + desPath;
                        File.Copy(selectedDir + "/" + fromPath, desPath, false);
                        countCopy++;
                    }
                    else
                    {
                        lbText.Text += "Copy EXITED " + desPath;
                    }
                }
                else
                {
                    if (notF != null)
                    {
                        notF.value.Add(file);
                    }
                    else
                    {
                        notF = new FoundInfo() { path = filename, value = new List<string>() };
                        notF.value.Add(file);
                        listNotFoundInfo.Add(notF);
                    }
                }
            }

        }

        private async Task<bool> processNotCopy()
        {
            string res = "";
            foreach (FoundInfo f in listNotFoundInfo)
            {
                string data = await ReadAsync(f.path);
                res += f.path + " : " + "\nDETAIL:\n";
                foreach (string s in f.value)
                {
                    string rStr = @".*" + s + ".*";
                    Regex r = new Regex(rStr);
                    res += rStr + " => in String:\n";
                    foreach (Match m in r.Matches(data))
                    {
                        if (m.Value.Length < 500) { res += m.Value + "\n"; } else { res += "CCS JSON FILE\n"; }
                    }
                }
            }
            await WriteAsync(res, can_not_copy_path, false);
            return true;
        }
        private void processMapRes()
        {
            foreach (FoundInfo f in listMapInfo)
            {
                string strJson = f.getValueString();
                try
                {
                    JObject o = JObject.Parse(strJson);
                    var json = JsonConvert.SerializeObject(o);
                    var dictionary = JsonConvert.DeserializeObject<Dictionary<string, string>>(json);
                    foreach (KeyValuePair<string, string> temp in dictionary)
                    {
                        mapDict.Add(f.path + "." + temp.Key, temp.Value);
                        mapDict.Add(f.path + "[\"" + temp.Key + "\"]", temp.Value);
                    }
                    Console.WriteLine("Parse OBJECT SUCCESS " + f.path);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
        private async Task<string> readMapRes(string filePath)
        {
            string found = "";
            using (StreamReader sr = new StreamReader(filePath))
            {

                string data = await sr.ReadToEndAsync();
                //Console.WriteLine("readMapRes data " + data);

                string rStr = @"(?:var|const|let)\s" + paternMapStr + "(?:=| )(?:.|\n|\r)*?({(?:.|\n|\r)*?})";
                Regex regex = new Regex(rStr);
                Match m = regex.Match(data);
                if (m.Groups.Count <= 0)
                {
                    return "";//broken here
                }
                string key = m.Groups[1].Value;
                found = m.Groups[2].Value;
                FoundInfo i = new FoundInfo() { path = key, value = new List<string>() };
                i.value.Add(found);
                listMapInfo.Add(i);

                Console.WriteLine("processMapRes " + filePath);
                Console.WriteLine("listMapInfo " + listMapInfo.Count);
            }
            return found;
        }

        private async void processFile(string filename, string data)
        {
            if (data == null)
            {
                using (StreamReader sr = new StreamReader(filename))
                {

                    data = await sr.ReadToEndAsync();
                }
            }
            FoundInfo i = new FoundInfo() { path = filename, value = new List<string>() };
            Regex regex = new Regex(paternStr);
            foreach (Match match in regex.Matches(data))
            {
                i.value.Add(match.Value);
            }
            //find valid maps
            foreach (string s in varMaps)
            {
                Regex rg = new Regex(s + ".*");
                foreach (Match match in rg.Matches(data))
                {
                    //Console.WriteLine(match.Value);
                    string rStr = s + @"(?:\.|\["")\w+(?:""])?";
                    Regex r0 = new Regex(rStr);
                    Match x = r0.Match(match.Value);
                    //Console.WriteLine(x.Value);
                    //check existed
                    if (mapDict.ContainsKey(x.Value))
                    {
                        i.value.Add(mapDict[x.Value]);
                    }
                }
            }
            //SAVE FOUND INFO
            if (i.value.Count > 0)
            {
                listFoundInfo.Add(i);
            }
        }
        private async void processDir(string dir)
        {
            //PROCESS RES MAPS
            string[] fMaps = Directory.GetFiles(dir, "*", SearchOption.AllDirectories).Where(name => dirMaps.Any(x => name.Contains(x))).ToArray();
            foreach (string f in fMaps)
            {
                imageList.Images.Add(System.Drawing.Icon.ExtractAssociatedIcon(f));
                FileInfo info = new FileInfo(f);
                lFile.Add(info.FullName);
                listView.Items.Add(info.Name, imageList.Images.Count - 1);
                //read res maps
                await readMapRes(f);
            }
            processMapRes();

            //PROCESS FILES
            string[] files = Directory.GetFiles(dir, "*", SearchOption.AllDirectories).Where(name => inc.Any(x => name.EndsWith(x, StringComparison.CurrentCulture))).ToArray().
                Where(name => !exc.Any(x => name.Contains(x))).ToArray();
            int c = 0;
            foreach (string file in files)
            {
                lbText.Text = lbText.Text + "\nAWAIT Read " + file;
                string readStr = await ReadAsync(file) + "\n\n";
                processFile(file, readStr);
                lbText.Text = "READ DONE " + (++c) + "/" + files.Length + ":" + file;
            }
            lbText.Text = "DONE Read All!!!!\n\n";
            //DELETE OLD
            if (Directory.Exists(output))
            {
                Directory.Delete(output, true);
            }
            //COPY
            string foundStr = "";
            foreach (FoundInfo f in listFoundInfo)
            {
                copyFiles(f.value.ToArray(), f.path);
                foundStr += f.ToString() + "\n";
            }

            lbText.Text = "DONE Copy All " + countCopy;
            MessageBox.Show("Copy Done " + countCopy + " file!!!");

            await processNotCopy();

            await WriteAsync(foundStr, Environment.CurrentDirectory + "/found.txt", false);

            const string message = "Are you sure that you would like to close the form\nAnd Open OutPut Dirs?";
            const string caption = "Complete Process";
            var r = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // If the no button was pressed ...
            if (r == System.Windows.Forms.DialogResult.Yes)
            {
                Process.Start(output);
                // Closes the parent form.
                this.Close();
            }
        }

        private void clearOldCache()
        {
            lFile.Clear();
            listView.Items.Clear();
            listFoundInfo.Clear();
            listNotFoundInfo.Clear();
            listMapInfo.Clear();
            mapDict.Clear();
        }
        public MainHelper()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Touch");

        }
    }
}
