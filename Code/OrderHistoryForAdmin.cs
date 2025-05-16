using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Patient_Health_Nexus.Code
{
    public partial class OrderHistoryForAdmin : Form
    {
        string connectionString = "data source=DESKTOP-HRU59TM\\SQLEXPRESS; database=PatientHealthNexus; integrated security=SSPI";
        string userNamePass;
        public OrderHistoryForAdmin(string x)
        {
            userNamePass = x;
            InitializeComponent();
        }

        



        private void FillDataGridView()
        {
            string query = @"
                SELECT 
                    [OrderID],
                    [MedicineName],
                    [Quantity],
                    [TotalPrice],
                    [DeleveryFromPharmacy],
                    [ReceivedByWearhouse],
                    [DeleveryFromWearHouse]
                FROM [PatientHealthNexus].[dbo].[OrderHistory]";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, con))
                {
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
            if (e.RowIndex >= 0)
            {
                int orderId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["OrderID"].Value);

                if (dataGridView1.Columns[e.ColumnIndex].Name == "Details")
                {
                    ShowDetails(orderId);
                }
                else if (dataGridView1.Columns[e.ColumnIndex].Name == "ReceivedFromPharmacy")
                {
                    UpdateField(orderId, "ReceivedByWearhouse", "Received");
                }
                else if (dataGridView1.Columns[e.ColumnIndex].Name == "DeliveryDone")
                {
                    UpdateField(orderId, "DeleveryFromWearHouse", "Delivered");
                }
                else if (dataGridView1.Columns[e.ColumnIndex].Name == "Delete")
                {
                    DeleteOrder(orderId);
                }

                FillDataGridView();
            }
        }

        private void ShowDetails(int orderId)
        {
            string query = @"
                SELECT * 
                FROM [PatientHealthNexus].[dbo].[OrderHistory]
                WHERE [OrderID] = @OrderID";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, con))
                {
                    command.Parameters.AddWithValue("@OrderID", orderId);
                    con.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string details = "";
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                details += $"{reader.GetName(i)}: {reader[i]}\n";
                            }
                            MessageBox.Show(details, "Order Details");
                        }
                    }
                }
            }
        }

        private void UpdateField(int orderId, string fieldName, string newValue)
        {
            string query = $@"
                UPDATE [PatientHealthNexus].[dbo].[OrderHistory]
                SET [{fieldName}] = @NewValue
                WHERE [OrderID] = @OrderID";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, con))
                {
                    command.Parameters.AddWithValue("@NewValue", newValue);
                    command.Parameters.AddWithValue("@OrderID", orderId);
                    con.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show($"{fieldName} updated to {newValue} successfully.");
                    }
                    else
                    {
                        MessageBox.Show($"Failed to update {fieldName}.");
                    }
                }
            }
        }

        private void DeleteOrder(int orderId)
        {
            string query = @"
                DELETE FROM [PatientHealthNexus].[dbo].[OrderHistory]
                WHERE [OrderID] = @OrderID";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, con))
                {
                    command.Parameters.AddWithValue("@OrderID", orderId);
                    con.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Order deleted successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete order.");
                    }
                }
            }
        }

        private void OrderHistoryForAdmin_Load_1(object sender, EventArgs e)
        {
            FillDataGridView();
        }

        private void back_BTN_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminMainPage adminMainPage=new AdminMainPage(userNamePass);
            adminMainPage.Show();
        }
    }
}
