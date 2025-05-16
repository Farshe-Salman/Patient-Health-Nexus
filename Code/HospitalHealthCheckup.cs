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
    public partial class HospitalHealthCheckup : Form
    {
        string connectionString = "data source=DESKTOP-HRU59TM\\SQLEXPRESS; database=PatientHealthNexus; integrated security=SSPI";
        string userNamePass;
        public HospitalHealthCheckup(string x)
        {
            userNamePass = x;
            InitializeComponent();
            FillDataGridView();
        }

        private void FillDataGridView()
        {
            string query = "SELECT [HCID], [CheckupName],[RegularPrice],[DiscountPrice],[DiscountRate],[ProvideService]\r\nFROM [PatientHealthNexus].[dbo].[HealthCheckup]\r\nWHERE [HospitalName] = @userNamePass;";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, con))
                {
                    command.Parameters.AddWithValue("@userNamePass", userNamePass);
                    dataGridView1.AutoGenerateColumns = false;
                    con.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);
                    dataGridView1.DataSource = dataTable;
                }
            }
        }

        private void addBTN_Click(object sender, EventArgs e)
        {
            string diagnosticServiceName = healthCheckupNameTXT.Text;
            string service = provideServiceTXT.Text;
            if (decimal.TryParse(regularPriceTXT.Text, out decimal regularPrice) &&
                decimal.TryParse(discountRateTXT.Text, out decimal discountRate))
            {
                decimal discountPrice = regularPrice - (regularPrice * (discountRate / 100));

                string query = @"
                    INSERT INTO [PatientHealthNexus].[dbo].[HealthCheckup]
                    ([CheckupName], [RegularPrice], [DiscountPrice], [HospitalName], [DiscountRate], [ProvideService])
                    VALUES (@Name, @RegularPrice, @DiscountPrice, @HospitalName, @DiscountRate, @ProvideService)";

                try
                {
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        using (SqlCommand command = new SqlCommand(query, con))
                        {
                            command.Parameters.AddWithValue("@Name", diagnosticServiceName);
                            command.Parameters.AddWithValue("@RegularPrice", regularPrice);
                            command.Parameters.AddWithValue("@DiscountPrice", discountPrice);
                            command.Parameters.AddWithValue("@HospitalName", userNamePass);
                            command.Parameters.AddWithValue("@DiscountRate", discountRate);
                            command.Parameters.AddWithValue("@ProvideService", service);

                            con.Open();
                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Diagnostic service added successfully!");
                                healthCheckupNameTXT.Text = string.Empty;
                                regularPriceTXT.Text = string.Empty;
                                discountRateTXT.Text = string.Empty;
                                provideServiceTXT.Text=string.Empty;
                                FillDataGridView();
                            }
                            else
                            {
                                MessageBox.Show("Failed to add diagnostic service.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Please enter valid numeric values for Regular Price and Discount Rate.");
            }
        }

        private void HospitalHealthCheckup_Activated(object sender, EventArgs e)
        {
            FillDataGridView();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string selectedHCID = dataGridView1.Rows[e.RowIndex].Cells["HCID"].Value.ToString();

                if (dataGridView1.Columns[e.ColumnIndex].HeaderText == "Delete")
                {
                    string deleteQuery = "DELETE FROM [PatientHealthNexus].[dbo].[HealthCheckup] WHERE [HCID] = @HCID";
                    try
                    {
                        using (SqlConnection con = new SqlConnection(connectionString))
                        {
                            using (SqlCommand command = new SqlCommand(deleteQuery, con))
                            {
                                command.Parameters.AddWithValue("@HCID", selectedHCID);
                                con.Open();
                                int rowsAffected = command.ExecuteNonQuery();
                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Row deleted successfully!");
                                    FillDataGridView();
                                }
                                else
                                {
                                    MessageBox.Show("Failed to delete the row.");
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error: {ex.Message}");
                    }
                }
                else if (dataGridView1.Columns[e.ColumnIndex].HeaderText == "Update")
                {
                    string checkupName = dataGridView1.Rows[e.RowIndex].Cells["CheckupName"].Value.ToString();
                    string regularPriceText = dataGridView1.Rows[e.RowIndex].Cells["RegularPrice"].Value.ToString();
                    string discountRateText = dataGridView1.Rows[e.RowIndex].Cells["DiscountRate"].Value.ToString();
                    string provideService = dataGridView1.Rows[e.RowIndex].Cells["ProvideService"].Value.ToString();

                    if (decimal.TryParse(regularPriceText, out decimal regularPrice) &&
                        decimal.TryParse(discountRateText, out decimal discountRate))
                    {
                        decimal discountPrice = regularPrice - (regularPrice * (discountRate / 100));
                        string updateQuery = @"
                    UPDATE [PatientHealthNexus].[dbo].[HealthCheckup]
                    SET [CheckupName] = @Name, 
                        [RegularPrice] = @RegularPrice, 
                        [DiscountPrice] = @DiscountPrice, 
                        [DiscountRate] = @DiscountRate,
                        [ProvideService] = @ProvideService
                    WHERE [HCID] = @HCID";

                        try
                        {
                            using (SqlConnection con = new SqlConnection(connectionString))
                            {
                                using (SqlCommand command = new SqlCommand(updateQuery, con))
                                {
                                    command.Parameters.AddWithValue("@Name", checkupName);
                                    command.Parameters.AddWithValue("@RegularPrice", regularPrice);
                                    command.Parameters.AddWithValue("@DiscountPrice", discountPrice);
                                    command.Parameters.AddWithValue("@DiscountRate", discountRate);
                                    command.Parameters.AddWithValue("@ProvideService", provideService);
                                    command.Parameters.AddWithValue("@HCID", selectedHCID);

                                    con.Open();
                                    int rowsAffected = command.ExecuteNonQuery();
                                    if (rowsAffected > 0)
                                    {
                                        MessageBox.Show("Row updated successfully!");
                                        FillDataGridView();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Failed to update the row.");
                                    }
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error: {ex.Message}");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid numeric values for Regular Price or Discount Rate.");
                    }
                }
            }
        }
    }
}
