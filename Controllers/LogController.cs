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

        public ActionResult Index()
        {
            Logger log = new Logger();
            ViewData["Queries"] = log.ReadAll();
            return View();
        }

    }
}
