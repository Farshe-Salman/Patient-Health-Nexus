namespace Patient_Health_Nexus.Code
{
    partial class HospitalHealthCheckup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HospitalHealthCheckup));
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.addBTN = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.SearchTXT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.healthCheckupNameTXT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.discountRateTXT = new System.Windows.Forms.TextBox();
            this.regularPriceTXT = new System.Windows.Forms.TextBox();
            this.sdfdsjf = new System.Windows.Forms.Label();
            this.rgerge = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.provideServiceTXT = new System.Windows.Forms.TextBox();
            this.HCID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CheckupName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RegularPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiscountRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiscountPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProvideService = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Update = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.provideServiceTXT);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.healthCheckupNameTXT);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.discountRateTXT);
            this.panel2.Controls.Add(this.regularPriceTXT);
            this.panel2.Controls.Add(this.sdfdsjf);
            this.panel2.Controls.Add(this.rgerge);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.addBTN);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.SearchTXT);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(-1, -2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(760, 656);
            this.panel2.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HCID,
            this.CheckupName,
            this.RegularPrice,
            this.DiscountRate,
            this.DiscountPrice,
            this.ProvideService,
            this.Update,
            this.Delete});
            this.dataGridView1.Location = new System.Drawing.Point(0, 81);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(757, 362);
            this.dataGridView1.TabIndex = 326;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 446);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(374, 29);
            this.label3.TabIndex = 322;
            this.label3.Text = "Add Health Checkup Package:-";
            // 
            // addBTN
            // 
            this.addBTN.BackColor = System.Drawing.Color.Transparent;
            this.addBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBTN.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBTN.Image = ((System.Drawing.Image)(resources.GetObject("addBTN.Image")));
            this.addBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addBTN.Location = new System.Drawing.Point(297, 610);
            this.addBTN.Name = "addBTN";
            this.addBTN.Size = new System.Drawing.Size(158, 43);
            this.addBTN.TabIndex = 321;
            this.addBTN.Text = "ADD";
            this.addBTN.UseVisualStyleBackColor = false;
            this.addBTN.Click += new System.EventHandler(this.addBTN_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(188, 42);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 302;
            this.pictureBox2.TabStop = false;
            // 
            // SearchTXT
            // 
            this.SearchTXT.BackColor = System.Drawing.SystemColors.Control;
            this.SearchTXT.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchTXT.Location = new System.Drawing.Point(227, 42);
            this.SearchTXT.Margin = new System.Windows.Forms.Padding(4);
            this.SearchTXT.Multiline = true;
            this.SearchTXT.Name = "SearchTXT";
            this.SearchTXT.Size = new System.Drawing.Size(361, 32);
            this.SearchTXT.TabIndex = 301;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(251, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(305, 29);
            this.label2.TabIndex = 300;
            this.label2.Text = "Health Checkup Package";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.label5.Location = new System.Drawing.Point(668, 539);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 23);
            this.label5.TabIndex = 333;
            this.label5.Text = "%";
            // 
            // healthCheckupNameTXT
            // 
            this.healthCheckupNameTXT.BackColor = System.Drawing.SystemColors.Control;
            this.healthCheckupNameTXT.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.healthCheckupNameTXT.Location = new System.Drawing.Point(94, 491);
            this.healthCheckupNameTXT.Margin = new System.Windows.Forms.Padding(4);
            this.healthCheckupNameTXT.Multiline = true;
            this.healthCheckupNameTXT.Name = "healthCheckupNameTXT";
            this.healthCheckupNameTXT.Size = new System.Drawing.Size(604, 28);
            this.healthCheckupNameTXT.TabIndex = 332;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.label4.Location = new System.Drawing.Point(9, 496);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 23);
            this.label4.TabIndex = 331;
            this.label4.Text = "Name:-";
            // 
            // discountRateTXT
            // 
            this.discountRateTXT.BackColor = System.Drawing.SystemColors.Control;
            this.discountRateTXT.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discountRateTXT.Location = new System.Drawing.Point(531, 534);
            this.discountRateTXT.Margin = new System.Windows.Forms.Padding(4);
            this.discountRateTXT.Multiline = true;
            this.discountRateTXT.Name = "discountRateTXT";
            this.discountRateTXT.Size = new System.Drawing.Size(129, 28);
            this.discountRateTXT.TabIndex = 330;
            // 
            // regularPriceTXT
            // 
            this.regularPriceTXT.BackColor = System.Drawing.SystemColors.Control;
            this.regularPriceTXT.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regularPriceTXT.Location = new System.Drawing.Point(163, 534);
            this.regularPriceTXT.Margin = new System.Windows.Forms.Padding(4);
            this.regularPriceTXT.Multiline = true;
            this.regularPriceTXT.Name = "regularPriceTXT";
            this.regularPriceTXT.Size = new System.Drawing.Size(203, 28);
            this.regularPriceTXT.TabIndex = 329;
            // 
            // sdfdsjf
            // 
            this.sdfdsjf.AutoSize = true;
            this.sdfdsjf.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sdfdsjf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.sdfdsjf.Location = new System.Drawing.Point(374, 539);
            this.sdfdsjf.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sdfdsjf.Name = "sdfdsjf";
            this.sdfdsjf.Size = new System.Drawing.Size(149, 23);
            this.sdfdsjf.TabIndex = 328;
            this.sdfdsjf.Text = "Discount Rate:-";
            // 
            // rgerge
            // 
            this.rgerge.AutoSize = true;
            this.rgerge.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rgerge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.rgerge.Location = new System.Drawing.Point(9, 539);
            this.rgerge.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.rgerge.Name = "rgerge";
            this.rgerge.Size = new System.Drawing.Size(146, 23);
            this.rgerge.TabIndex = 327;
            this.rgerge.Text = "Regular Price:-";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.label1.Location = new System.Drawing.Point(14, 580);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 23);
            this.label1.TabIndex = 334;
            this.label1.Text = "Provide Service:-";
            // 
            // provideServiceTXT
            // 
            this.provideServiceTXT.BackColor = System.Drawing.SystemColors.Control;
            this.provideServiceTXT.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.provideServiceTXT.Location = new System.Drawing.Point(188, 575);
            this.provideServiceTXT.Margin = new System.Windows.Forms.Padding(4);
            this.provideServiceTXT.Multiline = true;
            this.provideServiceTXT.Name = "provideServiceTXT";
            this.provideServiceTXT.Size = new System.Drawing.Size(510, 28);
            this.provideServiceTXT.TabIndex = 335;
            // 
            // HCID
            // 
            this.HCID.DataPropertyName = "HCID";
            this.HCID.HeaderText = "HCID";
            this.HCID.MinimumWidth = 6;
            this.HCID.Name = "HCID";
            this.HCID.Width = 38;
            // 
            // CheckupName
            // 
            this.CheckupName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CheckupName.DataPropertyName = "CheckupName";
            this.CheckupName.HeaderText = "CheckupName";
            this.CheckupName.MinimumWidth = 6;
            this.CheckupName.Name = "CheckupName";
            // 
            // RegularPrice
            // 
            this.RegularPrice.DataPropertyName = "RegularPrice";
            this.RegularPrice.HeaderText = "RegularPrice";
            this.RegularPrice.MinimumWidth = 6;
            this.RegularPrice.Name = "RegularPrice";
            this.RegularPrice.Width = 50;
            // 
            // DiscountRate
            // 
            this.DiscountRate.DataPropertyName = "DiscountRate";
            this.DiscountRate.HeaderText = "DiscountRate";
            this.DiscountRate.MinimumWidth = 6;
            this.DiscountRate.Name = "DiscountRate";
            this.DiscountRate.Width = 30;
            // 
            // DiscountPrice
            // 
            this.DiscountPrice.DataPropertyName = "DiscountPrice";
            this.DiscountPrice.HeaderText = "DiscountPrice";
            this.DiscountPrice.MinimumWidth = 6;
            this.DiscountPrice.Name = "DiscountPrice";
            this.DiscountPrice.Width = 50;
            // 
            // ProvideService
            // 
            this.ProvideService.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProvideService.DataPropertyName = "ProvideService";
            this.ProvideService.HeaderText = "ProvideService";
            this.ProvideService.MinimumWidth = 6;
            this.ProvideService.Name = "ProvideService";
            // 
            // Update
            // 
            this.Update.HeaderText = "Update";
            this.Update.Image = ((System.Drawing.Image)(resources.GetObject("Update.Image")));
            this.Update.MinimumWidth = 6;
            this.Update.Name = "Update";
            this.Update.Width = 30;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.Image = ((System.Drawing.Image)(resources.GetObject("Delete.Image")));
            this.Delete.MinimumWidth = 6;
            this.Delete.Name = "Delete";
            this.Delete.Width = 30;
            // 
            // HospitalHealthCheckup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 653);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HospitalHealthCheckup";
            this.Text = "HospitalHealthCheckup";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button addBTN;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox SearchTXT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox provideServiceTXT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox healthCheckupNameTXT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox discountRateTXT;
        private System.Windows.Forms.TextBox regularPriceTXT;
        private System.Windows.Forms.Label sdfdsjf;
        private System.Windows.Forms.Label rgerge;
        private System.Windows.Forms.DataGridViewTextBoxColumn HCID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CheckupName;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegularPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiscountRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiscountPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProvideService;
        private System.Windows.Forms.DataGridViewImageColumn Update;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
    }
}