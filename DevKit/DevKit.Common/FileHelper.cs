using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevKit.Common
{
    public class FileHelper
    {
        public FileHelper()
        {

        }

        public static string GenerateDateFile(DateTime date)
        {
            return date.Year.ToString("0000") + date.Month.ToString("00") + date.Day.ToString("00") + ".sql";
        }


        public static void CreateFile(string path)
        {
            TextWriter tw = new StreamWriter(path);
            tw.Close();
        }

        public static void UpdateFileText(string path,string query)
        {
            System.IO.File.WriteAllText(path, query);
        }

        public static string ReadFile(string path)
        {
            return File.ReadAllText(path);
        }

        public static void AppendText(string path,string query)
        {
            TextWriter tw = new StreamWriter(path);
            tw.WriteLine(query);
            tw.Close();
        }
    }
}
