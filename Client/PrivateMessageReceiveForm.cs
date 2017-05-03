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
    public partial class PrivateMessageReceiveForm : Form, Proxy.IServerCallback
    {
        public PrivateMessageReceiveForm()
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

        public void UpdatePublicChatTextBox(string login, string message)
        {
            return;
        }

        public void UpdateUsersList(string[] users)
        {
            return;
        }

        private void PrivateMessageReceiveForm_Load(object sender, EventArgs e)
        {

        }
    }
}
