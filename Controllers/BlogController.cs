using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using Blog.Models;

namespace Blog.Controllers
{
    public class BlogController : Controller
    {
        BlogDataContext _db = new BlogDataContext();

        public ActionResult Index()
        {
            
            Log log = new Log();
            log.Type = QueryType.SELECT;
            log.Query = "SELECT ...";

            var users = _db.Users.ToList();

            _db.Logs.Add(log);
            _db.SaveChanges();

            return View(users);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(User user)
        {
            Log log = new Log();
            log.Type = QueryType.INSERT;
            log.Query = "INSERT ...";

            if (ModelState.IsValid)
            {
                _db.Users.Add(user);
                _db.Logs.Add(log);
                _db.SaveChanges();

                return RedirectToAction("Index");
            }
            return View(user);
        }

        public ActionResult Edit(int id)
        {
            Log log = new Log();
            log.Type = QueryType.SELECT;
            log.Query = "SELECT ...";

            User user = _db.Users.Find(id);

            _db.Logs.Add(log);
            _db.SaveChanges();

            return View(user);  
        }

        [HttpPost]
        public ActionResult Edit(User user)
        {
            Log log = new Log();
            log.Type = QueryType.UPDATE;
            log.Query = "UPDATE ...";

            if (ModelState.IsValid)
            {
                _db.Entry(user).State = EntityState.Modified;
                _db.Logs.Add(log);
                _db.SaveChanges();

                return RedirectToAction("Index");
            }
            return View(user);
        }

        public ActionResult Delete(int id)
        {
            Log log = new Log();
            log.Type = QueryType.DELETE;
            log.Query = "DELETE ...";

            User user = _db.Users.Find(id);
            _db.Users.Remove(user);
            _db.Logs.Add(log);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
