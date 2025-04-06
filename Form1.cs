using bmim2214_lab2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bmim2214_lab2
{
    public partial class FillForm : Form
    {
        private CukraszdakDAL cukraszdakDAL;
        private HelyszinekDAL helyszinekDAL;
        private string errMess;
        private int errNumber;
        private int val;

        public FillForm(int value, string username = "", string password = "")
        {
            this.val = value;
            InitializeComponent();
            string error = string.Empty;
            cukraszdakDAL = new CukraszdakDAL(value, ref error, username, password);
            if (error != "OK")
            {
                errNumber = 1;
                errMess = "Error" + errNumber + Environment.NewLine + "Helyszinek objektumot nem tudtam letrehozni. " + error;
            }
            else
            {
                errMess = "OK";
                helyszinekDAL = new HelyszinekDAL();
            }
        }
      
        private void FillForm_Load(object sender, EventArgs e)
        {
            if (errMess == "OK") //letrejott a Helyszinek objektum
            {
                FillCbHelyszinek();

                FillDgvCukraszdak(-1, null);
            }
            btnDelete.Visible = false;
            btnUpdate.Visible = false;
            btnFilter.Visible = true;
            lbUpdate.Visible = false;
            tbUpdate.Visible = false;
            rbActual.Visible = false;
            rbLast.Visible = false;
            rbNew.Visible = false;
            if (this.val == 1)
            {
                lbUserType.Text = "Vendeg";
            }
            else
            {
                if (this.val == 2)
                {
                    lbUserType.Text = "Admin";
                }
                else
                {
                    lbUserType.Text = "Felhasznalo";
                }
            }
        }     
        private void FillCbHelyszinek()
        {
            string error = string.Empty;
            Helyszin osszes = new Helyszin();
            osszes.HelyszinId = -1;
            osszes.HelyszinNev = "Osszes";
            List<Helyszin> countyList = helyszinekDAL.GetHelyszinListDataSet(ref error);
            countyList.Add(osszes);

            if (error != "OK")
            {
                errNumber++;
                if (errMess == "OK")
                    errMess = string.Empty;
                errMess = errMess + Environment.NewLine +
                    "Error" + errNumber + Environment.NewLine + "Hiba a ComboBox feltoltesenel." + error;
            }
            else
            {
                
                cbHelyszinekFilter.DataSource = countyList;              
                cbHelyszinekFilter.DisplayMember = "HelyszinNev";              
                cbHelyszinekFilter.ValueMember = "HelyszinId";
            }

        }

        private void FillDgvCukraszdak(int HID, string cNev)
        {
            string error = string.Empty;
            dgvCukraszdak.Rows.Clear();
            List<Cukraszda> cukraszdaList = cukraszdakDAL.GetCukraszdaListDataSet(HID, cNev, ref error);

            if ((cukraszdaList.Count != 0) && (error == "OK")) 
            {
                foreach (Cukraszda item in cukraszdaList)
                {
                    try
                    {
                        dgvCukraszdak.Rows.Add(item.CukraszdaId,
                                           item.CukraszdaNev,
                                           item.CukraszdaDolgozok_szama,
                                           item.CukraszdaHelyszin.HelyszinId,
                                           item.CukraszdaHelyszin.HelyszinNev);
                                           
                    }
                    catch (Exception ex)
                    {
                        errNumber++;
                        if (errMess == "OK") errMess = string.Empty;
                        errMess = errMess + Environment.NewLine +
                            "Error" + errNumber + Environment.NewLine + "Invalid data " + ex.Message;
                    }
                }
            }
            else if (error != "OK")
            {
                errNumber++;
                if (errMess == "OK") errMess = string.Empty;
                errMess = errMess + Environment.NewLine +
                    "Error" + errNumber + Environment.NewLine + "Hiba a DataGridView feltoltesenel." + error;
            }
        }
      
        private void FillForm_Shown(object sender, EventArgs e)
        {
            if (errMess != "OK")
            {
                ErrorForm errorForm = new ErrorForm(errMess);
                errorForm.Show();
                errorForm.Focus();
            }
        }      
        private void btnFilter_Click_1(object sender, EventArgs e)
        {

            FillDgvCukraszdak(Convert.ToInt32(cbHelyszinekFilter.SelectedValue), tbCukraszdaFilter.Text.ToString());
            if (errMess != "OK")
            {
                ErrorForm errorForm = new ErrorForm(errMess);
                errorForm.Show();
                errorForm.Focus();
            }
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dgvHelyszinek_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbCukraszdaFilter_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tbMegyeFilter_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbMegyeNev_Click(object sender, EventArgs e)
        {

        }

        private void torlesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.val == 2)
            {
                btnDelete.Visible = true;
                btnUpdate.Visible = false;
                btnFilter.Visible = false;
                rbActual.Checked = false;
                rbNew.Checked = false;
                rbLast.Checked = false;
                rbLast.Visible = false;
                rbNew.Visible = false;
                rbActual.Visible = false;
                lbActual.Visible = false;
                lbNew.Visible = false;
                lbLast.Visible = false;
            }
            else
            {
                MessageBox.Show("Nincs engedelyed ehhez!");
            }
        }

        private void modositasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.val == 2 || this.val == 3)
            {
                btnDelete.Visible = false;
                btnUpdate.Visible = true;
                btnFilter.Visible = false;
                lbUpdate.Visible = true;
                tbUpdate.Visible = true;
            }
            else
            {
                MessageBox.Show("Nincs engedelyed ehhez!");
            }
        }

        private void keresesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnDelete.Visible= false;
            btnUpdate.Visible= false;
            btnFilter.Visible= true;
            rbActual.Checked = false;
            rbNew.Checked = false;
            rbLast.Checked = false;
            rbLast.Visible = false;
            rbNew.Visible = false;
            rbActual.Visible = false;
            lbActual.Visible = false;
            lbNew.Visible = false;
            lbLast.Visible = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {          

            if (dgvCukraszdak.SelectedRows.Count > 0)
            {
                DialogResult confirmResult = MessageBox.Show("Biztos szeretned torolni?",
                                             "Erositsd meg a torlest",
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Question);
                if (confirmResult == DialogResult.Yes)
                {
                    int CID = Convert.ToInt32(dgvCukraszdak.SelectedRows[0].Cells["CID"].Value);
                    cukraszdakDAL.DeleteCukraszda(CID, ref errMess);
                    if (errMess != "OK")
                    {
                        ErrorForm errorForm = new ErrorForm(errMess);
                        errorForm.Show();
                        errorForm.Focus();
                    }
                    MessageBox.Show("Sikeres torles!");
                }
            }
            else
            {
                MessageBox.Show("Nincs kivalasztva torlendo sor!");
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvCukraszdak.SelectedRows.Count > 0)
            {
                if(tbUpdate.Text == "")
                {
                    MessageBox.Show("Nincs megadva az ertek!");
                }
                else
                {
                    int CID = Convert.ToInt32(dgvCukraszdak.SelectedRows[0].Cells["CID"].Value);
                    int regi = Convert.ToInt32(dgvCukraszdak.SelectedRows[0].Cells["DolgozokSzama"].Value);
                    int aktualis = cukraszdakDAL.GetDolgozokSzamaParametrized(CID, ref errMess);
                    try
                    {
                        int uj = Convert.ToInt32(tbUpdate.Text.Trim());
                        Console.WriteLine(uj);
                        if(uj<0)
                        {
                            MessageBox.Show("Adj meg egy pozitiv egesz szamot!");
                        }
                        else
                        {
                            if(regi != aktualis)
                            {
                                if (rbActual.Checked == false && rbLast.Checked == false && rbNew.Checked == false)
                                {
                                    MessageBox.Show("Konkurencia problema lepett fel, kerlek valassz milyen erteket szeretnel!");
                                    rbActual.Visible = true;
                                    rbLast.Visible = true;
                                    rbNew.Visible = true;

                                    lbActual.Text = aktualis.ToString();
                                    lbLast.Text = regi.ToString();
                                    lbNew.Text = uj.ToString();

                                    lbActual.Visible = true;
                                    lbNew.Visible = true;
                                    lbLast.Visible = true;
                                }
                                else
                                {
                                    if(rbLast.Checked)
                                    {
                                        cukraszdakDAL.UpdateCukraszdaDolgozokSzama(CID, regi, ref errMess);
                                        if (errMess != "OK")
                                        {
                                            ErrorForm errorForm = new ErrorForm(errMess);
                                            errorForm.Show();
                                            errorForm.Focus();
                                        }
                                        dgvCukraszdak.SelectedRows[0].Cells["DolgozokSzama"].Value = regi;
                                        MessageBox.Show("Sikeres modositas!");
                                   
                                        rbLast.Checked = false;
                                        rbLast.Visible = false;
                                        rbNew.Visible = false;
                                        rbActual.Visible = false;
                                        lbActual.Visible = false;
                                        lbNew.Visible = false;
                                        lbLast.Visible = false;
                                    }
                                    else
                                    {
                                        if (rbActual.Checked)
                                        {
                                            cukraszdakDAL.UpdateCukraszdaDolgozokSzama(CID, aktualis, ref errMess);
                                            if (errMess != "OK")
                                            {
                                                ErrorForm errorForm = new ErrorForm(errMess);
                                                errorForm.Show();
                                                errorForm.Focus();
                                            }
                                            MessageBox.Show("Sikeres modositas!");
                                            dgvCukraszdak.SelectedRows[0].Cells["DolgozokSzama"].Value = aktualis;
                                            rbActual.Checked = false;
                                            rbLast.Visible = false;
                                            rbNew.Visible = false;
                                            rbActual.Visible = false;
                                            lbActual.Visible = false;
                                            lbNew.Visible = false;
                                            lbLast.Visible = false;
                                        }
                                        else
                                        {
                                            if (rbNew.Checked)
                                            {
                                                cukraszdakDAL.UpdateCukraszdaDolgozokSzama(CID, uj, ref errMess);
                                                if (errMess != "OK")
                                                {
                                                    ErrorForm errorForm = new ErrorForm(errMess);
                                                    errorForm.Show();
                                                    errorForm.Focus();
                                                }
                                                MessageBox.Show("Sikeres modositas!");
                                                dgvCukraszdak.SelectedRows[0].Cells["DolgozokSzama"].Value = uj;
                                                rbNew.Checked = false;
                                                rbLast.Visible = false;
                                                rbNew.Visible = false;
                                                rbActual.Visible = false;
                                                lbActual.Visible = false;
                                                lbNew.Visible = false;
                                                lbLast.Visible = false;
                                            }                                          
                                        }
                                    }
                                }
                            }
                            else
                            {
                                cukraszdakDAL.UpdateCukraszdaDolgozokSzama(CID, uj, ref errMess);
                                if (errMess != "OK")
                                {
                                    ErrorForm errorForm = new ErrorForm(errMess);
                                    errorForm.Show();
                                    errorForm.Focus();
                                }
                                MessageBox.Show("Sikeres modositas!");
                            }
                        }
                    }
                    catch(FormatException)
                    {
                        MessageBox.Show("Adj meg egy pozitiv egesz szamot!");
                    }
                }
                
            }
            else
            {
                MessageBox.Show("Nincs kivalasztva modositando sor!");
            }
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            Form form2 = new FillForm2();
            form2.Show();
            this.Close();
        }

        private void lbUserType_Click(object sender, EventArgs e)
        {
            
        }
    }
}
