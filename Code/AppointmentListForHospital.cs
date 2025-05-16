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
    public partial class AppointmentListForHospital : Form
    {
        string connectionString = "data source=DESKTOP-HRU59TM\\SQLEXPRESS; database=PatientHealthNexus; integrated security=SSPI";
        string userNamePass;
        public AppointmentListForHospital(string x)
        {
            userNamePass = x;
            InitializeComponent();
            LoadAppointmentData();
        }
        private void LoadAppointmentData()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = @"SELECT [AppointmentID], [PatientName], [DoctorID], [HospitalName], 
                                            [SerialNumber], [StartTime], [SerialTime], [Date], [Status]
                                     FROM [PatientHealthNexus].[dbo].[Appointment]";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

                    DataTable appointmentTable = new DataTable();
                    adapter.Fill(appointmentTable);
                    dataGridView1.DataSource = appointmentTable;

                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while loading data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string appointmentID = dataGridView1.Rows[e.RowIndex].Cells["AppointmentID"].Value.ToString();
            string doctorID = dataGridView1.Rows[e.RowIndex].Cells["DoctorID"].Value.ToString();

            if (dataGridView1.Columns[e.ColumnIndex].Name == "Accept")
            {
                string serialNumberValue = dataGridView1.Rows[e.RowIndex].Cells["SerialNumber"].Value?.ToString();

                if (string.IsNullOrEmpty(serialNumberValue) || !int.TryParse(serialNumberValue, out int serialNumber))
                {
                    MessageBox.Show("Please enter a valid Serial Number before accepting the appointment.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                UpdateAppointmentStatus(appointmentID, doctorID, serialNumber, "Accepted");
            }
            else if (dataGridView1.Columns[e.ColumnIndex].Name == "Reject")
            {
                UpdateAppointmentStatus(appointmentID, doctorID, null, "Rejected");
            }
        }

        private void UpdateAppointmentStatus(string appointmentID, string doctorID, int? serialNumber, string status)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    if (status == "Accepted" && serialNumber.HasValue)
                    {
                        // Fetch StartTime and TimeForPerPatient from Doctor table
                        string doctorQuery = @"SELECT [StartTime], [TimeForPerPatient]
                                               FROM [PatientHealthNexus].[dbo].[Doctor]
                                               WHERE [DID] = @DoctorID";

                        SqlCommand doctorCommand = new SqlCommand(doctorQuery, connection);
                        doctorCommand.Parameters.AddWithValue("@DoctorID", doctorID);

                        SqlDataReader reader = doctorCommand.ExecuteReader();
                        if (reader.Read())
                        {
                            TimeSpan startTime = TimeSpan.Parse(reader["StartTime"].ToString());
                            int timeForPerPatient = Convert.ToInt32(reader["TimeForPerPatient"]);
                            reader.Close();

                            // Calculate SerialTime
                            TimeSpan serialTime = startTime.Add(TimeSpan.FromMinutes(serialNumber.Value * timeForPerPatient));

                            // Update Appointment with SerialNumber, SerialTime, and Status
                            string updateQuery = @"UPDATE [PatientHealthNexus].[dbo].[Appointment]
                                                   SET [SerialNumber] = @SerialNumber,
                                                       [SerialTime] = @SerialTime,
                                                       [Status] = @Status
                                                   WHERE [AppointmentID] = @AppointmentID";

                            SqlCommand updateCommand = new SqlCommand(updateQuery, connection);
                            updateCommand.Parameters.AddWithValue("@SerialNumber", serialNumber.Value);
                            updateCommand.Parameters.AddWithValue("@SerialTime", serialTime);
                            updateCommand.Parameters.AddWithValue("@Status", status);
                            updateCommand.Parameters.AddWithValue("@AppointmentID", appointmentID);

                            updateCommand.ExecuteNonQuery();

                            MessageBox.Show("Appointment Accepted Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Doctor information not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else if (status == "Rejected")
                    {
                        // Update Appointment with Status only
                        string updateQuery = @"UPDATE [PatientHealthNexus].[dbo].[Appointment]
                                               SET [Status] = @Status
                                               WHERE [AppointmentID] = @AppointmentID";

                        SqlCommand updateCommand = new SqlCommand(updateQuery, connection);
                        updateCommand.Parameters.AddWithValue("@Status", status);
                        updateCommand.Parameters.AddWithValue("@AppointmentID", appointmentID);

                        updateCommand.ExecuteNonQuery();

                        MessageBox.Show("Appointment Rejected Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while updating the appointment: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            // Reload the data to reflect changes
            LoadAppointmentData();
        }
    }
}
