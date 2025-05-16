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
    public partial class Intro : Form
    {
        public Intro()
        {
            InitializeComponent();
        }

        int startpoint = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            startpoint += 2;
            progressBar1.Value = startpoint;

            if (progressBar1.Value == 80)
            {
                progressBar1.Value = 0;
                timer1.Stop();

                this.Hide();
                Welcome welcome = new Welcome();    
                welcome.Show();

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void first_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void Intro_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
