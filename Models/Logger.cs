using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;

namespace Blog.Models
{
    public class Logger
    {
        public void Log(string query)
        {
            StreamWriter file = new StreamWriter(GetFilePath(), true);
            file.WriteLine(query);
            file.Close();
        }

        public string ReadAll()
        {
            StreamReader file = new StreamReader(GetFilePath());
            string content = file.ReadToEnd();
            file.Close();
            return content;
        }

        private string GetFilePath()
        {
            string baseDir = AppDomain.CurrentDomain.BaseDirectory;
            string logFile = string.Format("{0}/Data/{1}", baseDir, "log.txt");
            return logFile;
        }
    }
}