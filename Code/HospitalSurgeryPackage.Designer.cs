namespace Patient_Health_Nexus
{
    partial class HospitalSurgeryPackage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HospitalSurgeryPackage));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.surgeryNameTXT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.addBTN = new System.Windows.Forms.Button();
            this.deluxePriceTXT = new System.Windows.Forms.TextBox();
            this.wordPriceTXT = new System.Windows.Forms.TextBox();
            this.sdfdsjf = new System.Windows.Forms.Label();
            this.rgerge = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.SearchTXT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.StayTXT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.suitePriceTXT = new System.Windows.Forms.TextBox();
            this.sharedPriceTXT = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SurgeryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DurationOfStay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceInWard = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceInStandard = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceInDeluxe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceInSuite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.update = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SID,
            this.SurgeryName,
            this.DurationOfStay,
            this.PriceInWard,
            this.PriceInStandard,
            this.PriceInDeluxe,
            this.PriceInSuite,
            this.update,
            this.Delete});
            this.dataGridView1.Location = new System.Drawing.Point(-1, 81);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(757, 338);
            this.dataGridView1.TabIndex = 339;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // surgeryNameTXT
            // 
            this.surgeryNameTXT.BackColor = System.Drawing.SystemColors.Control;
            this.surgeryNameTXT.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surgeryNameTXT.Location = new System.Drawing.Point(167, 471);
            this.surgeryNameTXT.Margin = new System.Windows.Forms.Padding(4);
            this.surgeryNameTXT.Multiline = true;
            this.surgeryNameTXT.Name = "surgeryNameTXT";
            this.surgeryNameTXT.Size = new System.Drawing.Size(193, 28);
            this.surgeryNameTXT.TabIndex = 337;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.label4.Location = new System.Drawing.Point(10, 476);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 23);
            this.label4.TabIndex = 336;
            this.label4.Text = "Surgery Name:-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 422);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(294, 29);
            this.label3.TabIndex = 335;
            this.label3.Text = "Add Surgery Packages:-";
            // 
            // addBTN
            // 
            this.addBTN.BackColor = System.Drawing.Color.Transparent;
            this.addBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBTN.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBTN.Image = ((System.Drawing.Image)(resources.GetObject("addBTN.Image")));
            this.addBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addBTN.Location = new System.Drawing.Point(281, 601);
            this.addBTN.Name = "addBTN";
            this.addBTN.Size = new System.Drawing.Size(158, 43);
            this.addBTN.TabIndex = 334;
            this.addBTN.Text = "ADD";
            this.addBTN.UseVisualStyleBackColor = false;
            this.addBTN.Click += new System.EventHandler(this.addBTN_Click);
            // 
            // deluxePriceTXT
            // 
            this.deluxePriceTXT.BackColor = System.Drawing.SystemColors.Control;
            this.deluxePriceTXT.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deluxePriceTXT.Location = new System.Drawing.Point(167, 566);
            this.deluxePriceTXT.Margin = new System.Windows.Forms.Padding(4);
            this.deluxePriceTXT.Multiline = true;
            this.deluxePriceTXT.Name = "deluxePriceTXT";
            this.deluxePriceTXT.Size = new System.Drawing.Size(193, 28);
            this.deluxePriceTXT.TabIndex = 333;
            // 
            // wordPriceTXT
            // 
            this.wordPriceTXT.BackColor = System.Drawing.SystemColors.Control;
            this.wordPriceTXT.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wordPriceTXT.Location = new System.Drawing.Point(167, 518);
            this.wordPriceTXT.Margin = new System.Windows.Forms.Padding(4);
            this.wordPriceTXT.Multiline = true;
            this.wordPriceTXT.Name = "wordPriceTXT";
            this.wordPriceTXT.Size = new System.Drawing.Size(193, 28);
            this.wordPriceTXT.TabIndex = 332;
            // 
            // sdfdsjf
            // 
            this.sdfdsjf.AutoSize = true;
            this.sdfdsjf.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sdfdsjf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.sdfdsjf.Location = new System.Drawing.Point(10, 571);
            this.sdfdsjf.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sdfdsjf.Name = "sdfdsjf";
            this.sdfdsjf.Size = new System.Drawing.Size(160, 23);
            this.sdfdsjf.TabIndex = 331;
            this.sdfdsjf.Text = "Price in Deluxe:-";
            // 
            // rgerge
            // 
            this.rgerge.AutoSize = true;
            this.rgerge.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rgerge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.rgerge.Location = new System.Drawing.Point(13, 523);
            this.rgerge.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.rgerge.Name = "rgerge";
            this.rgerge.Size = new System.Drawing.Size(146, 23);
            this.rgerge.TabIndex = 330;
            this.rgerge.Text = "Price in Word:-";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(187, 42);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 329;
            this.pictureBox2.TabStop = false;
            // 
            // SearchTXT
            // 
            this.SearchTXT.BackColor = System.Drawing.SystemColors.Control;
            this.SearchTXT.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchTXT.Location = new System.Drawing.Point(226, 42);
            this.SearchTXT.Margin = new System.Windows.Forms.Padding(4);
            this.SearchTXT.Multiline = true;
            this.SearchTXT.Name = "SearchTXT";
            this.SearchTXT.Size = new System.Drawing.Size(361, 32);
            this.SearchTXT.TabIndex = 328;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(276, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 29);
            this.label2.TabIndex = 327;
            this.label2.Text = "Surgery Packages";
            // 
            // StayTXT
            // 
            this.StayTXT.BackColor = System.Drawing.SystemColors.Control;
            this.StayTXT.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StayTXT.Location = new System.Drawing.Point(545, 466);
            this.StayTXT.Margin = new System.Windows.Forms.Padding(4);
            this.StayTXT.Multiline = true;
            this.StayTXT.Name = "StayTXT";
            this.StayTXT.Size = new System.Drawing.Size(193, 28);
            this.StayTXT.TabIndex = 345;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.label1.Location = new System.Drawing.Point(368, 471);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 23);
            this.label1.TabIndex = 344;
            this.label1.Text = "Duration Of Stay:-";
            // 
            // suitePriceTXT
            // 
            this.suitePriceTXT.BackColor = System.Drawing.SystemColors.Control;
            this.suitePriceTXT.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suitePriceTXT.Location = new System.Drawing.Point(545, 561);
            this.suitePriceTXT.Margin = new System.Windows.Forms.Padding(4);
            this.suitePriceTXT.Multiline = true;
            this.suitePriceTXT.Name = "suitePriceTXT";
            this.suitePriceTXT.Size = new System.Drawing.Size(193, 28);
            this.suitePriceTXT.TabIndex = 343;
            // 
            // sharedPriceTXT
            // 
            this.sharedPriceTXT.BackColor = System.Drawing.SystemColors.Control;
            this.sharedPriceTXT.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sharedPriceTXT.Location = new System.Drawing.Point(545, 513);
            this.sharedPriceTXT.Margin = new System.Windows.Forms.Padding(4);
            this.sharedPriceTXT.Multiline = true;
            this.sharedPriceTXT.Name = "sharedPriceTXT";
            this.sharedPriceTXT.Size = new System.Drawing.Size(193, 28);
            this.sharedPriceTXT.TabIndex = 342;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.label5.Location = new System.Drawing.Point(377, 566);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 23);
            this.label5.TabIndex = 341;
            this.label5.Text = "Price in Suite:-";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.label6.Location = new System.Drawing.Point(376, 518);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 23);
            this.label6.TabIndex = 340;
            this.label6.Text = "Price in Shared:-";
            // 
            // SID
            // 
            this.SID.DataPropertyName = "SID";
            this.SID.HeaderText = "SID";
            this.SID.MinimumWidth = 6;
            this.SID.Name = "SID";
            this.SID.Width = 30;
            // 
            // SurgeryName
            // 
            this.SurgeryName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SurgeryName.DataPropertyName = "SurgeryName";
            this.SurgeryName.HeaderText = "Surgery Name";
            this.SurgeryName.MinimumWidth = 6;
            this.SurgeryName.Name = "SurgeryName";
            // 
            // DurationOfStay
            // 
            this.DurationOfStay.DataPropertyName = "DurationOfStay";
            this.DurationOfStay.HeaderText = "Duration Of Stay";
            this.DurationOfStay.MinimumWidth = 6;
            this.DurationOfStay.Name = "DurationOfStay";
            this.DurationOfStay.Width = 50;
            // 
            // PriceInWard
            // 
            this.PriceInWard.DataPropertyName = "PriceInWard";
            this.PriceInWard.HeaderText = "PriceIn Ward";
            this.PriceInWard.MinimumWidth = 6;
            this.PriceInWard.Name = "PriceInWard";
            this.PriceInWard.Width = 50;
            // 
            // PriceInStandard
            // 
            this.PriceInStandard.DataPropertyName = "PriceInStandard";
            this.PriceInStandard.HeaderText = "Price In Standard";
            this.PriceInStandard.MinimumWidth = 6;
            this.PriceInStandard.Name = "PriceInStandard";
            this.PriceInStandard.Width = 50;
            // 
            // PriceInDeluxe
            // 
            this.PriceInDeluxe.DataPropertyName = "PriceInDeluxe";
            this.PriceInDeluxe.HeaderText = "Price In Deluxe";
            this.PriceInDeluxe.MinimumWidth = 6;
            this.PriceInDeluxe.Name = "PriceInDeluxe";
            this.PriceInDeluxe.Width = 50;
            // 
            // PriceInSuite
            // 
            this.PriceInSuite.DataPropertyName = "PriceInSuite";
            this.PriceInSuite.HeaderText = "Price In Suite";
            this.PriceInSuite.MinimumWidth = 6;
            this.PriceInSuite.Name = "PriceInSuite";
            this.PriceInSuite.Width = 50;
            // 
            // update
            // 
            this.update.HeaderText = "update";
            this.update.Image = ((System.Drawing.Image)(resources.GetObject("update.Image")));
            this.update.MinimumWidth = 6;
            this.update.Name = "update";
            this.update.Width = 30;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.Image = ((System.Drawing.Image)(resources.GetObject("Delete.Image")));
            this.Delete.MinimumWidth = 6;
            this.Delete.Name = "Delete";
            this.Delete.Width = 30;
            // 
            // HospitalSurgeryPackage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 653);
            this.Controls.Add(this.StayTXT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.suitePriceTXT);
            this.Controls.Add(this.sharedPriceTXT);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.surgeryNameTXT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.addBTN);
            this.Controls.Add(this.deluxePriceTXT);
            this.Controls.Add(this.wordPriceTXT);
            this.Controls.Add(this.sdfdsjf);
            this.Controls.Add(this.rgerge);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.SearchTXT);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HospitalSurgeryPackage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HospitalSurgeryPackage";
            this.Activated += new System.EventHandler(this.HospitalSurgeryPackage_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox surgeryNameTXT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button addBTN;
        private System.Windows.Forms.TextBox deluxePriceTXT;
        private System.Windows.Forms.TextBox wordPriceTXT;
        private System.Windows.Forms.Label sdfdsjf;
        private System.Windows.Forms.Label rgerge;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox SearchTXT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox StayTXT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox suitePriceTXT;
        private System.Windows.Forms.TextBox sharedPriceTXT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn SID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SurgeryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DurationOfStay;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceInWard;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceInStandard;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceInDeluxe;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceInSuite;
        private System.Windows.Forms.DataGridViewImageColumn update;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
    }
}