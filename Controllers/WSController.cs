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

    }
}
