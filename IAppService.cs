using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Blog
{
    [ServiceContract]
    public interface IAppService
    {
        [OperationContract]
        int Count();

        [OperationContract]
        bool Insert(string DegreeBefore, string Name, string Surname, string DegreeAfter, string Street, int StreetNumber, string Town, int Zipcode);
    }
}
