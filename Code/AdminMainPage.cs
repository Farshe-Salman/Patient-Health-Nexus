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
    public partial class AdminMainPage : Form
    {
        string userNamePass;
        public AdminMainPage(string x)
        {
            userNamePass = x;
            InitializeComponent();

            if (userNamePass == "admin")
            {
                addExecuitiveBTN.Show();
                execuitiveProfileBTN.Hide();    
            }
            else
            {
                execuitiveProfileBTN.Show();
                addExecuitiveBTN.Hide();            
            }
        }


        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddExicuitive addExicuitive = new AddExicuitive(userNamePass);
            addExicuitive.Show();
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
            PharmacyDetailsForAdminNExecuitive pharmacyDetailsForAdminNExecuitive=new PharmacyDetailsForAdminNExecuitive(userNamePass); 
            pharmacyDetailsForAdminNExecuitive.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            OrderHistoryForAdmin orderHistoryForAdmin = new OrderHistoryForAdmin(userNamePass);
            orderHistoryForAdmin.Show();
        }

        private void doctorDetailsBTN_Click(object sender, EventArgs e)
        {
            this.Hide();
            HospitalDoctorDetails hospitalDoctorDetails=new HospitalDoctorDetails(userNamePass);
            hospitalDoctorDetails.Show();
        }
    }
}
