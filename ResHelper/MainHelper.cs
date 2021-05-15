using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResHelper
{
    public partial class MainHelper : Form
    {
        static string[] inc = { ".js", ".json", ".csd" };
        static string[] exc = { ".settings", ".cocos-project", "jsonConfig" };
        static string[] varMaps = { "resSoundMusic", "resShader", "resPlist", "resJson", "resImg", "resFont" };
        static string[] ex = { "jpg", "png", "json", "mp3", "plist", "xml", "ttf", "TTF" };
        static string[] searchPath = { "res" };

        static string storage_path = Environment.CurrentDirectory + "\\storage.json";
        static string output = Environment.CurrentDirectory + "\\output";
        static string logFoundFilename = "found.txt";

        static string paternStr = "";
        static string paternMapStr = "";

        static string selectedDir = Environment.CurrentDirectory;
        static string selectedMapDir = Environment.CurrentDirectory;
        static string selectedSearchDir = Environment.CurrentDirectory;
        static int countCopy = 0;
        //cache data
        static List<string> lFile = new List<string>();
        static List<string> lSearchFile = new List<string>();
        static List<string> lNotUse = new List<string>();
        static List<FoundInfo> listFoundInfo = new List<FoundInfo>();
        static List<FoundInfo> listNotFoundInfo = new List<FoundInfo>();
        static List<FoundInfo> listMapInfo = new List<FoundInfo>();
        static Dictionary<string, string> mapDict = new Dictionary<string, string>();
        const string kResMap = "ResMap";
        const string kSearchRes = "SearchRes";
        const string kOutput = "Output";
        const string kCurPath = "CurPath";
        const string kExcludeType = "ExcludeType";
        const string kReadType = "ReadType";
        const string kCopyType = "CopyType";
        const string kSearchPath = "SearchPath";
        const string kMapVar = "MapVar";

        string[] splitStr = { @"|" };

        static Dictionary<string, string> historyTxt = new Dictionary<string, string>()
        {
            {kCurPath, ""},
            {kOutput, ""},
            {kSearchRes, ""},
            {kResMap, ""},
            {kExcludeType, ""},
            {kReadType, ""},
            {kCopyType, ""},
            {kSearchPath, ""},
            {kMapVar, ""}
        };
        private async void saveStorage()
        {
            var items = from kvp in historyTxt select '"' + kvp.Key + "\":\"" + kvp.Value.Replace("\\", "/") + '"';
            string str = "{" + String.Join(",", items) + "}";
            await FileHelper.WriteAsync(str, storage_path, false);
        }
        private void processSearchDir()
        {
            string[] arr = selectedSearchDir.Split('\\');
            List<string> lDirs = searchPath.ToList<string>();
            string p = null;
            foreach (var s in arr)
            {
                if (p == null)
                {
                    p = s;
                }
                else
                {
                    p += "\\" + s;
                }
                lDirs.Add(p);
            }
            lDirs.Sort(delegate(string x, string y)
            {
                if (x.Length < y.Length) return 1;
                else if (x.Length > y.Length) return -1;
                else return 0;
            });
            searchPath = lDirs.ToArray();
            lsbSearchPath.Items.Clear();
            foreach (string sPath in searchPath)
            {
                Console.WriteLine("processSearchDir: " + sPath);
                if (sPath != "")
                {
                    lsbSearchPath.Items.Add(sPath);
                }
            }
        }
        private Dictionary<string, string> searchExistedFile(string abPath)
        {
            Dictionary<string, string> r = new Dictionary<string, string>() 
            { 
                {"path", abPath},
                {"ab_path", abPath}
            };
            List<string> lSearch = searchPath.ToList<string>();
            lSearch.Add(selectedDir);
            lSearch.Add(selectedSearchDir);

            foreach (string sPath in lSearch)
            {
                string p = sPath + "\\" + abPath;
                if (File.Exists(p))
                {
                    r["path"] = p;
                    r["ab_path"] = abPath;
                    return r;
                }
            }
            return null;
        }
        private void copyFiles(string[] arrABPath, string filename)
        {
            int c = 0;
            FoundInfo notF = null;

            List<string> lSearch = searchPath.ToList<string>();
            lSearch.Add(selectedDir);
            lSearch.Add(selectedSearchDir);
            lSearch.Add(output);

            foreach (string file in arrABPath)
            {
                Dictionary<string, string> curPath = searchExistedFile(file);
                if (curPath != null)
                {
                    //find absolute path
                    curPath["ab_path"] = curPath["ab_path"].Replace("/", "\\");
                    foreach (string sPath in lSearch)
                    {
                        if (sPath != "")
                        {
                            string withoutPart = sPath.Replace("/", "\\") + "\\";
                            if (curPath["ab_path"].IndexOf(withoutPart) == 0)
                            {
                                curPath["ab_path"] = curPath["ab_path"].Substring(withoutPart.Length);//remove search part

                            }
                        }
                    }
                    //save path
                    string fromPath = curPath["path"];
                    string desPath = output + "\\" + curPath["ab_path"];
                    //Console.WriteLine("Copy from " + fromPath);
                    //Console.WriteLine("To " + desPath);
                    FileHelper.checkExistedDir(desPath);
                    lbText.Text = "Copy " + (++c) + " of " + arrABPath.Length;
                    if (!File.Exists(desPath))
                    {
                        lbText.Text += " from " + fromPath + "\nTo" + desPath;
                        File.Copy(fromPath, desPath, false);
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
                string data = await FileHelper.ReadAsync(f.path);
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
            if (Directory.Exists(output))
            {
                await FileHelper.WriteAsync(res, output + "\\can_not_copy.txt", false);
            }
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
                catch (Exception errEx)
                {
                    Console.WriteLine(errEx.Message);
                }
            }
        }
        private async Task<string> readMapRes(string filePath)
        {
            string found = "";
            string data = await FileHelper.ReadAsync(filePath);
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

            //Console.WriteLine("processMapRes " + filePath);
            Console.WriteLine("listMapInfo " + listMapInfo.Count);
            return found;
        }

        private async void processFile(string filename, string data)
        {
            if (data == null)
            {
                data = await FileHelper.ReadAsync(filename);
            }
            FoundInfo i = new FoundInfo() { path = filename, value = new List<string>() };
            Regex regex = new Regex(paternStr);
            MatchCollection mc = regex.Matches(data);
            //Console.WriteLine("find match " + filename + " : " + mc.Count + " patern " + paternStr);
            foreach (Match match in mc)
            {
                i.value.Add(match.Value);
                //Console.WriteLine("Found value: " + match.Value);
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
                        //Console.WriteLine("Found Res Map value: " + mapDict[x.Value]);
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
            if (!Directory.Exists(dir))
            {
                MessageBox.Show("Directory is EMTPY!!!");
                return;
            }
            //PROCESS FILES
            string[] files = Directory.GetFiles(dir, "*", SearchOption.AllDirectories).Where(name => inc.Any(x => name.EndsWith(x, StringComparison.CurrentCulture))).ToArray().
                Where(name => !exc.Any(x => name.Contains(x))).ToArray();
            int c = 0;
            paternStr = @"[\w\/]+\.(?:" + String.Join("|", ex) + @")\b";
            foreach (string file in files)
            {
                lbText.Text = lbText.Text + "\nAWAIT Read " + file;
                string readStr = await FileHelper.ReadAsync(file);
                processFile(file, readStr);
                lbText.Text = "READ DONE " + (++c) + " of " + files.Length + ":" + file;
            }
            lbText.Text = "DONE Read All!!!!\n\n";
            //DELETE OLD
            if (Directory.Exists(output))
            {
                Directory.Delete(output, true);
            }
            if (File.Exists(output + "\\" + logFoundFilename))
            {
                File.Delete(output + "\\" + logFoundFilename);
            }
            //COPY
            string foundStr = "";
            bool isLogFound = cbLogFound.Checked;
            foreach (FoundInfo f in listFoundInfo)
            {
                copyFiles(f.value.ToArray(), f.path);
                if (isLogFound)
                {
                    foundStr += f.ToString() + "\n";
                }
            }

            lbText.Text = "DONE Copy All " + countCopy;
            MessageBox.Show("Copy Done " + countCopy + " file!!!");

            await processNotCopy();
            if (Directory.Exists(output) && isLogFound)
            {
                await FileHelper.WriteAsync(foundStr, output + "\\" + logFoundFilename, false);
            }

            const string message = "Are you sure that you would like to close the form\nAnd Open OutPut Dirs?";
            const string caption = "Complete Process";
            var r = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // If the no button was pressed ...
            if (r == System.Windows.Forms.DialogResult.Yes)
            {
                if (Directory.Exists(output))
                {
                    Process.Start(output);
                }
                else if (File.Exists(output + "\\" + logFoundFilename))
                {
                    Process.Start(output + "\\" + logFoundFilename);
                }
                else
                {
                    MessageBox.Show("NOT EXISTED OUTPUT " + output);
                }
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
        private void initDefaults()
        {
            ListBox[] lsbArr = { lsbMapVar, lsbReadType, lsbExcludeType, lsbCopyType, lsbSearchPath };
            string[][] strMatrix = { varMaps, inc, exc, ex, searchPath };
            for (int i = 0; i < strMatrix.Length; ++i)
            {
                ListBox lsb = lsbArr[i];
                string[] strArr = strMatrix[i];
                Console.WriteLine("initDefaults load ListBox " + String.Join("  ", strArr));
                foreach (string s in strArr)
                {
                    if (s != "")
                    {
                        lsb.Items.Add(s);
                    }
                }
            }
        }

        private async void loadStorage()
        {
            Console.WriteLine("call loadStorage");
            if (File.Exists(storage_path))
            {
                string data = await FileHelper.ReadAsync(storage_path);
                Console.WriteLine("loadStorage data " + data);
                Dictionary<string, string> dict = null;
                try
                {
                    JObject o = JObject.Parse(data);
                    var json = JsonConvert.SerializeObject(o);
                    dict = JsonConvert.DeserializeObject<Dictionary<string, string>>(json);
                    if (dict != null)
                    {
                        historyTxt = dict;
                        foreach (KeyValuePair<string, string> temp in dict)
                        {
                            switch (temp.Key)
                            {
                                //load Path Text
                                case kResMap:
                                    txtResMapPath.Text = temp.Value.Replace("/", "\\");
                                    selectedMapDir = txtResMapPath.Text;
                                    Console.WriteLine("loadStorage selectedMapDir " + selectedMapDir);
                                    break;
                                case kSearchRes:
                                    txtSearchPath.Text = temp.Value.Replace("/", "\\");
                                    selectedSearchDir = txtSearchPath.Text;
                                    Console.WriteLine("loadStorage selectedSearchDir " + selectedSearchDir);
                                    //processSearchDir();
                                    break;
                                case kOutput:
                                    txtOutput.Text = temp.Value.Replace("/", "\\");
                                    output = txtOutput.Text;
                                    Console.WriteLine("loadStorage output " + output);
                                    break;
                                case kCurPath:
                                    txtPath.Text = temp.Value.Replace("/", "\\");
                                    selectedDir = txtPath.Text;
                                    Console.WriteLine("loadStorage selectedDir " + selectedDir);
                                    break;
                                //Load List Box value
                                case kExcludeType:
                                    if (temp.Value != "")
                                    {
                                        exc = temp.Value.Split(splitStr, System.StringSplitOptions.RemoveEmptyEntries);
                                        Console.WriteLine("loadStorage " + kExcludeType + " " + string.Join(",", exc));
                                    }
                                    break;
                                case kCopyType:
                                    if (temp.Value != "")
                                    {
                                        ex = temp.Value.Split(splitStr, System.StringSplitOptions.RemoveEmptyEntries);
                                        Console.WriteLine("loadStorage " + kCopyType + " " + string.Join(",", ex));
                                    }
                                    break;
                                case kReadType:
                                    if (temp.Value != "")
                                    {
                                        inc = temp.Value.Split(splitStr, System.StringSplitOptions.RemoveEmptyEntries);
                                        Console.WriteLine("loadStorage " + kReadType + " " + string.Join(",", inc));
                                    }
                                    break;
                                case kSearchPath:
                                    if (temp.Value != "")
                                    {
                                        searchPath = temp.Value.Replace("/", "\\").Split(splitStr, System.StringSplitOptions.RemoveEmptyEntries);
                                        Console.WriteLine("loadStorage " + kSearchPath + " " + string.Join(",", searchPath));
                                    }
                                    break;
                                case kMapVar:
                                    if (temp.Value != "")
                                    {
                                        varMaps = temp.Value.Split(splitStr, System.StringSplitOptions.RemoveEmptyEntries);
                                        Console.WriteLine("loadStorage " + kMapVar + " " + string.Join(",", varMaps));
                                    }
                                    break;

                                default:
                                    break;
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("storage Dict is NULL!!!!!!");
                    }
                }
                catch (Exception errEx)
                {
                    Console.WriteLine("ERROR => " + errEx.Message);
                }
            }
            else
            {
                Console.WriteLine("NOT YET EXISTED " + storage_path);
            }
            //INIT DISPLAY
            initDefaults();
            btnDoProcess.Focus();
        }

        public MainHelper()
        {
            InitializeComponent();
            txtSearchPath.Text = Environment.CurrentDirectory;
            txtOutput.Text = output.Replace("/", "\\");
            txtPath.Text = Environment.CurrentDirectory;
            loadStorage();
        }

        private void doSelectCurDir(string path)
        {
            selectedDir = path;
            txtPath.Text = selectedDir;
            historyTxt[kCurPath] = selectedDir;
            saveStorage();
        }
        private void btnOpen_Click(object sender, EventArgs e)
        {
            clearOldCache();

            using (FolderBrowserDialog fbd = new FolderBrowserDialog() { Description = "Select your path:" })
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    doSelectCurDir(fbd.SelectedPath);
                }
            }
        }

        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView.FocusedItem != null)
            {
                Process.Start(lFile[listView.FocusedItem.Index]);
            }
        }

        private void doSelectMapDir(string path)
        {
            selectedMapDir = path;
            txtResMapPath.Text = selectedMapDir;
            historyTxt[kResMap] = selectedMapDir;
            saveStorage();
        }
        private void btnBrowseResMap_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog() { Description = "Select your res maps path:" })
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    doSelectMapDir(fbd.SelectedPath);
                }
            }
        }

        private async void btnReadResMap_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(selectedMapDir))
            {
                MessageBox.Show("Directory is EMTPY!!!");
                return;
            }
            string[] fMaps = Directory.GetFiles(selectedMapDir, "*", SearchOption.AllDirectories);
            paternMapStr = @"(" + String.Join("|", varMaps) + ")";
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
            string mStr = "";
            foreach (KeyValuePair<string, string> p in mapDict)
            {
                mStr += p.Key + " = " + p.Value + ";\n";
            }
            await FileHelper.WriteAsync(mStr, Environment.CurrentDirectory + "/map_res.txt", false);


            var r = MessageBox.Show("Read Resources Map Cache Success!", "Resources Map Cache", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // If the no button was pressed ...
            if (r == System.Windows.Forms.DialogResult.Yes)
            {
                string pfile = Environment.CurrentDirectory + "/map_res.txt";
                if (File.Exists(pfile))
                {
                    Process.Start(pfile);
                }
            }
        }

        private void btnDoProcess_Click(object sender, EventArgs e)
        {
            processDir(selectedDir);
        }

        private void btnClearMapFiles_Click(object sender, EventArgs e)
        {
            lFile.Clear();
            listView.Items.Clear();
            listMapInfo.Clear();
            mapDict.Clear();
        }

        private void doSelectSearchDir(string path)
        {
            selectedSearchDir = path;
            txtSearchPath.Text = selectedSearchDir;
            processSearchDir();
            historyTxt[kSearchRes] = selectedSearchDir;
            saveStorage();
        }
        private void btnBrowseSearchPath_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog() { Description = "Select your search path:" })
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    doSelectSearchDir(fbd.SelectedPath);
                }
            }
        }

        private void doSelectOutputDir(string path)
        {
            output = path;
            txtOutput.Text = output;
            historyTxt[kOutput] = output;
            saveStorage();
        }
        private void btnBrowseOutput_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog() { Description = "Select your output directory:" })
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    doSelectOutputDir(fbd.SelectedPath);
                }
            }
        }

        // Drag and Drop Files to Listbox
        private void dirPathDragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false))
                e.Effect = DragDropEffects.All;
            else
                e.Effect = DragDropEffects.None;
        }
        private string getDirDragDrop(DragEventArgs e)
        {
            foreach (string s in (string[])e.Data.GetData(DataFormats.FileDrop, false))
            {
                string dir = s;
                if (File.Exists(s))
                {
                    dir = Path.GetDirectoryName(s);
                }
                if (Directory.Exists(dir))
                {
                    return dir;
                }
            }
            return null;
        }
        private void dirResMapDragDrop(object sender, DragEventArgs e)
        {
            string dir = getDirDragDrop(e);
            if (dir != null)
            {
                doSelectMapDir(dir);
            }
        }
        private void dirSearchDragDrop(object sender, DragEventArgs e)
        {
            string dir = getDirDragDrop(e);
            if (dir != null)
            {
                doSelectSearchDir(dir);
            }
        }
        private void dirOutputDragDrop(object sender, DragEventArgs e)
        {
            string dir = getDirDragDrop(e);
            if (dir != null)
            {
                doSelectOutputDir(dir);
            }
        }
        private void dirCurPathDragDrop(object sender, DragEventArgs e)
        {
            string dir = getDirDragDrop(e);
            if (dir != null)
            {
                doSelectCurDir(dir);
            }
        }

        private bool handleChangedSelectedListBox(ListBox lsb, string key)
        {
            if (lsb == null) return false;

            if (lsb.SelectedItem == null) return false;

            string s = lsb.SelectedItem.ToString();

            var r = MessageBox.Show("Do you want to Remove >> \"" + s + "\"?", "Remove Selected Item", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == System.Windows.Forms.DialogResult.Yes)
            {
                lsb.Items.RemoveAt(lsb.SelectedIndex);
                MessageBox.Show("Remove >> \"" + s + "\" >> Success!!!");
                switch (key)
                {
                    case kExcludeType:
                        exc = lsb.Items.OfType<string>().ToArray();
                        historyTxt[kExcludeType] = String.Join(splitStr[0], exc);
                        break;
                    case kCopyType:
                        ex = lsb.Items.OfType<string>().ToArray();
                        historyTxt[kCopyType] = String.Join(splitStr[0], ex);
                        break;
                    case kReadType:
                        inc = lsb.Items.OfType<string>().ToArray();
                        historyTxt[kReadType] = String.Join(splitStr[0], inc);
                        break;
                    case kSearchPath:
                        searchPath = lsb.Items.OfType<string>().ToArray();
                        historyTxt[kSearchPath] = String.Join(splitStr[0], searchPath);
                        break;
                    case kMapVar:
                        varMaps = lsb.Items.OfType<string>().ToArray();
                        historyTxt[kMapVar] = String.Join(splitStr[0], varMaps);
                        break;

                    default:
                        break;
                }
                saveStorage();
            }
            else
            {
                lsb.ClearSelected();
            }
            return true;
        }
        private bool handleAddListBox(TextBox tb, ListBox lsb, string key)
        {
            if (tb == null) return false;
            if (lsb == null) return false;
            if (tb.Text != "")
            {
                string s = tb.Text;
                lsb.Items.Insert(0, s);
                tb.Text = "";
                MessageBox.Show("Add << \"" + s + "\" << Success!!!");
                switch (key)
                {
                    case kExcludeType:
                        exc = lsb.Items.OfType<string>().ToArray();
                        historyTxt[kExcludeType] = String.Join(splitStr[0], exc);
                        break;
                    case kCopyType:
                        ex = lsb.Items.OfType<string>().ToArray();
                        historyTxt[kCopyType] = String.Join(splitStr[0], ex);
                        break;
                    case kReadType:
                        inc = lsb.Items.OfType<string>().ToArray();
                        historyTxt[kReadType] = String.Join(splitStr[0], inc);
                        break;
                    case kSearchPath:
                        searchPath = lsb.Items.OfType<string>().ToArray();
                        historyTxt[kSearchPath] = String.Join(splitStr[0], searchPath);
                        break;
                    case kMapVar:
                        varMaps = lsb.Items.OfType<string>().ToArray();
                        historyTxt[kMapVar] = String.Join(splitStr[0], varMaps);
                        break;

                    default:
                        break;
                }
                saveStorage();
            }
            else
            {
                MessageBox.Show("Input Text is Empty!!!");
                tb.Focus();
            }
            return true;
        }

        private void listBoxSelectedIndexChangedExcludeType(object sender, System.EventArgs e)
        {
            handleChangedSelectedListBox(lsbExcludeType, kExcludeType);
        }
        private void btnAddExcludeType_Click(object sender, EventArgs e)
        {
            handleAddListBox(tbAddExcludeType, lsbExcludeType, kExcludeType);
        }

        private void listBoxSelectedIndexChangedReadType(object sender, System.EventArgs e)
        {
            handleChangedSelectedListBox(lsbReadType, kReadType);
        }

        private void btnAddReadType_Click(object sender, EventArgs e)
        {
            handleAddListBox(tbReadType, lsbReadType, kReadType);
        }

        private void listBoxSelectedIndexChangedCopyType(object sender, System.EventArgs e)
        {
            handleChangedSelectedListBox(lsbCopyType, kCopyType);
        }

        private void btnAddCopyType_Click(object sender, EventArgs e)
        {
            handleAddListBox(tbCopyType, lsbCopyType, kCopyType);
        }

        private void listBoxSelectedIndexChangedSearchPath(object sender, System.EventArgs e)
        {
            handleChangedSelectedListBox(lsbSearchPath, kSearchPath);
        }

        private void btnAddSearchPath_Click(object sender, EventArgs e)
        {
            handleAddListBox(tbAddSearchPath, lsbSearchPath, kSearchPath);
        }

        private void listBoxSelectedIndexChangedMapVar(object sender, System.EventArgs e)
        {
            handleChangedSelectedListBox(lsbMapVar, kMapVar);
        }

        private void btnAddMapVar_Click(object sender, EventArgs e)
        {
            handleAddListBox(tbMapVar, lsbMapVar, kMapVar);
        }

        private void cbLogFound_CheckedChanged(object sender, EventArgs e)
        {
            if (cbLogFound.Checked)
            {
                MessageBox.Show("Found Information'll be save into file =>> " + logFoundFilename);
            }
        }

    }
}
