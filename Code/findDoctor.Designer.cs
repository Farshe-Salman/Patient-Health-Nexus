namespace Patient_Health_Nexus.Code
{
    partial class findDoctor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(findDoctor));
            this.label2 = new System.Windows.Forms.Label();
            this.SearchTXT = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DrName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Specialization = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HospitalName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Details = new System.Windows.Forms.DataGridViewImageColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Appointment = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(288, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 39);
            this.label2.TabIndex = 307;
            this.label2.Text = "Find Doctor";
            // 
            // SearchTXT
            // 
            this.SearchTXT.BackColor = System.Drawing.SystemColors.Control;
            this.SearchTXT.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchTXT.Location = new System.Drawing.Point(227, 63);
            this.SearchTXT.Margin = new System.Windows.Forms.Padding(4);
            this.SearchTXT.Multiline = true;
            this.SearchTXT.Name = "SearchTXT";
            this.SearchTXT.Size = new System.Drawing.Size(361, 32);
            this.SearchTXT.TabIndex = 305;
            this.SearchTXT.TextChanged += new System.EventHandler(this.SearchTXT_TextChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(190, 62);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 306;
            this.pictureBox2.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DID,
            this.DrName,
            this.Specialization,
            this.HospitalName,
            this.Details,
            this.Date,
            this.Appointment});
            this.dataGridView1.Location = new System.Drawing.Point(0, 111);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 6;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(784, 543);
            this.dataGridView1.TabIndex = 308;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // DID
            // 
            this.DID.DataPropertyName = "DID";
            this.DID.HeaderText = "DID";
            this.DID.MinimumWidth = 6;
            this.DID.Name = "DID";
            this.DID.Width = 35;
            // 
            // DrName
            // 
            this.DrName.DataPropertyName = "Name";
            this.DrName.HeaderText = "DrName";
            this.DrName.MinimumWidth = 6;
            this.DrName.Name = "DrName";
            this.DrName.Width = 140;
            // 
            // Specialization
            // 
            this.Specialization.DataPropertyName = "Specialization";
            this.Specialization.HeaderText = "Specialization";
            this.Specialization.MinimumWidth = 6;
            this.Specialization.Name = "Specialization";
            this.Specialization.Width = 115;
            // 
            // HospitalName
            // 
            this.HospitalName.DataPropertyName = "HospitalName";
            this.HospitalName.HeaderText = "HospitalName";
            this.HospitalName.MinimumWidth = 6;
            this.HospitalName.Name = "HospitalName";
            this.HospitalName.Width = 125;
            // 
            // Details
            // 
            this.Details.HeaderText = "Details";
            this.Details.Image = ((System.Drawing.Image)(resources.GetObject("Details.Image")));
            this.Details.MinimumWidth = 6;
            this.Details.Name = "Details";
            this.Details.Width = 40;
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.MinimumWidth = 6;
            this.Date.Name = "Date";
            this.Date.Width = 90;
            // 
            // Appointment
            // 
            this.Appointment.HeaderText = "Appointment";
            this.Appointment.Image = ((System.Drawing.Image)(resources.GetObject("Appointment.Image")));
            this.Appointment.MinimumWidth = 6;
            this.Appointment.Name = "Appointment";
            this.Appointment.Width = 40;
            // 
            // findDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 653);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.SearchTXT);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "findDoctor";
            this.Text = "findDoctor";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox SearchTXT;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DrName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Specialization;
        private System.Windows.Forms.DataGridViewTextBoxColumn HospitalName;
        private System.Windows.Forms.DataGridViewImageColumn Details;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewImageColumn Appointment;
    }
}