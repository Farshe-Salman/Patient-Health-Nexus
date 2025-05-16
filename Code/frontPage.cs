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
    public partial class frontPage : Form
    {
        public frontPage()
        {
            InitializeComponent();
        }



        private void frontPage_Load(object sender, EventArgs e)
        {

        }



        private void signup_BTN_Click(object sender, EventArgs e)
        {
            
        }

        private void service_Btn_Click(object sender, EventArgs e)
        {

        }

        private void login_Btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void signup_BTN_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Signup signup = new Signup();
            signup.Show();
        }

        private void aboutus_Btn_Click(object sender, EventArgs e)
        {

        }
    }
}
