namespace Patient_Health_Nexus.Code
{
    partial class DoctorList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoctorList));
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DrName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Specialization = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YearsOfExperience = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qualification = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConsultationFee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Schedule = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeForPerPatient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Update = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(12, -1);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(758, 137);
            this.guna2PictureBox1.TabIndex = 0;
            this.guna2PictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.InfoText;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.Info;
            this.textBox1.Location = new System.Drawing.Point(193, 98);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(347, 38);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Doctor List";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DID,
            this.DrName,
            this.Specialization,
            this.YearsOfExperience,
            this.Qualification,
            this.ConsultationFee,
            this.Schedule,
            this.StartTime,
            this.TimeForPerPatient,
            this.Update,
            this.Delete});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 136);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 6;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(785, 517);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // DID
            // 
            this.DID.DataPropertyName = "DID";
            this.DID.HeaderText = "DID";
            this.DID.MinimumWidth = 6;
            this.DID.Name = "DID";
            this.DID.Width = 30;
            // 
            // DrName
            // 
            this.DrName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DrName.DataPropertyName = "Name";
            this.DrName.HeaderText = "Doctor Name";
            this.DrName.MinimumWidth = 6;
            this.DrName.Name = "DrName";
            // 
            // Specialization
            // 
            this.Specialization.DataPropertyName = "Specialization";
            this.Specialization.HeaderText = "Specialization";
            this.Specialization.MinimumWidth = 6;
            this.Specialization.Name = "Specialization";
            this.Specialization.Width = 50;
            // 
            // YearsOfExperience
            // 
            this.YearsOfExperience.DataPropertyName = "YearsOfExperience";
            this.YearsOfExperience.HeaderText = "Years Of Experience";
            this.YearsOfExperience.MinimumWidth = 6;
            this.YearsOfExperience.Name = "YearsOfExperience";
            this.YearsOfExperience.Width = 30;
            // 
            // Qualification
            // 
            this.Qualification.DataPropertyName = "Qualification";
            this.Qualification.HeaderText = "Qualification";
            this.Qualification.MinimumWidth = 6;
            this.Qualification.Name = "Qualification";
            this.Qualification.Width = 90;
            // 
            // ConsultationFee
            // 
            this.ConsultationFee.DataPropertyName = "ConsultationFee";
            this.ConsultationFee.HeaderText = "Consultation Fee";
            this.ConsultationFee.MinimumWidth = 6;
            this.ConsultationFee.Name = "ConsultationFee";
            this.ConsultationFee.Width = 50;
            // 
            // Schedule
            // 
            this.Schedule.DataPropertyName = "Schedule";
            this.Schedule.HeaderText = "Schedule";
            this.Schedule.MinimumWidth = 6;
            this.Schedule.Name = "Schedule";
            this.Schedule.Width = 50;
            // 
            // StartTime
            // 
            this.StartTime.DataPropertyName = "StartTime";
            this.StartTime.HeaderText = "Start Time";
            this.StartTime.MinimumWidth = 6;
            this.StartTime.Name = "StartTime";
            this.StartTime.Width = 50;
            // 
            // TimeForPerPatient
            // 
            this.TimeForPerPatient.DataPropertyName = "TimeForPerPatient";
            this.TimeForPerPatient.HeaderText = "Time For Per Patient";
            this.TimeForPerPatient.MinimumWidth = 6;
            this.TimeForPerPatient.Name = "TimeForPerPatient";
            this.TimeForPerPatient.Width = 40;
            // 
            // Update
            // 
            this.Update.HeaderText = "Update";
            this.Update.Image = ((System.Drawing.Image)(resources.GetObject("Update.Image")));
            this.Update.MinimumWidth = 6;
            this.Update.Name = "Update";
            this.Update.Width = 35;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.Image = ((System.Drawing.Image)(resources.GetObject("Delete.Image")));
            this.Delete.MinimumWidth = 6;
            this.Delete.Name = "Delete";
            this.Delete.Width = 35;
            // 
            // DoctorList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 653);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.guna2PictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DoctorList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DoctorList";
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DrName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Specialization;
        private System.Windows.Forms.DataGridViewTextBoxColumn YearsOfExperience;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qualification;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConsultationFee;
        private System.Windows.Forms.DataGridViewTextBoxColumn Schedule;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeForPerPatient;
        private System.Windows.Forms.DataGridViewImageColumn Update;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
    }
}