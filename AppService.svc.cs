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
        DataContext db = new DataContext();

        public int Count()
        {
            return db.Users.Count();
        }

        public bool Insert(string DegreeBefore, string Name, string Surname, string DegreeAfter, string Street, int StreetNumber, string Town, int Zipcode)
        {
            User user = new User();
            user.DegreeBefore = DegreeBefore;
            user.Name = Name;
            user.Surname = Surname;
            user.DegreeAfter = DegreeAfter;
            user.Street = Street;
            user.StreetNumber = StreetNumber;
            user.Town = Town;
            user.Zipcode = Zipcode;

            try
            {
                db.Users.Add(user);
                db.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
