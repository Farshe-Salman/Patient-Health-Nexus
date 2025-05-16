using Patient_Health_Nexus.Code;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Patient_Health_Nexus
{
    public partial class PatientMainPage : Form
    {
        string userNamePass;
        private Form activeForm = null;

        public PatientMainPage(string x)
        {
            userNamePass = x;
            InitializeComponent();

            // Automatically open the medicineInPatientPage form on load
            openChildForm(new medicineInPatientPage(userNamePass));
        }

        #region Method
        public void openChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel2.Controls.Add(childForm);
            panel2.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        #endregion Method

        private void medicineCartBTN_Click(object sender, EventArgs e)
        {
            openChildForm(new medicineInPatientPage(userNamePass));
        }

        private void addToCartBTN_Click(object sender, EventArgs e)
        {
            openChildForm(new AddToCartPage(userNamePass));
        }

        

        private void back_BTN_Click(object sender, EventArgs e)
        {
            this.Hide();
            PatientMainMainPage patientMainMainPage = new PatientMainMainPage(userNamePass);
            patientMainMainPage.Show();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
