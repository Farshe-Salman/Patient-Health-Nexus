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
    public partial class medicineInPatientPage : Form
    {
        string usernamePass;
        string connectionString = "data source=DESKTOP-HRU59TM\\SQLEXPRESS; database=PatientHealthNexus; integrated security=SSPI";

        public medicineInPatientPage(string x)
        {
            usernamePass = x;
            InitializeComponent();
        }


        private void FillDataGridView(string searchText = "")
        {
            // Modify the query to search by both MedicineName and PharmacyName
            string query = "SELECT TOP 1000 [MedicineID], [MedicineName], [Strength], [DosageForm], [Price], [QuantityInStock], [PharmacyName]" +
                           "FROM [PatientHealthNexus].[dbo].[Medicine] " +
                           "WHERE [MedicineName] LIKE @searchText OR [PharmacyName] LIKE @searchText";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, con))
                {
                    // Add parameter for the search text
                    command.Parameters.AddWithValue("@searchText", "%" + searchText + "%");

                    dataGridView1.AutoGenerateColumns = false;
                    con.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);
                    dataGridView1.DataSource = dataTable;
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].HeaderText == "Details")
            {
                int medicineID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["MedicineID"].Value);
                string medicineName = dataGridView1.Rows[e.RowIndex].Cells["MedicineName"].Value.ToString();
                string strength = dataGridView1.Rows[e.RowIndex].Cells["Strength"].Value.ToString();
                string dosageForm = dataGridView1.Rows[e.RowIndex].Cells["DosageForm"].Value.ToString();
                string price = dataGridView1.Rows[e.RowIndex].Cells["Price"].Value.ToString();
                string quantityInStock = dataGridView1.Rows[e.RowIndex].Cells["QuantityInStock"].Value.ToString();
                string pharmacyName = dataGridView1.Rows[e.RowIndex].Cells["PharmacyName"].Value.ToString();

                // Show the medicine details (you can use a MessageBox or another form)
                string fullDetails = $"Medicine ID: {medicineID}\n" +
                                     $"Medicine Name: {medicineName}\n" +
                                     $"Strength: {strength}\n" +
                                     $"Dosage Form: {dosageForm}\n" +
                                     $"Price: {price}\n" +
                                     $"Quantity In Stock: {quantityInStock}\n" +
                                     $"Pharmacy Name: {pharmacyName}";

                MessageBox.Show(fullDetails, "Medicine Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (dataGridView1.Columns[e.ColumnIndex].HeaderText == "Add TO Cart")
            {
                int medicineID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["MedicineID"].Value);
                string medicineName = dataGridView1.Rows[e.RowIndex].Cells["MedicineName"].Value.ToString();
                string price = dataGridView1.Rows[e.RowIndex].Cells["Price"].Value.ToString();
                string pharmacyName = dataGridView1.Rows[e.RowIndex].Cells["PharmacyName"].Value.ToString();
                int quantityInStock = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["QuantityInStock"].Value);

                // Get the quantity entered by the user in the 'Quantity' column
                int quantity = 0;
                if (dataGridView1.Rows[e.RowIndex].Cells["Quantity"].Value != null &&
                    !string.IsNullOrEmpty(dataGridView1.Rows[e.RowIndex].Cells["Quantity"].Value.ToString()))
                {
                    quantity = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Quantity"].Value);
                }

                if (quantity > 0 && quantity <= quantityInStock)
                {
                    // Insert the data into the Cart table
                    string query = "INSERT INTO [PatientHealthNexus].[dbo].[Cart] " +
                                   "([MedicineName], [Price], [Quantity], [QuantityInStock], [PatientUserName], [PharmacyUserName], [MedicineId]) " +
                                   "VALUES (@MedicineName, @Price, @Quantity, @QuantityInStock, @PatientUserName, @PharmacyUserName, @MedicineID)";

                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        using (SqlCommand command = new SqlCommand(query, con))
                        {
                            command.Parameters.AddWithValue("@MedicineName", medicineName);
                            command.Parameters.AddWithValue("@Price", price);
                            command.Parameters.AddWithValue("@Quantity", quantity);
                            command.Parameters.AddWithValue("@QuantityInStock", quantityInStock);
                            command.Parameters.AddWithValue("@PatientUserName", usernamePass); // Patient username passed to the form
                            command.Parameters.AddWithValue("@PharmacyUserName", pharmacyName);
                            command.Parameters.AddWithValue("@MedicineID", medicineID);

                            con.Open();
                            command.ExecuteNonQuery();
                            MessageBox.Show("Medicine added to cart.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    FillDataGridView();
                }
                else
                {
                    MessageBox.Show("Invalid quantity. Please enter a valid quantity.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void medicineInPatientPage_Load(object sender, EventArgs e)
        {
            FillDataGridView();
        }

        private void SearchTXT_TextChanged(object sender, EventArgs e)
        {
            FillDataGridView(SearchTXT.Text.Trim());
        }
    }
}
