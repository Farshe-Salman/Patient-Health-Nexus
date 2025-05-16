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
    public partial class PharmacyMainPage : Form
    {
        string connectionString = "data source=DESKTOP-HRU59TM\\SQLEXPRESS; database=PatientHealthNexus; integrated security=SSPI";
        string userNamePass;
        private Form activeForm = null;
        public PharmacyMainPage(string x)
        {
            userNamePass = x;
            InitializeComponent();
            loadCustomer();
            panel2.Hide();
        }

        private void PharmacyMainPage_Load(object sender, EventArgs e)
        {

        }

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



        private void FillDataGridView()
        {
            string query = "SELECT [MedicineID],[MedicineName], [Strength], [DosageForm], [Price], [QuantityInStock]\r\nFROM [PatientHealthNexus].[dbo].[Medicine]\r\nWHERE [PharmacyName] = @userNamePass;";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, con))
                {
                    command.Parameters.AddWithValue("@userNamePass", userNamePass);
                    con.Open(); // Open the connection
                    SqlDataReader reader = command.ExecuteReader(); // Execute the query
                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader); // Load the data into a DataTable
                    dataGridViewForMedicine.DataSource = dataTable; // Set the DataGridView's data source
                }
            }
        }

        private void dataGridViewForMedicine_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dataGridViewForMedicine.Columns[e.ColumnIndex].HeaderText == "Delete")
            {

                int medicineId = Convert.ToInt32(dataGridViewForMedicine.Rows[e.RowIndex].Cells["MedicineID"].Value);

                string query = "DELETE FROM Medicine WHERE MedicineID = @MedicineID";

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, con))
                    {
                        command.Parameters.AddWithValue("@MedicineID", medicineId);
                        con.Open();
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Medicine deleted successfully.");
                        }
                        else
                        {
                            MessageBox.Show("No record found or could not delete.");
                        }
                    }
                }
            }
            if (dataGridViewForMedicine.Columns[e.ColumnIndex].HeaderText == "Update")
            {
                int medicineId = Convert.ToInt32(dataGridViewForMedicine.Rows[e.RowIndex].Cells["MedicineID"].Value);
                string newMedicineName = Convert.ToString(dataGridViewForMedicine.Rows[e.RowIndex].Cells["MedicineName"].Value);
                string newStrength = Convert.ToString(dataGridViewForMedicine.Rows[e.RowIndex].Cells["Strength"].Value);
                string newDosageForm = Convert.ToString(dataGridViewForMedicine.Rows[e.RowIndex].Cells["DosageForm"].Value);
                decimal newPrice = Convert.ToDecimal(dataGridViewForMedicine.Rows[e.RowIndex].Cells["Price"].Value);
                int newQuantityInStock = Convert.ToInt32(dataGridViewForMedicine.Rows[e.RowIndex].Cells["QuantityInStock"].Value);

                string query = "UPDATE Medicine SET MedicineName = @MedicineName, Strength = @Strength, DosageForm = @DosageForm, Price = @Price, QuantityInStock = @QuantityInStock WHERE MedicineID = @MedicineID";

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, con))
                    {
                        command.Parameters.AddWithValue("@MedicineID", medicineId);
                        command.Parameters.AddWithValue("@MedicineName", newMedicineName);
                        command.Parameters.AddWithValue("@Strength", newStrength);
                        command.Parameters.AddWithValue("@DosageForm", newDosageForm);
                        command.Parameters.AddWithValue("@Price", newPrice);
                        command.Parameters.AddWithValue("@QuantityInStock", newQuantityInStock);

                        con.Open();
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Medicine updated successfully.");
                        }
                        else
                        {
                            MessageBox.Show("No record found or could not update.");
                        }
                    }
                }
            }
        }

        private void PharmacyMainPage_Activated(object sender, EventArgs e)
        {
            FillDataGridView();

        }


        public void loadCustomer()
        {
            string searchValue = SearchTXT.Text.Trim(); // Get the text from searchTextbox

            // Construct the query with parameters to filter by MedicineName
            string query = "SELECT * FROM Medicine WHERE [MedicineName] LIKE @Search";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, con))
                {
                    // Use '%' for partial matching in SQL LIKE clause
                    command.Parameters.AddWithValue("@Search", "%" + searchValue + "%");

                    con.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);
                    dataGridViewForMedicine.DataSource = dataTable; // Update DataGridView with filtered data
                }
            }
        }
        private void SearchTXT_TextChanged(object sender, EventArgs e)
        {
            loadCustomer();
        }

        private void addMedicineBTN_Click_1(object sender, EventArgs e)
        {
            string medicineName = medicineNameTXT.Text;
            string strength = strengthTXT.Text;
            string dosageForm = dosageFormTXT.Text;
            decimal price = Convert.ToDecimal(priceTXT.Text);
            int quantityInStock = Convert.ToInt32(quantityInStockTXT.Text);


            // SQL insert query
            string query = "INSERT INTO [PatientHealthNexus].[dbo].[Medicine] (MedicineName, Strength, DosageForm, Price, QuantityInStock, PharmacyName) " +
                           "VALUES (@MedicineName, @Strength, @DosageForm, @Price, @QuantityInStock, @PharmacyName)";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    // Create and configure the SQL command
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        // Add parameters to prevent SQL injection
                        cmd.Parameters.AddWithValue("@MedicineName", medicineName);
                        cmd.Parameters.AddWithValue("@Strength", strength);
                        cmd.Parameters.AddWithValue("@DosageForm", dosageForm);
                        cmd.Parameters.AddWithValue("@Price", price);
                        cmd.Parameters.AddWithValue("@QuantityInStock", quantityInStock);
                        cmd.Parameters.AddWithValue("@PharmacyName", userNamePass);

                        // Open the connection
                        con.Open();

                        // Execute the query
                        int rowsAffected = cmd.ExecuteNonQuery();

                        // Check if the insertion was successful
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Medicine added successfully.");
                            medicineNameTXT.Clear();
                            strengthTXT.Clear();
                            dosageFormTXT.Clear();
                            priceTXT.Clear();
                            quantityInStockTXT.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Error adding medicine.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Display error message if the operation fails
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }


        private void logoutBTN_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void orderHistoryBTN_Click(object sender, EventArgs e)
        {
            panel2.Show();  
            openChildForm(new OrderHistoryForPharmacy(userNamePass));
        }

        private void medicineBTN_Click(object sender, EventArgs e)
        {
            panel2.Hide();
        }
    }
}
