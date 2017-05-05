using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class PrivateChatForm : Form, Proxy.IServerCallback
    {
        private string _receiver;
        private string _sender;
        private InstanceContext _context;
        private Proxy.ServerClient _client;

        public PrivateChatForm()
        {
            InitializeComponent();
        }

        public PrivateChatForm(string receiver)
        {
            InitializeComponent();
            _receiver = receiver;
            _context = new InstanceContext(this);
            _client = new Proxy.ServerClient(_context);
        }

        public PrivateChatForm(string sender, string receiver)
        {
            InitializeComponent();
            _receiver = receiver;
            _sender = sender;
            _context = new InstanceContext(this);
            _client = new Proxy.ServerClient(_context);
        }

        public void LoginErrorCallback(string message)
        {
            throw new NotImplementedException();
        }

        public void OpenPrivateChatForm(string sender, string message)
        {
            Console.WriteLine("Otwieram okno prywatnego czatu");
            PrivateChatForm form = new PrivateChatForm();
            form.PrivateChatTextBox.Text += $"{sender}: {message}{Environment.NewLine}";
            form.Show();
        }

        public void OpenPrivateChatForm(string sender, string receiver, string message)
        {
            throw new NotImplementedException();
        }

        public void RegisterNotify(string message)
        {
            throw new NotImplementedException();
        }

        public void UpdateLoginPublicChatTextBox()
        {
            throw new NotImplementedException();
        }

        public void UpdateLogoutUsersList()
        {
            throw new NotImplementedException();
        }

        public void UpdatePrivateChatForm(string sender, string message)
        {
            PrivateChatTextBox.Text += $"{sender}: {message}{Environment.NewLine}";
        }

        public void UpdatePublicChatTextBox(string login, string message)
        {
            throw new NotImplementedException();
        }

        public void UpdateUsersList(string[] users)
        {
            throw new NotImplementedException();
        }

        private void SendPrivateMessageButton_Click(object sender, EventArgs e)
        {
            MainForm mainForm = (MainForm)Application.OpenForms[0];

            string senderLogin = mainForm.Login;
            string message = PrivateMessageTextBox.Text;
            PrivateMessageTextBox.Text = "";
            _client.SendPrivateMessage(senderLogin, _receiver, message);
        }
    }
}
