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

        private void PrivateMessageReceiveForm_Load(object sender, EventArgs e)
        {

        }

        private void ResponseButton_Click(object sender, EventArgs e)
        {
            PrivateMessageSendForm form = new PrivateMessageSendForm();

            // Referencja do przycisku wywołującego zdarzenie
            Button button = (Button)sender;

            // Referencja do formularza, który zawiera przycisk wywołujący zdarzenie
            PrivateMessageReceiveForm form1 = (PrivateMessageReceiveForm) button.FindForm();

            // Pobranie referencji do głównego okna aplikacji
            MainForm mainForm = (MainForm)Application.OpenForms[0];
            
            // Przypisanie do pola adresata wartości nadawcy
            form.PrivateLoginTextBox.Text = form1.SenderTextBox.Text;

            // Zamknięcie formularza odebranej wiadomości
            form1.Close();

            form.Show();
        }
    }
}
