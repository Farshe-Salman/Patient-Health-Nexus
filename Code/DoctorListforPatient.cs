using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Patient_Health_Nexus.Code
{
    public partial class DoctorListforPatient : Form
    {
        string connectionString = "data source=DESKTOP-HRU59TM\\SQLEXPRESS; database=PatientHealthNexus; integrated security=SSPI";
        string userNamePass;
        public DoctorListforPatient(string x)
        {
            userNamePass = x;
            InitializeComponent();
        }

        #region Method
        private Form activeForm = null;
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

        private void DoctorListBTN_Click(object sender, EventArgs e)
        {
            openChildForm(new findDoctor(userNamePass));
        }

        private void DoctorListforPatient_Load(object sender, EventArgs e)
        {
            openChildForm(new findDoctor(userNamePass));
        }

        private void DrApBTN_Click(object sender, EventArgs e)
        {
            openChildForm(new AppointmentListForAdminNPatient(userNamePass));
        }

        private void back_BTN_Click(object sender, EventArgs e)
        {
            this.Hide();
            PatientMainMainPage patientMainMainPage = new PatientMainMainPage(userNamePass);
            patientMainMainPage.Show();
        }
    }
}
