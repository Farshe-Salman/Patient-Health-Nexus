namespace Patient_Health_Nexus.Code
{
    partial class OrderHistoryForAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderHistoryForAdmin));
            this.label1 = new System.Windows.Forms.Label();
            this.SearchTXT = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.OrderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MedicineName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeleveryFromPharmacy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReceivedByWearhouse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeleveryFromWearHouse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Details = new System.Windows.Forms.DataGridViewImageColumn();
            this.ReceivedFromPharmacy = new System.Windows.Forms.DataGridViewImageColumn();
            this.DeliveryDone = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.back_BTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(246, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(524, 54);
            this.label1.TabIndex = 1;
            this.label1.Text = "Medicine Order History";
            // 
            // SearchTXT
            // 
            this.SearchTXT.BackColor = System.Drawing.SystemColors.Control;
            this.SearchTXT.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchTXT.Location = new System.Drawing.Point(345, 97);
            this.SearchTXT.Margin = new System.Windows.Forms.Padding(4);
            this.SearchTXT.Multiline = true;
            this.SearchTXT.Name = "SearchTXT";
            this.SearchTXT.Size = new System.Drawing.Size(361, 32);
            this.SearchTXT.TabIndex = 300;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(308, 96);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 301;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -66);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(983, 156);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OrderID,
            this.MedicineName,
            this.Quantity,
            this.TotalPrice,
            this.DeleveryFromPharmacy,
            this.ReceivedByWearhouse,
            this.DeleveryFromWearHouse,
            this.Details,
            this.ReceivedFromPharmacy,
            this.DeliveryDone,
            this.Delete});
            this.dataGridView1.Location = new System.Drawing.Point(0, 136);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(983, 520);
            this.dataGridView1.TabIndex = 302;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // OrderID
            // 
            this.OrderID.DataPropertyName = "OrderID";
            this.OrderID.HeaderText = "OrderID";
            this.OrderID.MinimumWidth = 6;
            this.OrderID.Name = "OrderID";
            this.OrderID.Width = 40;
            // 
            // MedicineName
            // 
            this.MedicineName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MedicineName.DataPropertyName = "MedicineName";
            this.MedicineName.HeaderText = "Medicine Name";
            this.MedicineName.MinimumWidth = 6;
            this.MedicineName.Name = "MedicineName";
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.MinimumWidth = 6;
            this.Quantity.Name = "Quantity";
            this.Quantity.Width = 40;
            // 
            // TotalPrice
            // 
            this.TotalPrice.DataPropertyName = "TotalPrice";
            this.TotalPrice.HeaderText = "Total Price";
            this.TotalPrice.MinimumWidth = 6;
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.Width = 40;
            // 
            // DeleveryFromPharmacy
            // 
            this.DeleveryFromPharmacy.DataPropertyName = "DeleveryFromPharmacy";
            this.DeleveryFromPharmacy.HeaderText = "Delevery From Pharmacy";
            this.DeleveryFromPharmacy.MinimumWidth = 6;
            this.DeleveryFromPharmacy.Name = "DeleveryFromPharmacy";
            this.DeleveryFromPharmacy.Width = 80;
            // 
            // ReceivedByWearhouse
            // 
            this.ReceivedByWearhouse.DataPropertyName = "ReceivedByWearhouse";
            this.ReceivedByWearhouse.HeaderText = "Received ByWearhouse";
            this.ReceivedByWearhouse.MinimumWidth = 6;
            this.ReceivedByWearhouse.Name = "ReceivedByWearhouse";
            this.ReceivedByWearhouse.Width = 70;
            // 
            // DeleveryFromWearHouse
            // 
            this.DeleveryFromWearHouse.DataPropertyName = "DeleveryFromWearHouse";
            this.DeleveryFromWearHouse.HeaderText = "Delevery From WearHouse";
            this.DeleveryFromWearHouse.MinimumWidth = 6;
            this.DeleveryFromWearHouse.Name = "DeleveryFromWearHouse";
            this.DeleveryFromWearHouse.Width = 70;
            // 
            // Details
            // 
            this.Details.HeaderText = "Details";
            this.Details.Image = ((System.Drawing.Image)(resources.GetObject("Details.Image")));
            this.Details.MinimumWidth = 6;
            this.Details.Name = "Details";
            this.Details.Width = 50;
            // 
            // ReceivedFromPharmacy
            // 
            this.ReceivedFromPharmacy.HeaderText = "Received From Pharmacy";
            this.ReceivedFromPharmacy.Image = ((System.Drawing.Image)(resources.GetObject("ReceivedFromPharmacy.Image")));
            this.ReceivedFromPharmacy.MinimumWidth = 6;
            this.ReceivedFromPharmacy.Name = "ReceivedFromPharmacy";
            this.ReceivedFromPharmacy.Width = 70;
            // 
            // DeliveryDone
            // 
            this.DeliveryDone.HeaderText = "Delivery Done";
            this.DeliveryDone.Image = ((System.Drawing.Image)(resources.GetObject("DeliveryDone.Image")));
            this.DeliveryDone.MinimumWidth = 6;
            this.DeliveryDone.Name = "DeliveryDone";
            this.DeliveryDone.Width = 70;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.Image = ((System.Drawing.Image)(resources.GetObject("Delete.Image")));
            this.Delete.MinimumWidth = 6;
            this.Delete.Name = "Delete";
            this.Delete.Width = 40;
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
            this.back_BTN.Location = new System.Drawing.Point(0, -5);
            this.back_BTN.Margin = new System.Windows.Forms.Padding(4);
            this.back_BTN.Name = "back_BTN";
            this.back_BTN.Size = new System.Drawing.Size(47, 47);
            this.back_BTN.TabIndex = 303;
            this.back_BTN.UseVisualStyleBackColor = false;
            this.back_BTN.Click += new System.EventHandler(this.back_BTN_Click);
            // 
            // OrderHistoryForAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 653);
            this.Controls.Add(this.back_BTN);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.SearchTXT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OrderHistoryForAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrderHistoryForAdmin";
            this.Load += new System.EventHandler(this.OrderHistoryForAdmin_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox SearchTXT;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MedicineName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeleveryFromPharmacy;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReceivedByWearhouse;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeleveryFromWearHouse;
        private System.Windows.Forms.DataGridViewImageColumn Details;
        private System.Windows.Forms.DataGridViewImageColumn ReceivedFromPharmacy;
        private System.Windows.Forms.DataGridViewImageColumn DeliveryDone;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
        private System.Windows.Forms.Button back_BTN;
    }
}