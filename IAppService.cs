using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Blog
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService2" in both code and config file together.
    [ServiceContract]
    public interface IAppService
    {
        [OperationContract]
        int Count();

        [OperationContract]
        bool Insert(string DegreeBefore, string Name, string Surname, string DegreeAfter, string Street, int StreetNumber, string Town, int Zipcode);
    }
}
