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
    public partial class findDoctor : Form
    {
        string connectionString = "data source=DESKTOP-HRU59TM\\SQLEXPRESS; database=PatientHealthNexus; integrated security=SSPI";
        string userNamePass;
        DataTable doctorTable;
        public findDoctor(string x)
        {
            userNamePass = x;   
            InitializeComponent();
            LoadDoctorData();
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string selectedDID = dataGridView1.Rows[e.RowIndex].Cells["DID"].Value.ToString();

            if (dataGridView1.Columns[e.ColumnIndex].Name == "Details")
            {
                ShowDoctorDetails(selectedDID);
            }
            else if (dataGridView1.Columns[e.ColumnIndex].Name == "Appointment")
            {
                string dateInput = dataGridView1.Rows[e.RowIndex].Cells["Date"].Value?.ToString();

                if (string.IsNullOrEmpty(dateInput) || !DateTime.TryParse(dateInput, out DateTime appointmentDate))
                {
                    MessageBox.Show("Please enter a valid date in the Appointment Date column.", "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                ConfirmAndAddAppointment(selectedDID, appointmentDate);
            }
        }

        private void ShowDoctorDetails(string did)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM [PatientHealthNexus].[dbo].[Doctor] WHERE [DID] = @DID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@DID", did);

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    string details = $"Doctor Details:\n\n" +
                                     $"Name: {reader["Name"]}\n" +
                                     $"Specialization: {reader["Specialization"]}\n" +
                                     $"Years of Experience: {reader["YearsOfExperience"]}\n" +
                                     $"Qualification: {reader["Qualification"]}\n" +
                                     $"Consultation Fee: {reader["ConsultationFee"]}\n" +
                                     $"Schedule: {reader["Schedule"]}\n" +
                                     $"Start Time: {reader["StartTime"]}\n" +
                                     $"Time for Per Patient: {reader["TimeForPerPatient"]}\n" +
                                     $"Hospital Name: {reader["HospitalName"]}";

                    MessageBox.Show(details, "Doctor Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Doctor details not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ConfirmAndAddAppointment(string doctorID, DateTime appointmentDate)
        {
            DialogResult result = MessageBox.Show("Are you sure about this appointment?", "Confirm Appointment", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string fetchStartTimeQuery = "SELECT StartTime FROM [PatientHealthNexus].[dbo].[Doctor] WHERE DID = @DoctorID";
                    SqlCommand fetchStartTimeCommand = new SqlCommand(fetchStartTimeQuery, connection);
                    fetchStartTimeCommand.Parameters.AddWithValue("@DoctorID", doctorID);

                    string startTime = null;
                    object resultObj = fetchStartTimeCommand.ExecuteScalar();
                    if (resultObj != null)
                    {
                        startTime = resultObj.ToString();
                    }
                    string query = "INSERT INTO [PatientHealthNexus].[dbo].[Appointment] " +
                                   "([PatientName], [DoctorID], [HospitalName], [StartTime], [Date], [Status]) " +
                                   "VALUES (@PatientName, @DoctorID, @HospitalName, @StartTime, @Date, @Status)";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@PatientName", userNamePass);
                    command.Parameters.AddWithValue("@DoctorID", doctorID);
                    command.Parameters.AddWithValue("@HospitalName", dataGridView1.Rows[0].Cells["HospitalName"].Value.ToString());
                    command.Parameters.AddWithValue("@StartTime", startTime);
                    command.Parameters.AddWithValue("@Date", appointmentDate);
                    command.Parameters.AddWithValue("@Status", "pending");

                    command.ExecuteNonQuery();
                }

                MessageBox.Show("Appointment request sent successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void LoadDoctorData()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT [DID], [Name], [Specialization], [HospitalName] FROM [PatientHealthNexus].[dbo].[Doctor]";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

                doctorTable = new DataTable();
                adapter.Fill(doctorTable);
                dataGridView1.DataSource = doctorTable;

            }
        }

        private void SearchTXT_TextChanged(object sender, EventArgs e)
        {
            if (doctorTable != null)
            {
                string filterText = SearchTXT.Text.Trim();
                string filterExpression = string.Format("[Name] LIKE '%{0}%' OR [Specialization] LIKE '%{0}%' OR [HospitalName] LIKE '%{0}%'", filterText.Replace("'", "''"));
                doctorTable.DefaultView.RowFilter = filterExpression;
            }
        }
    }
}
