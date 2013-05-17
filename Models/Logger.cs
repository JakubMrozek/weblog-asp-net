using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;

namespace Blog.Models
{
    public class Logger
    {
        private StreamWriter file;

        public Logger()
        {
            string baseDir = AppDomain.CurrentDomain.BaseDirectory;
            string logFile = string.Format("{0}/Data/{1}", baseDir, "log.txt");
            file = new System.IO.StreamWriter(logFile);
        }

        public void log(string query)
        {
            System.Diagnostics.Debug.WriteLine("***************************");
            System.Diagnostics.Debug.WriteLine(query);
            System.Diagnostics.Debug.WriteLine("***************************");

            file.WriteLine(query);
            //file.Close();

            /*
            string xmlFile = string.Format("{0}/Data/{1}", AppDomain.CurrentDomain.BaseDirectory, "myxml.xml");
            System.IO.StreamWriter file = new System.IO.StreamWriter(xmlFile);
            
            System.IO.StreamWriter file = new System.IO.StreamWriter("~\\log.txt");
            file.WriteLine(query);

            file.Close();
            */
        }
    }
}