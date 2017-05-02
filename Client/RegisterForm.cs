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
    public partial class RegisterForm : Form
    {
        private enum Sex { Mężczyzna, Kobieta };

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
    }
}
