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
    public partial class HealthServiceforPatientPage : Form
    {
        string connectionString = "data source=DESKTOP-HRU59TM\\SQLEXPRESS; database=PatientHealthNexus; integrated security=SSPI";
        string userNamePass;
        public HealthServiceforPatientPage(string x)
        {
            userNamePass = x;
            InitializeComponent();
            panel2.Show();
            panel3.Hide();  
            panel4.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void LoadDiagnosticServices()
        {
            string query = "SELECT TOP 1000 [DSID], [Name], [RegularPrice], [DiscountRate], [DiscountPrice], [HospitalName] FROM [PatientHealthNexus].[dbo].[DiagnosticServices]";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;


                    dataGridView1.Columns[0].HeaderText = "Diagnostic Service ID";
                    dataGridView1.Columns[1].HeaderText = "Service Name";
                    dataGridView1.Columns[2].HeaderText = "Regular Price";
                    dataGridView1.Columns[3].HeaderText = "Discount Rate";
                    dataGridView1.Columns[4].HeaderText = "Discount Price";
                    dataGridView1.Columns[5].HeaderText = "Hospital Name";


                    int totalWidth = dataGridView1.Width;
                    int[] columnWidths = { 50, 100, 100, 70, 100, 140 };
                    for (int i = 0; i < columnWidths.Length; i++)
                    {
                        dataGridView1.Columns[i].Width = columnWidths[i];
                    }


                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
                    dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;

                    // Enable scrolling if needed
                    dataGridView1.ScrollBars = ScrollBars.Both;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while loading data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LoadSurgeryPackages()
        {
            string query = "SELECT TOP 1000 [SID], [SurgeryName], [PriceInWard], [PriceInStandard], [PriceInDeluxe], [PriceInSuite], [DurationOfStay], [HospitalName] FROM [PatientHealthNexus].[dbo].[SurgeryPackages]";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView2.DataSource = dt;

                    // Optional: Customize column headers
                    dataGridView2.Columns[0].HeaderText = "Surgery ID";
                    dataGridView2.Columns[1].HeaderText = "Surgery Name";
                    dataGridView2.Columns[2].HeaderText = "Price in Ward";
                    dataGridView2.Columns[3].HeaderText = "Price in Standard";
                    dataGridView2.Columns[4].HeaderText = "Price in Deluxe";
                    dataGridView2.Columns[5].HeaderText = "Price in Suite";
                    dataGridView2.Columns[6].HeaderText = "Duration of Stay";
                    dataGridView2.Columns[7].HeaderText = "Hospital Name";


                    int totalWidth = dataGridView2.Width;
                    int[] columnWidths = { 80, 150, 100, 100, 100, 100, 80, 140 };
                    for (int i = 0; i < columnWidths.Length; i++)
                    {
                        dataGridView2.Columns[i].Width = columnWidths[i];
                    }

                    dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
                    dataGridView2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;

                    dataGridView2.ScrollBars = ScrollBars.Both;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while loading data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void HealthServiceforPatientPage_Load(object sender, EventArgs e)
        {
            LoadSurgeryPackages();
            LoadDiagnosticServices();
            LoadHealthCheckupServices();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void back_BTN_Click(object sender, EventArgs e)
        {
            this.Hide();
            PatientMainMainPage patientMainMainPage = new PatientMainMainPage(userNamePass);
            patientMainMainPage.Show();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       

        private void LoadHealthCheckupServices()
        {
            string query = "SELECT TOP 1000 [HCID], [CheckupName], [RegularPrice], [DiscountRate], [DiscountPrice], [ProvideService], [HospitalName] FROM [PatientHealthNexus].[dbo].[HealthCheckup]";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView3.DataSource = dt;

                    dataGridView3.Columns[0].HeaderText = "Health Checkup ID";
                    dataGridView3.Columns[1].HeaderText = "Checkup Name";
                    dataGridView3.Columns[2].HeaderText = "Regular Price";
                    dataGridView3.Columns[3].HeaderText = "Discount Rate";
                    dataGridView3.Columns[4].HeaderText = "Discount Price";
                    dataGridView3.Columns[5].HeaderText = "Provide Service";
                    dataGridView3.Columns[6].HeaderText = "Hospital Name";

                    int[] columnWidths = { 80, 150, 100, 100, 100, 120, 120 };
                    for (int i = 0; i < columnWidths.Length; i++)
                    {
                        dataGridView3.Columns[i].Width = columnWidths[i];
                    }

                    dataGridView3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
                    dataGridView3.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
                    dataGridView3.ScrollBars = ScrollBars.Both;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while loading data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void surgeryPackagesBTN_Click(object sender, EventArgs e)
        {
        
            panel3.Show();
            panel4.Hide();

        }

        private void DiagonsticServiceBTN_Click(object sender, EventArgs e)
        {

            panel3.Hide();
            panel4.Hide();

        }
        private void button2_Click(object sender, EventArgs e)
        {
            

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            panel4.Show();
        }
    }
}
