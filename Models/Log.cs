using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Blog.Models
{
    public enum QueryType 
    { 
        SELECT = 1,
        INSERT = 2,
        UPDATE = 3,
        DELETE = 4
    }


    public class Log
    {
        public int Id { get; set; }

        public DateTime Created { get; set; }

        public QueryType Type { get; set; }

        public string Query { get; set; }


        public Log()
        {
            Created = DateTime.Now;
        }

    }
}