using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Patient_Health_Nexus.Code
{
    public partial class AddExicuitive : Form
    {
        string userNamePass;
        public AddExicuitive(string x)
        {
            userNamePass = x;
            InitializeComponent();
        }

        private void exicuitiveAdd_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();

            con.ConnectionString = "data source=DESKTOP-HRU59TM\\SQLEXPRESS; database=patientHealthNexus; integrated security=SSPI";
            
            string userName = userNameTXT.Text.Trim();
            string fname = firstNameTXT.Text.Trim();
            string lname = lastNameTXT.Text.Trim();
            string phone = phoneTXT.Text.Trim();
            string email = emailTXT.Text.Trim();
            string password =passwordTXT.Text.Trim();

            if (string.IsNullOrWhiteSpace(userName) ||
                string.IsNullOrWhiteSpace(fname) ||
                string.IsNullOrWhiteSpace(lname) ||
                string.IsNullOrWhiteSpace(phone) ||
                string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("All fields must be filled out.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if (System.Text.RegularExpressions.Regex.IsMatch(userName, "[A-Z]"))
            {
                MessageBox.Show("Username must not contain any capital letters. Please use lowercase letters only.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if (!System.Text.RegularExpressions.Regex.IsMatch(phone, @"^01\d{9}$"))
            {
                MessageBox.Show("Please provide a valid phone number with exactly 11 digits starting with '01'.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate password length
            if (password.Length < 6)
            {
                MessageBox.Show("Password must be at least 6 characters long.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string sql1 = "INSERT INTO Exicuitive(UserName, FirstName,LastName,Phone ,Email, Password)VALUES("
  + "'" + userName + "'" + ","
  + "'" + fname + "'" + ","
  + "'" + lname + "'" + ","
  + "'" + phone + "'" + ","
  + "'" + email + "'" + ","
  + "'" + password + "'" +
  ")";
            string userType = "Exicuitive";
            string sql2 = "INSERT INTO UserLogin([User Name], Password ,[User Type])VALUES("
  + "'" + userName + "'" + ","
  + "'" + password + "'" + ","
  + "'" + userType + "'" +
  ")";



            using (SqlCommand cmd = new SqlCommand(sql1, con))
            {
                //Opening the connection:
                con.Open();

                //cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();

                //Disconnect
                con.Close();
            }

            using (SqlCommand abc = new SqlCommand(sql2, con))
            {
                //Opening the connection:
                con.Open();

                //cmd.CommandType = CommandType.Text;
                abc.ExecuteNonQuery();

                //Disconnect
                con.Close();
            }

            MessageBox.Show("New Exicuitive Account Created Successfully");

            //string details = name + "\n" + id + "\n" + time + "\n" + dept + "\n" + BG + "\n" + address;

            this.Hide();
            AdminMainPage adminMainPage = new AdminMainPage(userNamePass);
            adminMainPage.Show();

        }

        private void back_BTN_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminMainPage adminMainPage = new AdminMainPage(userNamePass);
            adminMainPage.Show();
        }

        private void AddExicuitive_Load(object sender, EventArgs e)
        {
            string connectionString = "data source=DESKTOP-HRU59TM\\SQLEXPRESS; database=patientHealthNexus; integrated security=SSPI";
            string query = "SELECT TOP 1000 [UserName], [FirstName], [LastName], [Phone], [Email], [Password] FROM [PatientHealthNexus].[dbo].[Exicuitive]";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while loading data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
