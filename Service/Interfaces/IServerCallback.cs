﻿using System;
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

        [OperationContract(IsOneWay = true)]
        void LoginErrorCallback(string message);

        [OperationContract(IsOneWay = true)]
        void UpdateUsersList(IList<string> users);
    }
}
