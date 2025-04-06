using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace bmim2214_lab2
{
    public partial class FillForm3 : Form
    {
        private CukraszdakDAL cukraszdakDAL;
        private HelyszinekDAL helyszinekDAL;
        private string errMess;
        private int errNumber;
        public FillForm3()
        {
            InitializeComponent();

            string error = string.Empty;
            cukraszdakDAL = new CukraszdakDAL(0, ref error);
            if (error != "OK")
            {
                errNumber = 1;
                errMess = "Error" + errNumber + Environment.NewLine + "Baj van a regisztracio elokeszitesevel. " + error;
            }
            else
            {
                errMess = "OK";
                helyszinekDAL = new HelyszinekDAL();
            }


            tbrp.PasswordChar = '*';
            tbrp2.PasswordChar = '*';
        }

        private void btExit3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btrb_Click(object sender, EventArgs e)
        {
            
            Form form3 = new FillForm2();
            form3.Show();
            this.Close();

        }

        private void btr_Click(object sender, EventArgs e)
        {
            if (tbrp.Text == tbrp2.Text)
            {

                string username = tbru.Text;
                string password = tbrp.Text;
                Console.WriteLine(username);
                Console.WriteLine(password);
                cukraszdakDAL.CreateUser(username, password, ref errMess);
                Console.WriteLine(errMess);
                MessageBox.Show("Sikeres regisztralas!");
            }
            else
            {
                MessageBox.Show("A jelszavak nem egyezok!");
            }
        }

        private void tbrp2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
