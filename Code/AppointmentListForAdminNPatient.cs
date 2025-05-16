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
    public partial class AppointmentListForAdminNPatient : Form
    {
        string connectionString = "data source=DESKTOP-HRU59TM\\SQLEXPRESS; database=PatientHealthNexus; integrated security=SSPI";
        string userNamePass;
        string query;
        public AppointmentListForAdminNPatient(string x)
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
                    if(userNamePass=="admin"||userNamePass== "execuitive")
                    {
                        query = @"SELECT [AppointmentID],
                                    [PatientName],
                                    [DoctorID],
                                    [HospitalName],
                                    [SerialNumber],
                                    [StartTime],
                                    [SerialTime],
                                    [Date],
                                    [Status]
                             FROM [PatientHealthNexus].[dbo].[Appointment]";
                    }
                    else
                    {
                        query = @"SELECT [AppointmentID],
                                    [PatientName],
                                    [DoctorID],
                                    [HospitalName],
                                    [SerialNumber],
                                    [StartTime],
                                    [SerialTime],
                                    [Date],
                                    [Status]
                             FROM [PatientHealthNexus].[dbo].[Appointment]
                             WHERE [PatientName] = @PatientName";
                    }
                    

                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    adapter.SelectCommand.Parameters.AddWithValue("@PatientName", userNamePass);

                    DataTable appointmentTable = new DataTable();
                    adapter.Fill(appointmentTable);

                    // Bind the data to the DataGridView
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

        }
    }
}
