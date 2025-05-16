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
    public partial class HospitalMainPage : Form
    {
        string userNamePass;
        public HospitalMainPage(string x)
        {
            userNamePass = x;   
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            HospitalServices hospitalServices = new HospitalServices(userNamePass);
            hospitalServices.Show();
        }

        private void logoutBTN_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            HospitalDoctorDetails hospitalDoctorDetails=new HospitalDoctorDetails(userNamePass);
            hospitalDoctorDetails.Show();
        }
    }
}
