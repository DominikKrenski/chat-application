using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class RegisterForm : Form, Proxy.IServerCallback
    {
        private enum Sex { Mężczyzna, Kobieta };

        private string _filePath = "";

        public RegisterForm()
        {
            InitializeComponent();

            SexComboBox.Items.Add(Sex.Mężczyzna);
            SexComboBox.Items.Add(Sex.Kobieta);
            SexComboBox.SelectedIndex = 0;
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            MainForm form = (MainForm)Application.OpenForms[0];

            int age;

            if (!Int32.TryParse(AgeTextBox.Text, out age)){
                throw new NotImplementedException();
            }

            // Zamiana obrazka na tablicę bajtów
            byte[] avatar;
            string ext = Path.GetExtension(_filePath);

            Image image = Image.FromFile(_filePath);

            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                avatar = ms.ToArray();
            }

            Proxy.RegisterUser user = new Proxy.RegisterUser
            {
                Login = LoginTextBox.Text,
                Password = PasswordTextBox.Text,
                PasswordConfirm = PasswordConfirmTextBox.Text,
                Name = NameTextBox.Text,
                Surname = SurnameTextBox.Text,
                Sex = SexComboBox.Text,
                Age = age,
                Avatar = avatar
            };

            form.Client.Register(user);
        }

        public void RegisterNotify(string message)
        {
            return;
        }

        public void LoginErrorCallback(string message)
        {
            return;
        }

        public void UpdateUsersList(string[] users)
        {
            return;
        }

        public void UpdatePublicChatTextBox(string login, string message)
        {
            return;
        }

        public void UpdateLogoutUsersList()
        {
            return;
        }

        public void UpdateLoginPublicChatTextBox()
        {
            return;
        }

        public void OpenPrivateChatForm(string sender, string message)
        {
            throw new NotImplementedException();
        }

        public void UpdatePrivateChatForm(string sender, string message)
        {
            throw new NotImplementedException();
        }

        public void OpenPrivateChatForm(string sender, string receiver, string message)
        {
            throw new NotImplementedException();
        }

        public void UpdateLogoutPrivateChatForm(string sender, string[] users, string message)
        {
            throw new NotImplementedException();
        }

        public void UpdateExitMainForm(string sender, string message)
        {
            throw new NotImplementedException();
        }

        private void FolderBrowserDialogButton_Click(object sender, EventArgs e)
        {
            // Pobranie ścieżki do awatara
            OpenFileDialog dialog = new OpenFileDialog();

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string name = dialog.FileName;
                FilePathTextBox.Text = name;
                _filePath = name;
            }
        }

        public void UpdateUsersList(string[] users, byte[][] avatars)
        {
            throw new NotImplementedException();
        }
    }
}
