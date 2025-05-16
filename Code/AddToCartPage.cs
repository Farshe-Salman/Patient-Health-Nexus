using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Patient_Health_Nexus.Code
{
    public partial class AddToCartPage : Form
    {
        string userNamePass;
        decimal totalPrice;
        string connectionString = "data source=DESKTOP-HRU59TM\\SQLEXPRESS; database=PatientHealthNexus; integrated security=SSPI";

        public AddToCartPage(string x)
        {
            userNamePass = x;
            InitializeComponent();
            panel2.Hide();
        }

        private void FillDataGridView()
        {
            string query = "SELECT [CartID], [MedicineName], [Price], [Quantity], [QuantityInStock], [PatientUserName], [PharmacyUserName], [MedicineId] " +
                           "FROM [PatientHealthNexus].[dbo].[Cart] WHERE [PatientUserName] = @PatientUserName";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, con))
                {
                    command.Parameters.AddWithValue("@PatientUserName", userNamePass);
                    dataGridView1.AutoGenerateColumns = false;
                    con.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);
                    dataGridView1.DataSource = dataTable;

                    if (!dataGridView1.Columns.Contains("TotalPrice"))
                    {
                        dataGridView1.Columns.Add("TotalPrice", "Total Price");
                        dataGridView1.Columns["TotalPrice"].ValueType = typeof(decimal);
                    }

                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        decimal price = Convert.ToDecimal(row.Cells["Price"].Value);
                        int quantity = Convert.ToInt32(row.Cells["Quantity"].Value);
                        row.Cells["TotalPrice"].Value = price * quantity;
                    }

                    AddButtonColumns();
                }
            }
            UpdateTotalPriceLabel();
        }

        private void AddButtonColumns()
        {
            if (!dataGridView1.Columns.Contains("Add"))
            {
                DataGridViewButtonColumn addButtonColumn = new DataGridViewButtonColumn
                {
                    HeaderText = "Add",
                    Name = "Add",
                    Text = "Add",
                    UseColumnTextForButtonValue = true
                };
                dataGridView1.Columns.Add(addButtonColumn);
            }

            if (!dataGridView1.Columns.Contains("Subtruct"))
            {
                DataGridViewButtonColumn subtractButtonColumn = new DataGridViewButtonColumn
                {
                    HeaderText = "Subtruct",
                    Name = "Subtruct",
                    Text = "Subtruct",
                    UseColumnTextForButtonValue = true
                };
                dataGridView1.Columns.Add(subtractButtonColumn);
            }

            if (!dataGridView1.Columns.Contains("Remove"))
            {
                DataGridViewButtonColumn removeButtonColumn = new DataGridViewButtonColumn
                {
                    HeaderText = "Remove",
                    Name = "Remove",
                    Text = "Remove",
                    UseColumnTextForButtonValue = true
                };
                dataGridView1.Columns.Add(removeButtonColumn);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int cartID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["CartID"].Value);
                if (dataGridView1.Columns[e.ColumnIndex].Name == "Add")
                {
                    UpdateQuantity(cartID, 1);
                }
                else if (dataGridView1.Columns[e.ColumnIndex].Name == "Subtruct")
                {
                    UpdateQuantity(cartID, -1);
                }
                else if (dataGridView1.Columns[e.ColumnIndex].Name == "Remove")
                {
                    RemoveCartItem(cartID);
                }
            }
        }

        private void UpdateQuantity(int cartID, int change)
        {
            string query = "UPDATE [PatientHealthNexus].[dbo].[Cart] SET [Quantity] = [Quantity] + @Change WHERE [CartID] = @CartID";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, con))
                {
                    command.Parameters.AddWithValue("@Change", change);
                    command.Parameters.AddWithValue("@CartID", cartID);
                    con.Open();
                    command.ExecuteNonQuery();
                }
            }
            FillDataGridView();
        }

        private void RemoveCartItem(int cartID)
        {
            string query = "DELETE FROM [PatientHealthNexus].[dbo].[Cart] WHERE [CartID] = @CartID";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, con))
                {
                    command.Parameters.AddWithValue("@CartID", cartID);
                    con.Open();
                    command.ExecuteNonQuery();
                }
            }
            FillDataGridView();
        }

        private void UpdateTotalPriceLabel()
        {
            totalPrice = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                totalPrice += Convert.ToDecimal(row.Cells["TotalPrice"].Value);
            }
            decimal deliveryCharge = 60;
            decimal totalChargeWithDelivery = totalPrice + deliveryCharge;

            labelforFullPrice.Text = $"Total price for all medicine: {totalPrice} Tk\n" +
                                     $"Delivery Charge: {deliveryCharge} Tk\n" +
                                     $"Total Charge with Delivery Charge: {totalChargeWithDelivery} Tk";
        }

        private void AddToCartPage_Load(object sender, EventArgs e)
        {
            
        }

        private void AddToCartPage_Load_1(object sender, EventArgs e)
        {
            FillDataGridView();
        }

        private void proceedBTN_Click(object sender, EventArgs e)
        {
            if(totalPrice==0)
            {
                MessageBox.Show("Your Cart is Empty", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                panel2.Show();
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlTransaction transaction = con.BeginTransaction();
                try
                {
                    // Fetch all cart items for the current user
                    string selectQuery = "SELECT [CartID], [MedicineName], [Quantity], [Price], [MedicineID], [PharmacyUserName] " +
                                         "FROM [PatientHealthNexus].[dbo].[Cart] WHERE [PatientUserName] = @PatientUserName";

                    DataTable cartTable = new DataTable();
                    using (SqlCommand selectCommand = new SqlCommand(selectQuery, con, transaction))
                    {
                        selectCommand.Parameters.AddWithValue("@PatientUserName", userNamePass);
                        using (SqlDataAdapter adapter = new SqlDataAdapter(selectCommand))
                        {
                            adapter.Fill(cartTable);
                        }
                    }

                    // Insert each item into OrderHistory
                    foreach (DataRow row in cartTable.Rows)
                    {
                        string insertQuery = "INSERT INTO [PatientHealthNexus].[dbo].[OrderHistory] " +
                                             "([MedicineName], [Quantity], [TotalPrice], [DeleveryFromPharmacy], [DeleveryFromWearHouse], [MedicineID], [PatientUserName], [PharmacyUserName], [ReceivedByWearhouse], [ReceivedByPatient], [ShippingAddres], [Division], [PhoneNumber], [PaymentMathod]) " +
                                             "VALUES (@MedicineName, @Quantity, @TotalPrice, @DeleveryFromPharmacy, @DeleveryFromWearHouse, @MedicineID, @PatientUserName, @PharmacyUserName, @ReceivedByWearhouse, @ReceivedByPatient, @ShippingAddres, @Division, @PhoneNumber, @PaymentMathod)";

                        using (SqlCommand insertCommand = new SqlCommand(insertQuery, con, transaction))
                        {
                            insertCommand.Parameters.AddWithValue("@MedicineName", row["MedicineName"]);
                            insertCommand.Parameters.AddWithValue("@Quantity", row["Quantity"]);
                            insertCommand.Parameters.AddWithValue("@TotalPrice", Convert.ToDecimal(row["Price"]) * Convert.ToInt32(row["Quantity"]));
                            insertCommand.Parameters.AddWithValue("@DeleveryFromPharmacy", "Pending");
                            insertCommand.Parameters.AddWithValue("@DeleveryFromWearHouse", "Pending");
                            insertCommand.Parameters.AddWithValue("@MedicineID", row["MedicineID"]);
                            insertCommand.Parameters.AddWithValue("@PatientUserName", userNamePass);
                            insertCommand.Parameters.AddWithValue("@PharmacyUserName", row["PharmacyUserName"]);
                            // insertCommand.Parameters.AddWithValue("@PharmacyUserName", row["PharmacyUserName"]);
                            insertCommand.Parameters.AddWithValue("@ReceivedByWearhouse", "Pending");
                            insertCommand.Parameters.AddWithValue("@ReceivedByPatient", "Pending");
                            insertCommand.Parameters.AddWithValue("@ShippingAddres", ShippingAddTXT.Text);
                            insertCommand.Parameters.AddWithValue("@Division", divisionCB.Text);
                            insertCommand.Parameters.AddWithValue("@PhoneNumber", phNumberTXT.Text);
                            string paymentMahod = "";

                            if (radioButton1.Checked)
                            {
                                paymentMahod = "Cash On Delivery";
                            }
                            else if (radioButton2.Checked)
                            {
                                paymentMahod = "Online";
                            }
                            insertCommand.Parameters.AddWithValue("@PaymentMathod", paymentMahod);
                            insertCommand.ExecuteNonQuery();
                        }

                        string updateStockQuery = "UPDATE [PatientHealthNexus].[dbo].[Medicine] " +
                                          "SET [QuantityInStock] = [QuantityInStock] - @Quantity " +
                                          "WHERE [MedicineID] = @MedicineID";

                        using (SqlCommand updateCommand = new SqlCommand(updateStockQuery, con, transaction))
                        {
                            updateCommand.Parameters.AddWithValue("@Quantity", row["Quantity"]);
                            updateCommand.Parameters.AddWithValue("@MedicineID", row["MedicineID"]);
                            updateCommand.ExecuteNonQuery();
                        }

                        panel2.Hide();
                    }

                    // Delete all cart items for the current user
                    string deleteQuery = "DELETE FROM [PatientHealthNexus].[dbo].[Cart] WHERE [PatientUserName] = @PatientUserName";
                    using (SqlCommand deleteCommand = new SqlCommand(deleteQuery, con, transaction))
                    {
                        deleteCommand.Parameters.AddWithValue("@PatientUserName", userNamePass);
                        deleteCommand.ExecuteNonQuery();
                    }

                    transaction.Commit();
                    MessageBox.Show("Order placed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FillDataGridView(); // Refresh the DataGridView to reflect the cart is empty
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("An error occurred while placing the order: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
