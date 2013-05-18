using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using Blog.Models;

namespace Blog.Controllers
{
    public class UsersController : Controller
    {
        DataContext db = new DataContext();

        public ActionResult Index()
        {
            var users = db.Users.ToList();
            return View(users);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(User user)
        {
            if (ModelState.IsValid)
            {
                db.Users.Add(user);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(user);
        }

        public ActionResult Edit(int id)
        {
            User user = db.Users.Find(id);
            if (user == null) {
                return RedirectToAction("Index");
            }
            return View(user);  
        }

        [HttpPost]
        public ActionResult Edit(User user)
        {
            if (user == null)
            {
                return RedirectToAction("Index");
            }

            if (ModelState.IsValid)
            {
                db.Entry(user).State = EntityState.Modified;
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            return View(user);
        }

        public ActionResult Delete(int id)
        {
            User user = db.Users.Find(id);
            if (user == null)
            {
                return RedirectToAction("Index");
            }
            db.Users.Remove(user);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
