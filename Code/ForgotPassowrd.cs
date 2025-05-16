using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Patient_Health_Nexus.Code
{
    
    public partial class ForgotPassowrd : Form
    {
        string email;
        string randomCode1;
        string username1;
        public ForgotPassowrd()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonPanelFP1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            string connectionString = "data source=DESKTOP-HRU59TM\\SQLEXPRESS; database=PatientHealthNexus; integrated security=SSPI";


            string username = userNameTxt.Text;

            if (string.IsNullOrWhiteSpace(username) )
            {
                MessageBox.Show("Please enter User name", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // string connectionString = "data source=DESKTOP-HRU59TM\\SQLEXPRESS; database=KK; integrated security=SSPI";

            //string query = "SELECT COUNT(*) FROM section WHERE Id = @Id AND Name = @Name";
            string query = "SELECT COUNT(*) FROM UserLogin WHERE[User Name] = @username";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@username", username);



                    connection.Open();
                    int count = (int)command.ExecuteScalar();

                    if (count > 0)
                    {
                        username1 = username;


                         string query3 = $"SELECT Email FROM UserLogin WHERE [User Name] = @username";

                                using (SqlCommand command3 = new SqlCommand(query3, connection))
                                {
                                    command3.Parameters.AddWithValue("@username", username);

                                    SqlDataReader reader2 = command3.ExecuteReader();
                                    if (reader2.Read())
                                    {
                                        email = reader2["Email"].ToString();

                                        try
                                        {
                                            // Generate a random OTP
                                            Random rand = new Random();
                                            randomCode1 = rand.Next(100000, 999999).ToString();

                                            // Email configuration
                                            string from = "souravzaman10@gmail.com"; // Replace with email
                                            string password = "kplgrrdwfyzlrfct"; // Replace with email password
                                            string subject = "Your OTP Code";

                                            //string email1 = email.Substring(0, 3) + $"" + email.Substring(((email.IndexOf('@')) - 3), 2) + $"@gmail.com. ";
                                            string body =
                                                $"Thank you for signing up with Patient Health Nexus! To complete your account creation, please verify your email address by entering the verification code below:" +
                                                $"\n\nYour Email Verification Code: {randomCode1}" +
                                                $"\n\nIf you did not request to create an account, please disregard this email or contact our support team if you have any concerns." +
                                                $"\n\nThank you for choosing Patient Health Nexus. We look forward to serving your healthcare needs.\r\n\r\nBest regards,\r\nThe Patient Health Nexus Team\r\n[Privacy Statement]";


                                            // Creating the email message
                                            MailMessage message = new MailMessage();
                                            message.To.Add(email);
                                            message.From = new MailAddress(from);
                                            message.Body = body;
                                            message.Subject = subject;

                                            // Configuring the SMTP client
                                            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                                            smtp.EnableSsl = true;
                                            smtp.Port = 587;
                                            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                                            smtp.Credentials = new NetworkCredential(from, password);
                                            smtp.Send(message);
                                            MessageBox.Show("Reset OTP code has been sent to your email.", "OTP Sent", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            panelFM2.Show();
                                            panel1.Hide();
                                        }
                                        catch (Exception ex)
                                        {
                                            MessageBox.Show(ex.Message, "Error Sending OTP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }
                                    }
                                
                                    else
                                    {
                                        MessageBox.Show("Email not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                    reader2.Close();
                                } 
                    }
                }

            }          

        }

        private void ForgotPassowrd_Load(object sender, EventArgs e)
        {
            panelFM2.Hide();
        }

        private void labelForPassSub2_Click(object sender, EventArgs e)
        {
            labelForPassSub2.Text = $"We send a code {email}";
        }

        private void buttonPanelFP2_Click(object sender, EventArgs e)
        {
            //string enteredCode = textBoxCode1.Text.Trim() + textBoxCode2.Text.Trim() + textBoxCode3.Text.Trim() +
            //textBoxCode4.Text.Trim() + textBoxCode5.Text.Trim() + textBoxCode6.Text.Trim();

            string enteredCode = textBox1.Text;
            if (string.IsNullOrWhiteSpace(enteredCode))
            {
                MessageBox.Show("Please enter the verification code.", "Missing Code", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (enteredCode == randomCode1)
            {
                MessageBox.Show("Verification successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information); panelFM2.Visible = false;
                panelFM3.Show();
               
            }
            else
            {
                MessageBox.Show("Invalid verification code. Please try again.", "Verification Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string newPassword = textBoxPass.Text;
            string confirmPassword = textBoxRepass.Text;

            if (string.IsNullOrWhiteSpace(newPassword) || string.IsNullOrWhiteSpace(confirmPassword))
            {
                MessageBox.Show("Please enter and confirm your password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (newPassword != confirmPassword)
            {
                MessageBox.Show("Passwords do not match. Please try again.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string connectionString = "data source=DESKTOP-HRU59TM\\SQLEXPRESS; database=PatientHealthNexus; integrated security=SSPI";
            string updateQuery = "UPDATE UserLogin SET [Password] = @password WHERE [User Name] = @username";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(updateQuery, connection))
                {
                    command.Parameters.AddWithValue("@password", newPassword);
                    command.Parameters.AddWithValue("@username", username1);

                    try
                    {
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Password updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Hide();
                            Login login = new Login();
                            login.Show();   
                            // Optionally, redirect the user or close the form
                        }
                        else
                        {
                            MessageBox.Show("Failed to update the password. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void back_BTN_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login= new Login();
            login.Show();
        }

        private void userNameTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginBTN_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login=new Login();
            login.Show();
        }

        private void signUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            Signup signup=new Signup();
            signup.Show();
        }
    }
}
