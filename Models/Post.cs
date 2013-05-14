using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Blog.Models
{
    public class Post
    {
        [ScaffoldColumn(false)]
        public long Id { get; set; }

        [ScaffoldColumn(false)]
        public DateTime Created { get; set; }

        public string Title { get; set; }

        public string Summary { get; set; }

        [DataType(DataType.MultilineText)]
        public string Content { get; set; }

        public Post()
        {
            Created = DateTime.Now;
        }

    }
}