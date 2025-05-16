namespace Patient_Health_Nexus.Code
{
    partial class HospitalServices
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HospitalServices));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DSID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServiceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RegularPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiscountRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiscountPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Update = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.diagnosticeServiceNameTXT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.addBTN = new System.Windows.Forms.Button();
            this.discountRateTXT = new System.Windows.Forms.TextBox();
            this.regularPriceTXT = new System.Windows.Forms.TextBox();
            this.sdfdsjf = new System.Windows.Forms.Label();
            this.rgerge = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.SearchTXT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.back_BTN = new System.Windows.Forms.Button();
            this.surgeryPackagesBTN = new System.Windows.Forms.Button();
            this.DiagonsticServiceBTN = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.diagnosticeServiceNameTXT);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.addBTN);
            this.panel2.Controls.Add(this.discountRateTXT);
            this.panel2.Controls.Add(this.regularPriceTXT);
            this.panel2.Controls.Add(this.sdfdsjf);
            this.panel2.Controls.Add(this.rgerge);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.SearchTXT);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(224, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(757, 653);
            this.panel2.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(757, 653);
            this.panel3.TabIndex = 327;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DSID,
            this.ServiceName,
            this.RegularPrice,
            this.DiscountRate,
            this.DiscountPrice,
            this.Update,
            this.Delete});
            this.dataGridView1.Location = new System.Drawing.Point(0, 81);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(757, 390);
            this.dataGridView1.TabIndex = 326;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // DSID
            // 
            this.DSID.DataPropertyName = "DSID";
            this.DSID.HeaderText = "DID";
            this.DSID.MinimumWidth = 6;
            this.DSID.Name = "DSID";
            this.DSID.Width = 70;
            // 
            // ServiceName
            // 
            this.ServiceName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ServiceName.DataPropertyName = "Name";
            this.ServiceName.HeaderText = "ServiceName";
            this.ServiceName.MinimumWidth = 6;
            this.ServiceName.Name = "ServiceName";
            // 
            // RegularPrice
            // 
            this.RegularPrice.DataPropertyName = "RegularPrice";
            this.RegularPrice.HeaderText = "RegularPrice";
            this.RegularPrice.MinimumWidth = 6;
            this.RegularPrice.Name = "RegularPrice";
            this.RegularPrice.Width = 70;
            // 
            // DiscountRate
            // 
            this.DiscountRate.DataPropertyName = "DiscountRate";
            this.DiscountRate.HeaderText = "DiscountRate";
            this.DiscountRate.MinimumWidth = 6;
            this.DiscountRate.Name = "DiscountRate";
            this.DiscountRate.Width = 70;
            // 
            // DiscountPrice
            // 
            this.DiscountPrice.DataPropertyName = "DiscountPrice";
            this.DiscountPrice.HeaderText = "DiscountPrice";
            this.DiscountPrice.MinimumWidth = 6;
            this.DiscountPrice.Name = "DiscountPrice";
            this.DiscountPrice.Width = 70;
            // 
            // Update
            // 
            this.Update.HeaderText = "Update";
            this.Update.Image = ((System.Drawing.Image)(resources.GetObject("Update.Image")));
            this.Update.MinimumWidth = 6;
            this.Update.Name = "Update";
            this.Update.Width = 70;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.Image = ((System.Drawing.Image)(resources.GetObject("Delete.Image")));
            this.Delete.MinimumWidth = 6;
            this.Delete.Name = "Delete";
            this.Delete.Width = 70;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.label5.Location = new System.Drawing.Point(374, 595);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 23);
            this.label5.TabIndex = 325;
            this.label5.Text = "%";
            // 
            // diagnosticeServiceNameTXT
            // 
            this.diagnosticeServiceNameTXT.BackColor = System.Drawing.SystemColors.Control;
            this.diagnosticeServiceNameTXT.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diagnosticeServiceNameTXT.Location = new System.Drawing.Point(173, 517);
            this.diagnosticeServiceNameTXT.Margin = new System.Windows.Forms.Padding(4);
            this.diagnosticeServiceNameTXT.Multiline = true;
            this.diagnosticeServiceNameTXT.Name = "diagnosticeServiceNameTXT";
            this.diagnosticeServiceNameTXT.Size = new System.Drawing.Size(363, 28);
            this.diagnosticeServiceNameTXT.TabIndex = 324;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.label4.Location = new System.Drawing.Point(64, 522);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 23);
            this.label4.TabIndex = 323;
            this.label4.Text = "Name:-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 474);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(313, 29);
            this.label3.TabIndex = 322;
            this.label3.Text = "Add Diagnostic Services:-";
            // 
            // addBTN
            // 
            this.addBTN.BackColor = System.Drawing.Color.Transparent;
            this.addBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBTN.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBTN.Image = ((System.Drawing.Image)(resources.GetObject("addBTN.Image")));
            this.addBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addBTN.Location = new System.Drawing.Point(580, 545);
            this.addBTN.Name = "addBTN";
            this.addBTN.Size = new System.Drawing.Size(158, 43);
            this.addBTN.TabIndex = 321;
            this.addBTN.Text = "ADD";
            this.addBTN.UseVisualStyleBackColor = false;
            this.addBTN.Click += new System.EventHandler(this.addBTN_Click);
            // 
            // discountRateTXT
            // 
            this.discountRateTXT.BackColor = System.Drawing.SystemColors.Control;
            this.discountRateTXT.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discountRateTXT.Location = new System.Drawing.Point(237, 596);
            this.discountRateTXT.Margin = new System.Windows.Forms.Padding(4);
            this.discountRateTXT.Multiline = true;
            this.discountRateTXT.Name = "discountRateTXT";
            this.discountRateTXT.Size = new System.Drawing.Size(129, 28);
            this.discountRateTXT.TabIndex = 320;
            // 
            // regularPriceTXT
            // 
            this.regularPriceTXT.BackColor = System.Drawing.SystemColors.Control;
            this.regularPriceTXT.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regularPriceTXT.Location = new System.Drawing.Point(237, 553);
            this.regularPriceTXT.Margin = new System.Windows.Forms.Padding(4);
            this.regularPriceTXT.Multiline = true;
            this.regularPriceTXT.Name = "regularPriceTXT";
            this.regularPriceTXT.Size = new System.Drawing.Size(299, 28);
            this.regularPriceTXT.TabIndex = 319;
            // 
            // sdfdsjf
            // 
            this.sdfdsjf.AutoSize = true;
            this.sdfdsjf.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sdfdsjf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.sdfdsjf.Location = new System.Drawing.Point(64, 601);
            this.sdfdsjf.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sdfdsjf.Name = "sdfdsjf";
            this.sdfdsjf.Size = new System.Drawing.Size(149, 23);
            this.sdfdsjf.TabIndex = 318;
            this.sdfdsjf.Text = "Discount Rate:-";
            // 
            // rgerge
            // 
            this.rgerge.AutoSize = true;
            this.rgerge.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rgerge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.rgerge.Location = new System.Drawing.Point(64, 565);
            this.rgerge.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.rgerge.Name = "rgerge";
            this.rgerge.Size = new System.Drawing.Size(146, 23);
            this.rgerge.TabIndex = 317;
            this.rgerge.Text = "Regular Price:-";
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
            this.label2.Location = new System.Drawing.Point(277, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(244, 29);
            this.label2.TabIndex = 300;
            this.label2.Text = "Diagnostic Services";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Update";
            this.dataGridViewImageColumn1.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn1.Image")));
            this.dataGridViewImageColumn1.MinimumWidth = 6;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 70;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "Delete";
            this.dataGridViewImageColumn2.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn2.Image")));
            this.dataGridViewImageColumn2.MinimumWidth = 6;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Width = 70;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "Service Type";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(-3, 354);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(231, 70);
            this.button2.TabIndex = 122;
            this.button2.Text = "    Health Check Packages";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // back_BTN
            // 
            this.back_BTN.BackColor = System.Drawing.Color.Transparent;
            this.back_BTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back_BTN.FlatAppearance.BorderSize = 0;
            this.back_BTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.back_BTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.back_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back_BTN.Image = ((System.Drawing.Image)(resources.GetObject("back_BTN.Image")));
            this.back_BTN.Location = new System.Drawing.Point(0, 0);
            this.back_BTN.Margin = new System.Windows.Forms.Padding(4);
            this.back_BTN.Name = "back_BTN";
            this.back_BTN.Size = new System.Drawing.Size(47, 47);
            this.back_BTN.TabIndex = 123;
            this.back_BTN.UseVisualStyleBackColor = false;
            this.back_BTN.Click += new System.EventHandler(this.back_BTN_Click);
            // 
            // surgeryPackagesBTN
            // 
            this.surgeryPackagesBTN.BackColor = System.Drawing.Color.Transparent;
            this.surgeryPackagesBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.surgeryPackagesBTN.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surgeryPackagesBTN.Image = ((System.Drawing.Image)(resources.GetObject("surgeryPackagesBTN.Image")));
            this.surgeryPackagesBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.surgeryPackagesBTN.Location = new System.Drawing.Point(-3, 250);
            this.surgeryPackagesBTN.Name = "surgeryPackagesBTN";
            this.surgeryPackagesBTN.Size = new System.Drawing.Size(228, 69);
            this.surgeryPackagesBTN.TabIndex = 124;
            this.surgeryPackagesBTN.Text = "   Surgery Packages";
            this.surgeryPackagesBTN.UseVisualStyleBackColor = false;
            this.surgeryPackagesBTN.Click += new System.EventHandler(this.surgeryPackagesBTN_Click);
            // 
            // DiagonsticServiceBTN
            // 
            this.DiagonsticServiceBTN.BackColor = System.Drawing.Color.Transparent;
            this.DiagonsticServiceBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DiagonsticServiceBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DiagonsticServiceBTN.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiagonsticServiceBTN.Image = ((System.Drawing.Image)(resources.GetObject("DiagonsticServiceBTN.Image")));
            this.DiagonsticServiceBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DiagonsticServiceBTN.Location = new System.Drawing.Point(-3, 153);
            this.DiagonsticServiceBTN.Name = "DiagonsticServiceBTN";
            this.DiagonsticServiceBTN.Size = new System.Drawing.Size(228, 67);
            this.DiagonsticServiceBTN.TabIndex = 125;
            this.DiagonsticServiceBTN.Text = "Diagnostic Services";
            this.DiagonsticServiceBTN.UseVisualStyleBackColor = false;
            this.DiagonsticServiceBTN.Click += new System.EventHandler(this.DiagonsticServiceBTN_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(36, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(156, 118);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 279;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SlateBlue;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.DiagonsticServiceBTN);
            this.panel1.Controls.Add(this.surgeryPackagesBTN);
            this.panel1.Controls.Add(this.back_BTN);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(231, 653);
            this.panel1.TabIndex = 4;
            // 
            // HospitalServices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 653);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "HospitalServices";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HospitalServices";
            this.Activated += new System.EventHandler(this.HospitalServices_Activated);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox SearchTXT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox diagnosticeServiceNameTXT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button addBTN;
        private System.Windows.Forms.TextBox discountRateTXT;
        private System.Windows.Forms.TextBox regularPriceTXT;
        private System.Windows.Forms.Label sdfdsjf;
        private System.Windows.Forms.Label rgerge;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DSID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServiceName;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegularPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiscountRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiscountPrice;
        private System.Windows.Forms.DataGridViewImageColumn Update;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button back_BTN;
        private System.Windows.Forms.Button surgeryPackagesBTN;
        private System.Windows.Forms.Button DiagonsticServiceBTN;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
    }
}