using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Patient_Health_Nexus.Code
{
    public partial class OrderHistoryForPharmacy : Form
    {
        string connectionString = "data source=DESKTOP-HRU59TM\\SQLEXPRESS; database=PatientHealthNexus; integrated security=SSPI";
        string userNamePass;

        public OrderHistoryForPharmacy(string x)
        {
            userNamePass = x;
            InitializeComponent();
        }

        private void OrderHistoryForPharmacy_Load(object sender, EventArgs e)
        {
           //ConfigureDataGridView();
            FillDataGridView();
        }

       

        private void FillDataGridView(string searchText = "")
        {
            string query = @"
                SELECT 
                    [OrderID],
                    [MedicineName],
                    [Quantity],
                    [TotalPrice],
                    [DeleveryFromPharmacy]
                FROM [PatientHealthNexus].[dbo].[OrderHistory]
                WHERE [PharmacyUserName] = @UserName 
                AND (@SearchText = '' OR [MedicineName] LIKE @SearchText)";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, con))
                {
                    command.Parameters.AddWithValue("@UserName", userNamePass);
                    command.Parameters.AddWithValue("@SearchText", "%" + searchText + "%");

                    con.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        DataTable dataTable = new DataTable();
                        dataTable.Load(reader);
                        dataGridView1.DataSource = dataTable;
                    }
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dataGridView1.Columns[e.ColumnIndex].Name == "DeliveryDone")
            {
                int orderId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["OrderID"].Value);
                UpdateDeliveryStatus(orderId);
                FillDataGridView();
            }
        }

        private void UpdateDeliveryStatus(int orderId)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string updateQuery = @"
                        UPDATE [PatientHealthNexus].[dbo].[OrderHistory]
                        SET [DeleveryFromPharmacy] = 'Delivered'
                        WHERE [OrderID] = @OrderID AND [PharmacyUserName] = @UserName";

                    using (SqlCommand command = new SqlCommand(updateQuery, connection))
                    {
                        command.Parameters.AddWithValue("@OrderID", orderId);
                        command.Parameters.AddWithValue("@UserName", userNamePass);

                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Delivery status updated successfully.");
                        }
                        else
                        {
                            MessageBox.Show("Failed to update delivery status.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating delivery status: {ex.Message}");
            }
        }

        private void SearchTXT_TextChanged_1(object sender, EventArgs e)
        {
            FillDataGridView(SearchTXT.Text.Trim());
        }
    }
}
