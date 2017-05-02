using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Service.Interfaces
{
    public interface IServerCallback
    {
        [OperationContract(IsOneWay = true)]
        void RegisterNotify(string message);
    }
}
