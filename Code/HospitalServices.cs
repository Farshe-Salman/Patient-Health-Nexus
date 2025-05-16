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
    public partial class HospitalServices : Form
    {
        string connectionString = "data source=DESKTOP-HRU59TM\\SQLEXPRESS; database=PatientHealthNexus; integrated security=SSPI";
        string userNamePass;
        public HospitalServices(string x)
        {
            userNamePass = x;
            InitializeComponent();
            panel3.Hide();
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
            panel3.Controls.Add(childForm);
            panel3.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        #endregion Method



        private void addBTN_Click(object sender, EventArgs e)
        {
            string diagnosticServiceName = diagnosticeServiceNameTXT.Text;
            if (decimal.TryParse(regularPriceTXT.Text, out decimal regularPrice) &&
                decimal.TryParse(discountRateTXT.Text, out decimal discountRate))
            {
                decimal discountPrice = regularPrice - (regularPrice * (discountRate / 100));

                string query = @"
                    INSERT INTO [PatientHealthNexus].[dbo].[DiagnosticServices]
                    ([Name], [RegularPrice], [DiscountPrice], [HospitalName], [DiscountRate])
                    VALUES (@Name, @RegularPrice, @DiscountPrice, @HospitalName, @DiscountRate)";

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

                            con.Open();
                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Diagnostic service added successfully!");
                                diagnosticeServiceNameTXT.Text = string.Empty;
                                regularPriceTXT.Text = string.Empty;
                                discountRateTXT.Text = string.Empty;
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
        private void FillDataGridView()
        {
            string query = "SELECT [DSID], [Name],[RegularPrice],[DiscountPrice],[DiscountRate]\r\nFROM [PatientHealthNexus].[dbo].[DiagnosticServices]\r\nWHERE [HospitalName] = @userNamePass;";
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
        private void back_BTN_Click(object sender, EventArgs e)
        {
            this.Hide();
            HospitalMainPage hospitalMainPage=new HospitalMainPage(userNamePass);
            hospitalMainPage.Show();
        }

        private void HospitalServices_Activated(object sender, EventArgs e)
        {
            FillDataGridView();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string selectedDSID = dataGridView1.Rows[e.RowIndex].Cells["DSID"].Value.ToString();

                if (dataGridView1.Columns[e.ColumnIndex].HeaderText == "Delete")
                {
                    string deleteQuery = "DELETE FROM [PatientHealthNexus].[dbo].[DiagnosticServices] WHERE [DSID] = @DSID";
                    try
                    {
                        using (SqlConnection con = new SqlConnection(connectionString))
                        {
                            using (SqlCommand command = new SqlCommand(deleteQuery, con))
                            {
                                command.Parameters.AddWithValue("@DSID", selectedDSID);
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
                    string name = dataGridView1.Rows[e.RowIndex].Cells["ServiceName"].Value.ToString();
                    string regularPriceText = dataGridView1.Rows[e.RowIndex].Cells["RegularPrice"].Value.ToString();
                    string discountRateText = dataGridView1.Rows[e.RowIndex].Cells["DiscountRate"].Value.ToString();

                    if (decimal.TryParse(regularPriceText, out decimal regularPrice) &&
                        decimal.TryParse(discountRateText, out decimal discountRate))
                    {
                        decimal discountPrice = regularPrice - (regularPrice * (discountRate / 100));
                        string updateQuery = @"
                    UPDATE [PatientHealthNexus].[dbo].[DiagnosticServices]
                    SET [Name] = @Name, 
                        [RegularPrice] = @RegularPrice, 
                        [DiscountPrice] = @DiscountPrice, 
                        [DiscountRate] = @DiscountRate
                    WHERE [DSID] = @DSID";

                        try
                        {
                            using (SqlConnection con = new SqlConnection(connectionString))
                            {
                                using (SqlCommand command = new SqlCommand(updateQuery, con))
                                {
                                    command.Parameters.AddWithValue("@Name", name);
                                    command.Parameters.AddWithValue("@RegularPrice", regularPrice);
                                    command.Parameters.AddWithValue("@DiscountPrice", discountPrice);
                                    command.Parameters.AddWithValue("@DiscountRate", discountRate);
                                    command.Parameters.AddWithValue("@DSID", selectedDSID);

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



        private void surgeryPackagesBTN_Click(object sender, EventArgs e)
        {
            panel3.Show();  
            openChildForm(new HospitalSurgeryPackage("ibnesina"));
        }

        private void DiagonsticServiceBTN_Click(object sender, EventArgs e)
        {
            panel3.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel3.Show();
            openChildForm(new HospitalHealthCheckup("ibnesina"));
        }
    }
}
