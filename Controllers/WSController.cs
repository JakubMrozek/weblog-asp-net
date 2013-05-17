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
            AuthorizationServiceSoapClient client = new AuthorizationServiceSoapClient();
            Access access = new Access();
            access.User = "abc";
            access.Password = "xxx";

            DateTime date = new DateTime(2013, 5, 17);

            var a = client.GetAuthorizations(access, date);

            System.Diagnostics.Debug.WriteLine(a);

            return View();
        }

    }
}
