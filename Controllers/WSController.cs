using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

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
            AppServiceClient client = new AppServiceClient();

            string DegreeBefore = "Abc.";
            string Name = "Aaaa";
            string Surname = "Bvvv";
            string DegreeAfter = "Csc";
            string Street = "Ostravská 56";
            int StreetNumber = 56;
            string Town = "Český Těšín";
            int Zipcode = 73701;

            ViewData["Result"] = client.Insert(DegreeBefore, Name, Surname, DegreeAfter, Street, StreetNumber, Town, Zipcode);

            return View();
        }

    }
}
