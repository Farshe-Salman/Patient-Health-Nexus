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
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }

        private void Welcome_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }




        private void Welcome_Load(object sender, EventArgs e)
        {

        }

        private void login_Btn_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            new Login().Show();
            this.Hide();
        }

        private void signup_BTN_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Signup signup = new Signup();
            signup.Show();
        }

        private void aboutus_Btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Aboutuss aboutuss = new Aboutuss();
            aboutuss.Show();
        }
    }
}
