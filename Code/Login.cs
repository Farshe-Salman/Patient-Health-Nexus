using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Patient_Health_Nexus.Code
{
    public partial class Login : Form
    {
        String userType;
        int allok = 0;
        private string usernamePlaceholder = "Enter your username";
        private string passwordPlaceholder = "Enter your password";

        public Login()
        {
            InitializeComponent();
            userNameText.Text = usernamePlaceholder;
            userNameText.ForeColor = Color.Gray;
            passwordText.Text = passwordPlaceholder;
            passwordText.ForeColor = Color.Gray;

            // Attach event handlers for Enter and Leave
            userNameText.Enter += UserNameText_Enter;
            userNameText.Leave += UserNameText_Leave;
            passwordText.Enter += PasswordText_Enter;
            passwordText.Leave += PasswordText_Leave;


        }


        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void first_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
            
        }

        private void UserNameText_Enter(object sender, EventArgs e)
        {
            if (userNameText.Text == usernamePlaceholder)
            {
                userNameText.Text = "";
                userNameText.ForeColor = Color.Black;
            }
        }

        private void UserNameText_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(userNameText.Text))
            {
                userNameText.Text = usernamePlaceholder;
                userNameText.ForeColor = Color.Gray;
            }
        }
        private void PasswordText_Enter(object sender, EventArgs e)
        {
            if (passwordText.Text == passwordPlaceholder)
            {
                passwordText.Text = "";
                passwordText.ForeColor = Color.Black;
            }
        }

        private void PasswordText_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(passwordText.Text))
            {
                passwordText.Text = passwordPlaceholder;
                passwordText.ForeColor = Color.Gray;
            }
        }
        private void signupBTN_Click(object sender, EventArgs e)
        {
            this.Hide();
            Signup signup = new Signup();
            signup.Show();
        }

        private void back_BTN_Click(object sender, EventArgs e)
        {
            this.Hide();
            Welcome welcome= new Welcome();
            welcome.Show();
        }

        private void signupBTN_Click_1(object sender, EventArgs e)
        {
            this.Hide();
           Signup signup = new Signup();    
            signup.Show();
        }

        private void userNameText_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordText_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginBTN_Click_1(object sender, EventArgs e)
        {
            

            SqlConnection con = new SqlConnection();
            string connectionString = "data source=DESKTOP-HRU59TM\\SQLEXPRESS; database=PatientHealthNexus; integrated security=SSPI";


            string username = userNameText.Text == usernamePlaceholder ? "" : userNameText.Text;
            string userpassword = passwordText.Text == passwordPlaceholder ? "" : passwordText.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(userpassword))
            {
                MessageBox.Show("Please enter both Id and Name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // string connectionString = "data source=DESKTOP-HRU59TM\\SQLEXPRESS; database=KK; integrated security=SSPI";

            //string query = "SELECT COUNT(*) FROM section WHERE Id = @Id AND Name = @Name";
            string query = "SELECT COUNT(*) FROM UserLogin WHERE[User Name] = @username AND Password = @password";
            string query2 = " SELECT [User Type] FROM UserLogin WHERE [User Name] = @username";


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", userpassword);

                    connection.Open();
                    int count = (int)command.ExecuteScalar();

                    if (count > 0)
                    {
                        
                        allok = 1;

                    }
                    
                }
            }

            if (allok == 1)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query2, connection))
                    {
                        command.Parameters.AddWithValue("@username", username);
                        connection.Open();

                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            MessageBox.Show("Login unsuccessful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            userType =reader["User Type"].ToString();
                            if(userType =="admin")
                            {
                                this.Hide();
                                AdminMainPage adminMainPage = new AdminMainPage(username);
                                adminMainPage.Show();
                            }

                            else if (userType == "Exicuitive")
                            {
                                this.Hide();
                                AdminMainPage adminMainPage = new AdminMainPage(username);
                                adminMainPage.Show();
                            }

                            else if(userType =="Pharmacy")
                            {
                                this.Hide();
                                PharmacyMainPage pharmacyMainPage= new PharmacyMainPage(username);
                                pharmacyMainPage.Show();
                            }
                            else if( userType =="Hospital")
                            {
                                this.Hide();
                                HospitalMainPage hospitalMainPage = new HospitalMainPage(username);
                                hospitalMainPage.Show();
                            }
                            else
                            {
                                this.Hide();
                                PatientMainMainPage patientMainMainPage = new PatientMainMainPage(username);
                                patientMainMainPage.Show();
                            }
                            
                        }
                        else
                        {
                            MessageBox.Show("No details found for the given ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            Close(); // Close the form if no data is found
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Invalid Id or Name.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ForgotPassowrd forgotPassowrd = new ForgotPassowrd();
            forgotPassowrd.Show();  
        }

        private void showPassCHECK_CheckedChanged(object sender, EventArgs e)
        {
           
        }
    }
}
