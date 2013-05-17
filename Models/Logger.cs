using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Blog.Models
{
    public class Logger
    {
        public void log(string query)
        {
            System.Diagnostics.Debug.WriteLine("***************************");
            System.Diagnostics.Debug.WriteLine(query);
            System.Diagnostics.Debug.WriteLine("***************************");
        }
    }
}