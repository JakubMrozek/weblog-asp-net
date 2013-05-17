using Blog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Blog.Controllers
{
    public class LogController : Controller
    {

        BlogDataContext _db = new BlogDataContext();

        public ActionResult Index()
        {
            var logs = _db.Logs.ToList();
            return View(logs);
        }

    }
}
