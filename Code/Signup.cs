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
    public partial class Signup : Form
    {
        public Signup()
        {
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
            panel3.Controls.Add(childForm);
            panel3.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        #endregion Method

        private void patientBTN_Click(object sender, EventArgs e)
        {
            openChildForm(new PatientSignUp());
        }

        private void hospitalBTN_Click(object sender, EventArgs e)
        {
            openChildForm(new HospitalSignup());
        }

        private void back_BTN_Click(object sender, EventArgs e)
        {
            this.Hide();
            Welcome welcome = new Welcome();
            welcome.Show();
        }

        private void pharmacyBTN_Click(object sender, EventArgs e)
        {
            openChildForm(new PharmacySignup());
        }


        private void Signup_Load_1(object sender, EventArgs e)
        {
            openChildForm(new PatientSignUp());
        }
    }
}
