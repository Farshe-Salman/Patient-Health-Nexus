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

    public partial class HospitalDoctorDetails : Form
    {
        string connectionString = "data source=DESKTOP-HRU59TM\\SQLEXPRESS; database=PatientHealthNexus; integrated security=SSPI";
        string userNamePass;
        public HospitalDoctorDetails(string x)
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
            openChildForm(new DoctorList(userNamePass));
        }

        private void back_BTN_Click(object sender, EventArgs e)
        {
            if(userNamePass == "admin" || userNamePass == "execuitive")
            {
                this.Hide();
                AdminMainPage adminMainPage = new AdminMainPage(userNamePass);
                adminMainPage.Show();
            }
            else
            {
                this.Hide();
                HospitalMainPage hospitalMainPage=new HospitalMainPage(userNamePass);
                hospitalMainPage.Show();
            }
        }

        private void adddocBTN_Click(object sender, EventArgs e)
        {
            openChildForm(new AddDoctor(userNamePass));
        }

        private void HospitalDoctorDetails_Load(object sender, EventArgs e)
        {
            openChildForm(new DoctorList(userNamePass));
            if(userNamePass=="admin"||userNamePass== "execuitive")
            {
                docAppHospitalBTN.Hide();
            }
            else
            {
                docAppadminBTN.Hide();
            }
        }

        private void docAppHospitalBTN_Click(object sender, EventArgs e)
        {
            openChildForm(new AppointmentListForHospital(userNamePass));
        }

        private void docAppadminBTN_Click(object sender, EventArgs e)
        {
            openChildForm(new AppointmentListForAdminNPatient(userNamePass));
        }
    }
}
