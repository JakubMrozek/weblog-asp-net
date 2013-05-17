using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Blog.Models;
using System.Data;


namespace Blog.Controllers
{
    public class WSController : Controller
    {
        public ActionResult Index()
        {
            //info o prihlaseni
            Access access = new Access();
            access.User = "abc";
            access.Password = "xxx";

            //od ktereho data
            int Day = 1;
            int Month = 5;
            int Year = 2013;

            DateTime date = new DateTime(Year, Month, Day);


            AuthorizationServiceSoapClient client = new AuthorizationServiceSoapClient();
            AuthorizedPersonData result = client.GetAuthorizations(access, date);

            ViewData["Persons"] = result.AuthorizedPersons;
            ViewData["Day"] = Day;
            ViewData["Month"] = Month;
            ViewData["Year"] = Year;

            return View();
        }

        public ActionResult Count()
        {
            AppServiceClient client = new AppServiceClient();
            ViewData["Count"] = client.Count(); 
            return View();
        }

        public ActionResult Insert()
        {
            ViewData["ShowForm"] = true;
            return View();
        }

        [HttpPost]
        public ActionResult Insert(User user)
        {
            ViewData["ShowForm"] = true;

            if (ModelState.IsValid)
            {
                AppServiceClient client = new AppServiceClient();
                ViewData["Result"] = client.Insert(
                    user.DegreeBefore, 
                    user.Name, 
                    user.Surname, 
                    user.DegreeAfter, 
                    user.Street, 
                    user.StreetNumber, 
                    user.Town, 
                    user.Zipcode
                );
                ViewData["ShowForm"] = false;
            }
            return View(user);
        }

    }
}
