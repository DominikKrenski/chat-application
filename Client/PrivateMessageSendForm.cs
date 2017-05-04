using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class PrivateMessageSendForm : Form, Proxy.IServerCallback
    {
        public PrivateMessageSendForm()
        {
            InitializeComponent();
        }

        public void DisplayReceivePrivateMessageForm(string login, string message)
        {
            return;
        }

        public void LoginErrorCallback(string message)
        {
            return;
        }

        public void RegisterNotify(string message)
        {
            return;
        }

        public void UpdateLoginPublicChatTextBox()
        {
            return;
        }

        public void UpdateLogoutUsersList()
        {
            return;
        }

        public void UpdatePublicChatTextBox(string login, string message)
        {
            return;
        }

        public void UpdateUsersList(string[] users)
        {
            return;
        }

        private void PrivateMessageSendForm_Load(object sender, EventArgs e)
        {

        }

        private void SendPrivateMessageButton_Click(object sender, EventArgs e)
        {
            MainForm form = (MainForm) Application.OpenForms[0];

            string login = PrivateLoginTextBox.Text;
            string message = PrivateMessageTextBox.Text;

            form.Client.SendPrivateMessage(login, message);
        }
    }
}
