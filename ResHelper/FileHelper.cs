using System;
using System.IO;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

public static class FileHelper
{
    public static bool checkExistedDir(string destination)
    {
        if (File.Exists(destination))
        {
            return true;
        }
        if (Directory.Exists(destination))
        {
            return true;
        }
        string dir = Path.GetDirectoryName(destination);
        if (!Directory.Exists(dir))
        {
            try
            {
                Directory.CreateDirectory(dir);
            }
            catch (Exception er)
            {
                Console.WriteLine("err " + er.Message);
                return false;
            }
        }
        return true;
    }
    public static void copyDirectory(string sourceDirName, string destDirName)
    {
        Console.WriteLine("call copyDirectory " + sourceDirName + "\nto => " + destDirName);
        if (!Directory.Exists(sourceDirName))
        {
            Console.WriteLine("Source directory does not exist or could not be found: " + sourceDirName);
            return;
        }
        string[] files = Directory.GetFiles(sourceDirName, "*", SearchOption.AllDirectories);
        foreach (string file in files)
        {
            string desPath = Path.Combine(destDirName, file.Substring(sourceDirName.Length + 1));//get absolute path rm sourceDirName\\
            bool r = checkExistedDir(desPath);
            if (!r) continue;
            if (!File.Exists(desPath))
            {
                File.Copy(file, desPath, false);
            }
        }
    }
    public static async Task<bool> WriteAsync(string lines, string fName, bool append)
    {
        if (fName == null)
        {
            fName = Environment.CurrentDirectory + "/default.txt";
        }
        if (!File.Exists(fName))
        {
            File.CreateText(fName).Dispose();
        }
        using (StreamWriter file = new StreamWriter(fName, append: append))
        {
            await file.WriteLineAsync(lines);
        }
        return true;
    }

    //private static async Task<string> ReadAsync(string filename)
    public static async Task<string> ReadAsync(string filename)
    {
        string str;
        using (StreamReader sr = new StreamReader(filename))
        {

            str = await sr.ReadToEndAsync();
        }

        return str;
    }

    /// <summary>
    /// Serializes an object.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="serializableObject"></param>
    /// <param name="fileName"></param>
    public static void SerializeObject<T>(T serializableObject, string fileName)
    {
        if (serializableObject == null) { return; }

        try
        {
            XmlDocument xmlDocument = new XmlDocument();
            XmlSerializer serializer = new XmlSerializer(serializableObject.GetType());
            using (MemoryStream stream = new MemoryStream())
            {
                serializer.Serialize(stream, serializableObject);
                stream.Position = 0;
                xmlDocument.Load(stream);
                xmlDocument.Save(fileName);
                stream.Close();
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error " + ex.Message);
        }
        Console.WriteLine("Call SerializeObject " + fileName);
    }


    /// <summary>
    /// Deserializes an xml file into an object list
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="fileName"></param>
    /// <returns></returns>
    public static T DeSerializeObject<T>(string fileName)
    {
        Console.WriteLine("Call DeSerializeObject " + fileName);
        if (string.IsNullOrEmpty(fileName)) { return default(T); }

        T objectOut = default(T);

        try
        {
            string attributeXml = string.Empty;

            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load(fileName);
            string xmlString = xmlDocument.OuterXml;

            using (StringReader read = new StringReader(xmlString))
            {
                Type outType = typeof(T);

                XmlSerializer serializer = new XmlSerializer(outType);
                using (XmlReader reader = new XmlTextReader(read))
                {
                    objectOut = (T)serializer.Deserialize(reader);
                    reader.Close();
                }

                read.Close();
            }
        }
        catch (Exception ex)
        {
            //Log exception here
            Console.WriteLine("Error " + ex.Message);
        }

        return objectOut;
    }
}