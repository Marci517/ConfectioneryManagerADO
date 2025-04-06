using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace bmim2214_lab2
{
    public partial class FillForm2 : Form
    {
        public FillForm2()
        {
            InitializeComponent();
            tbPassword.PasswordChar = '*';
        }

        private void FillForm2_Load(object sender, EventArgs e)
        {

        }

        private void btGuest_Click(object sender, EventArgs e)
        {
            int value = 1;
            Form form1 = new FillForm(value);
            form1.Show();
            this.Hide();
        }

        private void btAdmin_Click(object sender, EventArgs e)
        {
            if (tbUsername.Text == "Fonok" && tbPassword.Text == "fonok")
            { int value = 2;
                Form form1 = new FillForm(value);
                form1.Show();
                this.Hide(); 
            }
            else
            {
                MessageBox.Show("Helytelen felhasznalonev vagy jelszo!");
            }

        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            int value = 3;
            string username = tbUsername.Text;
            string password = tbPassword.Text;
            Form form1 = new FillForm(value, username, password);
            form1.Show();
            this.Hide();
        }

        private void btExit2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btRegistration_Click(object sender, EventArgs e)
        {
            Form form3 = new FillForm3();
            form3.Show();
            this.Hide();
        }
    }
}
