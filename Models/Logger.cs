using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Xml;

namespace Blog.Models
{
    public class Logger
    {

        public bool IsEnable()
        {
            try
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(GetXmlPath());
                XmlNode node = doc.SelectSingleNode("nastaveni/logovani");
                return node.InnerText == "zapnuto";

            }
            catch (FileNotFoundException e) 
            {
                return false;
            }


        }

        public void Log(string query)
        {
            if (!IsEnable()) return;

            StreamWriter file = new StreamWriter(GetFilePath(), true);
            file.WriteLine(DateTime.Now);
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

        private string GetXmlPath()
        {
            string baseDir = AppDomain.CurrentDomain.BaseDirectory;
            return string.Format("{0}/{1}", baseDir, "settings.xml");
        }

        private string GetFilePath()
        {
            string baseDir = AppDomain.CurrentDomain.BaseDirectory;
            return string.Format("{0}/Data/{1}", baseDir, "log.txt");
        }
    }
}