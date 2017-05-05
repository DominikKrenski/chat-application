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

        [OperationContract(IsOneWay = true)]
        void LoginErrorCallback(string message);

        [OperationContract(IsOneWay = true)]
        void UpdateUsersList(IList<string> users);

        [OperationContract(IsOneWay = true)]
        void UpdatePublicChatTextBox(string login, string message);

        [OperationContract(IsOneWay = true)]
        void UpdateLogoutUsersList();

        [OperationContract(IsOneWay = true)]
        void UpdateLoginPublicChatTextBox();

        [OperationContract(IsOneWay = true)]
        void OpenPrivateChatForm(string sender, string receiver, string message);

        [OperationContract(IsOneWay = true)]
        void UpdatePrivateChatForm(string sender, string message);
    }
}
