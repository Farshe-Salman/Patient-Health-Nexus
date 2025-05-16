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

namespace Patient_Health_Nexus.Code
{
    public partial class PharmacyDetailsForAdminNExecuitive : Form
    {
        string userNamePass;
        string connectionString = "data source=DESKTOP-HRU59TM\\SQLEXPRESS; database=patientHealthNexus; integrated security=SSPI";
        public PharmacyDetailsForAdminNExecuitive(string x)
        {
            userNamePass = x;   
            InitializeComponent();
        }

        private void FillDataGridView()
        {
            string query = "SELECT [User Name], Name, [Phone Number], address FROM Pharmacy";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, con))
                {
                    con.Open(); // Open the connection
                    SqlDataReader reader = command.ExecuteReader(); // Execute the query
                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader); // Load the data into a DataTable
                    dataGridView1.DataSource = dataTable; // Set the DataGridView's data source
                }
            }
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
            panel2.Controls.Add(childForm);
            panel2.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        #endregion Method



        private void addPharmacyBTN_Click(object sender, EventArgs e)
        {
            openChildForm(new PharmacySignup(1));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
            {
                activeForm.Hide();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].HeaderText == "Delete")
            {
                string user = dataGridView1.Rows[e.RowIndex].Cells["userNameDGV"].Value.ToString();

                string query = "DELETE FROM Pharmacy WHERE [User Name]=@userName";
                string query1 = "DELETE FROM Pharmacy WHERE [User Name]=@userName";
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, con))
                    {
                        command.Parameters.AddWithValue("@userName", user);
                        con.Open(); // Open the connection
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Data deleted");
                        }
                        else
                        {
                            MessageBox.Show("Data Not deleted");
                        }
                    }
                }
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query1, con))
                    {
                        command.Parameters.AddWithValue("@userName", user);
                        con.Open(); // Open the connection
                        int rowsAffected = command.ExecuteNonQuery();
                        
                    }
                }
            }


            if (dataGridView1.Columns[e.ColumnIndex].HeaderText == "Details")
            {
                string user = dataGridView1.Rows[e.RowIndex].Cells["userNameDGV"].Value.ToString();

                string query = "SELECT [User Name], [Name], [Registration Number], [Address], [Phone Number], [Email], [Password] FROM Pharmacy WHERE [User Name] = @userName";
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, con))
                    {
                        command.Parameters.AddWithValue("@userName", user);
                        con.Open(); // Open the connection
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Retrieve the data from the reader
                                string userName = reader["User Name"].ToString();
                                string name = reader["Name"].ToString();
                                string regNumber = reader["Registration Number"].ToString();
                                string address = reader["Address"].ToString();
                                string phoneNumber = reader["Phone Number"].ToString();
                                string email = reader["Email"].ToString();
                                string password = reader["Password"].ToString();

                                // Display the details in a message box
                                MessageBox.Show($"User Name: {userName}\nName: {name}\nRegistration Number: {regNumber}\nAddress: {address}\nPhone Number: {phoneNumber}\nEmail: {email}\nPassword: {password}", "Pharmacy Details");
                            }
                            else
                            {
                                MessageBox.Show("No details found for the selected pharmacy.");
                            }
                        }
                    }
                }
            }

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PharmacyDetailsForAdminNExecuitive_Activated(object sender, EventArgs e)
        {
            FillDataGridView();
        }

        private void back_BTN_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminMainPage adminMainPage = new AdminMainPage(userNamePass);
            adminMainPage.Show();
        }
    }
}
