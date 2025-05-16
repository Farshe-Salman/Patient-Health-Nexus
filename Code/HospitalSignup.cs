using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Net.WebRequestMethods;

namespace Patient_Health_Nexus.Code
{
    public partial class HospitalSignup : Form
    {
        private string TO = "";
        private string randomCode = "";
        public HospitalSignup()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void HospitalSignup_Load(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void request_BTN_Click(object sender, EventArgs e)
        {
            TO = Email_IdTXT.Text;

            if (string.IsNullOrWhiteSpace(TO))
            {
                MessageBox.Show("Please enter your Email address.", "Missing Email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Generate a random OTP
                Random rand = new Random();
                randomCode = rand.Next(100000, 999999).ToString();

                // Email configuration
                string from = "souravzaman10@gmail.com"; // Replace with email
                string password = "kplgrrdwfyzlrfct"; // Replace with email password
                string subject = "Your OTP Code";

                string email = Email_IdTXT.Text.Substring(0, 3) + $"" + Email_IdTXT.Text.Substring(((Email_IdTXT.Text.IndexOf('@')) - 3), 2) + $"@gmail.com. ";
                string body =
                    $"Please use this code to verify the email address " + email + " for creating account in 'Patient Helath Nexus' " +
                    $"\n\nYour Email Verification Code is {randomCode}" +
                    $"\n\nThanks, \nThe Patient Health Nexus Team \nPrivacy Statement";


                // Creating the email message
                MailMessage message = new MailMessage();
                message.To.Add(TO);
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
                MessageBox.Show("OTP has been sent to your email.", "OTP Sent", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Sending OTP", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void signUp_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source=DESKTOP-HRU59TM\\SQLEXPRESS; database=PatientHealthNexus; integrated security=SSPI";

            string userName = hospitalUserNameTXT.Text.Trim();
            string hospitalName = hospitalNameTXT.Text.Trim();
            int registrationNumber;
            if (!int.TryParse(hospitalRegNoTXT.Text.Trim(), out registrationNumber))
            {
                MessageBox.Show("Please provide a valid registration number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string type = radioButton1.Checked ? "General" : (radioButton2.Checked ? "Private" : "");
            string phone = hospitalPhoneNumberTXT.Text.Trim();
            string address = hospitalAddressTXT.Text.Trim();
            string email = Email_IdTXT.Text.Trim();
            string otp = verificationCodeTXT.Text.Trim();
            string password = hospitalPasswordTXT.Text.Trim();

            if (string.IsNullOrWhiteSpace(userName) ||
                string.IsNullOrWhiteSpace(hospitalName) ||
                string.IsNullOrWhiteSpace(type) ||
                string.IsNullOrWhiteSpace(phone) ||
                string.IsNullOrWhiteSpace(address) ||
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

            if (otp != randomCode)
            {
                MessageBox.Show("Wrong Otp, Please Try with correct One", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string checkUserQuery = "SELECT COUNT(*) FROM UserLogin WHERE [User Name] = @UserName";
            con.Open();
            using (SqlCommand checkCmd = new SqlCommand(checkUserQuery, con))
            {
                checkCmd.Parameters.AddWithValue("@UserName", userName);
                int userCount = (int)checkCmd.ExecuteScalar();

                if (userCount > 0)
                {
                    MessageBox.Show("This username is not available. Please try another one.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    con.Close();
                    return;
                }
            }
            con.Close();

            if (!System.Text.RegularExpressions.Regex.IsMatch(phone, @"^01\d{9}$"))
            {
                MessageBox.Show("Please provide a valid phone number with exactly 11 digits starting with '01'.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (password.Length < 6)
            {
                MessageBox.Show("Password must be at least 6 characters long.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string sql1 = "INSERT INTO Hospital([UserName], [HospitalName], [RegNo], [Type], [Phone], [Address], [Email], [Password]) VALUES(@UserName, @HospitalName, @RegNo, @Type, @Phone, @Address, @Email, @Password)";
            string userType = "Hospital";
            string sql2 = "INSERT INTO UserLogin([User Name], Password, [User Type]) VALUES(@UserName, @Password, @UserType)";

            using (SqlCommand cmd = new SqlCommand(sql1, con))
            {
                cmd.Parameters.AddWithValue("@UserName", userName);
                cmd.Parameters.AddWithValue("@HospitalName", hospitalName);
                cmd.Parameters.AddWithValue("@RegNo", registrationNumber);
                cmd.Parameters.AddWithValue("@Type", type);
                cmd.Parameters.AddWithValue("@Phone", phone);
                cmd.Parameters.AddWithValue("@Address", address);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Password", password);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }

            using (SqlCommand abc = new SqlCommand(sql2, con))
            {
                abc.Parameters.AddWithValue("@UserName", userName);
                abc.Parameters.AddWithValue("@Password", password);
                abc.Parameters.AddWithValue("@UserType", userType);

                con.Open();
                abc.ExecuteNonQuery();
                con.Close();
            }

            MessageBox.Show("Your Account Created Successfully");

            this.Hide();
            signUp.Hide();
            Login login = new Login();
            login.Show();
        }
    }
}
