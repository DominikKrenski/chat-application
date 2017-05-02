using Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Service.Data;

namespace Service.Implementations
{
    [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Single, InstanceContextMode = InstanceContextMode.Single)]
    public class Server : IServer
    {
        public void Register(RegisterUser user)
        {
            throw new NotImplementedException();
        }
    }
}
