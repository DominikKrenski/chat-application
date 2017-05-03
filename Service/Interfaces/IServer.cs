using Service.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Service.Interfaces
{
    [ServiceContract(CallbackContract = typeof(IServerCallback), SessionMode = SessionMode.Required)]
    public interface IServer
    {
        [OperationContract(IsOneWay = true)]
        void Register(RegisterUser user);

        [OperationContract(IsOneWay = true)]
        void Login(LoginUser user);
    }
}
