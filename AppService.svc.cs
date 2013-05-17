using Blog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Blog
{
    
    public class AppService : IAppService
    {
        BlogDataContext _db = new BlogDataContext();

        public int Count()
        {
            return _db.Users.Count();
        }
    }
}
