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
    public partial class AddDoctor : Form
    {
        string connectionString = "data source=DESKTOP-HRU59TM\\SQLEXPRESS; database=PatientHealthNexus; integrated security=SSPI";
        string userNamePass;
        public AddDoctor(string x)
        {
            userNamePass = x;   
            InitializeComponent();
        }


        private void addDR_Click(object sender, EventArgs e)
        {
            string drName = drNameTXT.Text.Trim();
            string specialization = specializationTXT.Text.Trim();
            string experience = expTXT.Text.Trim();
            string qualification = qTXT.Text.Trim();
            string fee = feeTXT.Text.Trim();
            string schedule = scheduleTXT.Text.Trim();
            string startTime = startTXT.Text.Trim();
            string perPatientTime = perPatTimeTXT.Text.Trim();
            string hospitalName = hosNameTXT.Text.Trim();

            if (string.IsNullOrEmpty(drName) || string.IsNullOrEmpty(specialization) || string.IsNullOrEmpty(experience) ||
                string.IsNullOrEmpty(qualification) || string.IsNullOrEmpty(fee) || string.IsNullOrEmpty(schedule) ||
                string.IsNullOrEmpty(startTime) || string.IsNullOrEmpty(perPatientTime))
            {
                MessageBox.Show("Please fill in all fields before adding a doctor.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "INSERT INTO [PatientHealthNexus].[dbo].[Doctor] ([Name], [Specialization], [YearsOfExperience], [Qualification], " +
                               "[ConsultationFee], [Schedule], [StartTime], [TimeForPerPatient], [HospitalName]) " +
                               "VALUES (@Name, @Specialization, @YearsOfExperience, @Qualification, @ConsultationFee, @Schedule, @StartTime, @TimeForPerPatient, @HospitalName)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Name", drName);
                    command.Parameters.AddWithValue("@Specialization", specialization);
                    command.Parameters.AddWithValue("@YearsOfExperience", experience);
                    command.Parameters.AddWithValue("@Qualification", qualification);
                    command.Parameters.AddWithValue("@ConsultationFee", fee);
                    command.Parameters.AddWithValue("@Schedule", schedule);
                    command.Parameters.AddWithValue("@StartTime", startTime);
                    command.Parameters.AddWithValue("@TimeForPerPatient", perPatientTime);
                    if(userNamePass=="admin" ||  userNamePass== "execuitive")
                    {
                        command.Parameters.AddWithValue("@HospitalName", hospitalName);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@HospitalName", userNamePass);
                    }

                    try
                    {
                        command.ExecuteNonQuery();
                        MessageBox.Show("Doctor added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearFields();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void ClearFields()
        {
            drNameTXT.Text = string.Empty;
            specializationTXT.Text = string.Empty;
            expTXT.Text = string.Empty;
            qTXT.Text = string.Empty;
            feeTXT.Text = string.Empty;
            scheduleTXT.Text = string.Empty;
            startTXT.Text = string.Empty;
            perPatTimeTXT.Text = string.Empty;
        }

        private void AddDoctor_Load(object sender, EventArgs e)
        {
            if (userNamePass == "admin" || userNamePass == "execuitive")
            {
                panel1.Show();
            }
            else
            {
                
                panel1.Hide();
            }
        }
    }
}

