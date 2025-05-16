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
    public partial class PatientMainMainPage : Form
    {
        string userNamePass = "";
        public PatientMainMainPage(string x)
        {
            userNamePass = x;
            InitializeComponent();
        }



        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            DoctorListforPatient doctorListforPatient = new DoctorListforPatient(userNamePass);
            doctorListforPatient.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            PatientMainPage patientMainPage = new PatientMainPage(userNamePass);
            patientMainPage.Show();
        }

        private void logoutBTN_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            HealthServiceforPatientPage h1=new HealthServiceforPatientPage(userNamePass);
            h1.Show();
        }
    }
}
