using System;
using System.Collections;
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
    public partial class DoctorList : Form
    {
        string connectionString = "data source=DESKTOP-HRU59TM\\SQLEXPRESS; database=PatientHealthNexus; integrated security=SSPI";
        string userNamePass;
        string query;
        public DoctorList(string x)
        {
            userNamePass = x;   
            InitializeComponent();
            LoadDoctorData();
        }

        private void LoadDoctorData()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                if(userNamePass=="admin" || userNamePass == "execuitive")
                {
                    query = "SELECT [DID], [Name], [Specialization], [YearsOfExperience], [Qualification], [ConsultationFee], [Schedule], [StartTime], [TimeForPerPatient], [HospitalName] " +
                               "FROM [PatientHealthNexus].[dbo].[Doctor]";
                }
                else
                {
                    query = "SELECT [DID], [Name], [Specialization], [YearsOfExperience], [Qualification], [ConsultationFee], [Schedule], [StartTime], [TimeForPerPatient]" +
                               "FROM [PatientHealthNexus].[dbo].[Doctor] WHERE [HospitalName] = @HospitalName";
                }



                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.SelectCommand.Parameters.AddWithValue("@HospitalName", userNamePass);
                DataTable table = new DataTable();
                adapter.Fill(table);

                dataGridView1.DataSource = table;

                if (userNamePass == "admin" || userNamePass == "executive")
                {
                    if (dataGridView1.Columns.Contains("HospitalName"))
                    {
                        dataGridView1.Columns["HospitalName"].Width = 40; // Set column width to 50
                    }
                }
            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string selectedDID = dataGridView1.Rows[e.RowIndex].Cells["DID"].Value.ToString();

            if (dataGridView1.Columns[e.ColumnIndex].Name == "Delete")
            {
                DeleteDoctor(selectedDID);
            }
            else if (dataGridView1.Columns[e.ColumnIndex].Name == "Update")
            {
                UpdateDoctor(e.RowIndex);
            }
        }

        private void DeleteDoctor(string did)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "DELETE FROM [PatientHealthNexus].[dbo].[Doctor] WHERE [DID] = @DID";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@DID", did);

                command.ExecuteNonQuery();
            }
            MessageBox.Show("Doctor deleted successfully.");
            LoadDoctorData();
        }

        private void UpdateDoctor(int rowIndex)
        {
            DataGridViewRow row = dataGridView1.Rows[rowIndex];

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "UPDATE [PatientHealthNexus].[dbo].[Doctor] " +
               "SET [Name] = @Name, [Specialization] = @Specialization, [YearsOfExperience] = @YearsOfExperience, " +
               "[Qualification] = @Qualification, [ConsultationFee] = @ConsultationFee, [Schedule] = @Schedule, " +
               "[StartTime] = @StartTime, [TimeForPerPatient] = @TimeForPerPatient " + // No trailing comma
               "WHERE [DID] = @DID";

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@DID", row.Cells["DID"].Value);
                command.Parameters.AddWithValue("@Name", row.Cells["DrName"].Value);
                command.Parameters.AddWithValue("@Specialization", row.Cells["Specialization"].Value);
                command.Parameters.AddWithValue("@YearsOfExperience", row.Cells["YearsOfExperience"].Value);
                command.Parameters.AddWithValue("@Qualification", row.Cells["Qualification"].Value);
                command.Parameters.AddWithValue("@ConsultationFee", row.Cells["ConsultationFee"].Value);
                command.Parameters.AddWithValue("@Schedule", row.Cells["Schedule"].Value);
                command.Parameters.AddWithValue("@StartTime", row.Cells["StartTime"].Value);
                command.Parameters.AddWithValue("@TimeForPerPatient", row.Cells["TimeForPerPatient"].Value);

                command.ExecuteNonQuery();
            }
            MessageBox.Show("Doctor updated successfully.");
            LoadDoctorData();
        }
    }
}
