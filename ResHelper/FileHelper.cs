using System;
using System.IO;
using System.Threading.Tasks;

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
            Directory.CreateDirectory(dir);
        }
        return true;
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
}