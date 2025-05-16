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

namespace Patient_Health_Nexus
{
    public partial class HospitalSurgeryPackage : Form
    {
        string connectionString = "data source=DESKTOP-HRU59TM\\SQLEXPRESS; database=PatientHealthNexus; integrated security=SSPI";
        string userNamePass;
        public HospitalSurgeryPackage(string x)
        {
            userNamePass = x;
            InitializeComponent();
            FillDataGridView();
        }
        private void FillDataGridView()
        {
            string query = "SELECT SID, SurgeryName, PriceInWard, PriceInStandard, PriceInDeluxe, PriceInSuite, DurationOfStay\r\nFROM [PatientHealthNexus].[dbo].[SurgeryPackages]\r\nWHERE [HospitalName] = @userNamePass;";
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

        private void HospitalSurgeryPackage_Activated(object sender, EventArgs e)
        {
            FillDataGridView();
        }

        private void addBTN_Click(object sender, EventArgs e)
        {
            
                string surgeryName = surgeryNameTXT.Text;
                string durationOfStay = StayTXT.Text;

                if (decimal.TryParse(wordPriceTXT.Text, out decimal priceInWard) &&
                    decimal.TryParse(sharedPriceTXT.Text, out decimal priceInStandard) &&
                    decimal.TryParse(deluxePriceTXT.Text, out decimal priceInDeluxe) &&
                    decimal.TryParse(suitePriceTXT.Text, out decimal priceInSuite))
                {
                    string query = @"
            INSERT INTO [PatientHealthNexus].[dbo].[SurgeryPackages]
            ([SurgeryName], [PriceInWard], [PriceInStandard], [PriceInDeluxe], [PriceInSuite], [DurationOfStay], [HospitalName])
            VALUES (@SurgeryName, @PriceInWard, @PriceInStandard, @PriceInDeluxe, @PriceInSuite, @DurationOfStay, @HospitalName)";

                    try
                    {
                        using (SqlConnection con = new SqlConnection(connectionString))
                        {
                            using (SqlCommand command = new SqlCommand(query, con))
                            {
                                command.Parameters.AddWithValue("@SurgeryName", surgeryName);
                                command.Parameters.AddWithValue("@PriceInWard", priceInWard);
                                command.Parameters.AddWithValue("@PriceInStandard", priceInStandard);
                                command.Parameters.AddWithValue("@PriceInDeluxe", priceInDeluxe);
                                command.Parameters.AddWithValue("@PriceInSuite", priceInSuite);
                                command.Parameters.AddWithValue("@DurationOfStay", durationOfStay);
                                command.Parameters.AddWithValue("@HospitalName", userNamePass);

                                con.Open();
                                int rowsAffected = command.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Surgery package added successfully!");

                                    // Clear the text fields
                                    surgeryNameTXT.Text = string.Empty;
                                    wordPriceTXT.Text = string.Empty;
                                    sharedPriceTXT.Text = string.Empty;
                                    deluxePriceTXT.Text = string.Empty;
                                    suitePriceTXT.Text = string.Empty;
                                    StayTXT.Text = string.Empty;

                                    // Refresh the DataGridView to show updated data
                                    FillDataGridView();
                                }
                                else
                                {
                                    MessageBox.Show("Failed to add surgery package.");
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
                    MessageBox.Show("Please enter valid numeric values for prices.");
                }


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string selectedSID = dataGridView1.Rows[e.RowIndex].Cells["SID"].Value.ToString();

                if (dataGridView1.Columns[e.ColumnIndex].HeaderText == "Delete")
                {
                    string deleteQuery = "DELETE FROM [PatientHealthNexus].[dbo].[SurgeryPackages] WHERE [SID] = @SID";
                    try
                    {
                        using (SqlConnection con = new SqlConnection(connectionString))
                        {
                            using (SqlCommand command = new SqlCommand(deleteQuery, con))
                            {
                                command.Parameters.AddWithValue("@SID", selectedSID);
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
                
            }
            if (dataGridView1.Columns[e.ColumnIndex].HeaderText == "update")
            {
                int rowIndex = e.RowIndex;
                if (rowIndex >= 0)
                {
                    // Get updated values from the row
                    string surgeryId = dataGridView1.Rows[rowIndex].Cells["SID"].Value.ToString();
                    string surgeryName = dataGridView1.Rows[rowIndex].Cells["SurgeryName"].Value.ToString();
                    string durationOfStay = dataGridView1.Rows[rowIndex].Cells["DurationOfStay"].Value.ToString();

                    if (decimal.TryParse(dataGridView1.Rows[rowIndex].Cells["PriceInWard"].Value.ToString(), out decimal priceInWard) &&
                        decimal.TryParse(dataGridView1.Rows[rowIndex].Cells["PriceInStandard"].Value.ToString(), out decimal priceInStandard) &&
                        decimal.TryParse(dataGridView1.Rows[rowIndex].Cells["PriceInDeluxe"].Value.ToString(), out decimal priceInDeluxe) &&
                        decimal.TryParse(dataGridView1.Rows[rowIndex].Cells["PriceInSuite"].Value.ToString(), out decimal priceInSuite))
                    {
                        string query = @"
                    UPDATE [PatientHealthNexus].[dbo].[SurgeryPackages]
                    SET SurgeryName = @SurgeryName, 
                        PriceInWard = @PriceInWard,
                        PriceInStandard = @PriceInStandard,
                        PriceInDeluxe = @PriceInDeluxe,
                        PriceInSuite = @PriceInSuite,
                        DurationOfStay = @DurationOfStay
                    WHERE SID = @SID";

                        try
                        {
                            using (SqlConnection con = new SqlConnection(connectionString))
                            {
                                using (SqlCommand command = new SqlCommand(query, con))
                                {
                                    command.Parameters.AddWithValue("@SurgeryName", surgeryName);
                                    command.Parameters.AddWithValue("@PriceInWard", priceInWard);
                                    command.Parameters.AddWithValue("@PriceInStandard", priceInStandard);
                                    command.Parameters.AddWithValue("@PriceInDeluxe", priceInDeluxe);
                                    command.Parameters.AddWithValue("@PriceInSuite", priceInSuite);
                                    command.Parameters.AddWithValue("@DurationOfStay", durationOfStay);
                                    command.Parameters.AddWithValue("@SID", surgeryId);

                                    con.Open();
                                    int rowsAffected = command.ExecuteNonQuery();

                                    if (rowsAffected > 0)
                                    {
                                        MessageBox.Show("Surgery package updated successfully!");

                                        // Refresh the DataGridView to show updated data
                                        FillDataGridView();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Failed to update surgery package.");
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
                        MessageBox.Show("Please enter valid numeric values for prices.");
                    }
                }
            }
        }
    }
}
