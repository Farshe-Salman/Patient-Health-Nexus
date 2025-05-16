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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using System.Data.Sql;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Patient_Health_Nexus.Code
{
    public partial class PharmacySignup : Form
    {
        int showPanel = 0;
        private string TO = "";
        private string randomCode = "";
        public PharmacySignup()
        {
            InitializeComponent();
        }

        string ExecuitiveUserNamePass;
        public PharmacySignup(string x )
        {
            ExecuitiveUserNamePass = x;
            InitializeComponent();
        }

        public PharmacySignup(int x)
        {
            showPanel = x;
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }



        private void PharmacySignup_Load(object sender, EventArgs e)
        {
            if(showPanel==1)
            {
                panel1.Hide();
                panel2.Hide();
            }
            if(showPanel==0)
            {
                panel3.Hide();
                panel4.Hide();
            }
            
        }




        private void button1_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();

            con.ConnectionString = "data source=DESKTOP-HRU59TM\\SQLEXPRESS; database=patientHealthNexus; integrated security=SSPI";

            string userName = pharmacyUsername2.Text.Trim();
            string name = pharmacyName.Text.Trim();
            string registrationNumber = pharmacyRegNum.Text.Trim();
            string phone = pharmacyPhoneNumber.Text.Trim();
            string address = pharmacyAddress.Text.Trim();
            string email = Email_Id.Text.Trim();
            string password = pharmacyPassword2.Text.Trim();

            if (string.IsNullOrWhiteSpace(userName) ||
                string.IsNullOrWhiteSpace(name) ||
                string.IsNullOrWhiteSpace(registrationNumber) ||
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

            // Validate password length
            if (password.Length < 6)
            {
                MessageBox.Show("Password must be at least 6 characters long.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //string query = "INSERT INTO section (Id, Name, Age, Address) VALUES (@Id, @Name, @Age, @Address)";
            string sql1 = "INSERT INTO Pharmacy([User Name], Name, [Registration Number], Address,[Phone Number], Email, Password)VALUES("
  + "'" + userName + "'" + ","
  + "'" + name + "'" + ","
  + "'" + registrationNumber + "'" + ","
  + "'" + address + "'" + ","
  + "'" + phone + "'" + ","
  + "'" + email + "'" + ","
  + "'" + password + "'" +
  ")";
            string userType = "Pharmacy";
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

            MessageBox.Show("Your Account Created Successfully");

            //string details = name + "\n" + id + "\n" + time + "\n" + dept + "\n" + BG + "\n" + address;

            this.Hide();
            signUp.Hide();
            PharmacyDetailsForAdminNExecuitive pharmacyDetailsForAdminNExecuitive = new PharmacyDetailsForAdminNExecuitive(ExecuitiveUserNamePass);
            pharmacyDetailsForAdminNExecuitive.Show();
            pharmacyDetailsForAdminNExecuitive.Show();
        }

        private void signUp_Click_2(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();

            con.ConnectionString = "data source=DESKTOP-HRU59TM\\SQLEXPRESS; database=patientHealthNexus; integrated security=SSPI";

            string userName = pharmacyUsername.Text.Trim();
            string name = pharmacyName.Text.Trim();
            string registrationNumber = pharmacyRegNum.Text.Trim();
            string phone = pharmacyPhoneNumber.Text.Trim();
            string address = pharmacyAddress.Text.Trim();
            string email = Email_Id.Text.Trim();
            string otp = verificationCode.Text.Trim();
            string password = pharmacyPassword.Text.Trim();

            if (string.IsNullOrWhiteSpace(userName) ||
                string.IsNullOrWhiteSpace(name) ||
                string.IsNullOrWhiteSpace(registrationNumber) ||
                string.IsNullOrWhiteSpace(otp) ||
                string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("All fields must be filled out.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (otp != randomCode)
            {
                MessageBox.Show("Wrong Otp, Please Try with correct One", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (System.Text.RegularExpressions.Regex.IsMatch(userName, "[A-Z]"))
            {
                MessageBox.Show("Username must not contain any capital letters. Please use lowercase letters only.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

            // Validate password length
            if (password.Length < 6)
            {
                MessageBox.Show("Password must be at least 6 characters long.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //string query = "INSERT INTO section (Id, Name, Age, Address) VALUES (@Id, @Name, @Age, @Address)";
            string sql1 = "INSERT INTO Pharmacy([User Name], Name, [Registration Number], Address,[Phone Number], Email, Password)VALUES("
  + "'" + userName + "'" + ","
  + "'" + name + "'" + ","
  + "'" + registrationNumber + "'" + ","
  + "'" + address + "'" + ","
  + "'" + phone + "'" + ","
  + "'" + email + "'" + ","
  + "'" + password + "'" +
  ")";
            string userType = "Pharmacy";
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

            MessageBox.Show("Your Account Created Successfully");

            //string details = name + "\n" + id + "\n" + time + "\n" + dept + "\n" + BG + "\n" + address;

            this.Hide();
            signUp.Hide();
            Login login = new Login();
            login.Show();
        }



        private void request_BTN_Click_2(object sender, EventArgs e)
        {
            TO = Email_Id.Text;

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

                string email = Email_Id.Text.Substring(0, 3) + $"" + Email_Id.Text.Substring(((Email_Id.Text.IndexOf('@')) - 3), 2) + $"@gmail.com. ";
                string body =
                    $"Thank you for signing up with Patient Health Nexus! To complete your account creation, please verify your email address by entering the verification code below:" +
                    $"\n\nYour Email Verification Code: {randomCode}" +
                    $"\n\nIf you did not request to create an account, please disregard this email or contact our support team if you have any concerns." +
                    $"\n\nThank you for choosing Patient Health Nexus. We look forward to serving your healthcare needs.\r\n\r\nBest regards,\r\nThe Patient Health Nexus Team\r\n[Privacy Statement]";


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

        private void logIn_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
        }
    }
}
