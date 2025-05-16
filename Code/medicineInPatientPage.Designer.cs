namespace Patient_Health_Nexus.Code
{
    partial class medicineInPatientPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(medicineInPatientPage));
            this.SearchTXT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MedicineName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Strength = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DosageForm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityInStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PharmacyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Details = new System.Windows.Forms.DataGridViewImageColumn();
            this.AddToCart = new System.Windows.Forms.DataGridViewImageColumn();
            this.MedicineID = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchTXT
            // 
            this.SearchTXT.BackColor = System.Drawing.SystemColors.Control;
            this.SearchTXT.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchTXT.Location = new System.Drawing.Point(205, 118);
            this.SearchTXT.Margin = new System.Windows.Forms.Padding(4);
            this.SearchTXT.Multiline = true;
            this.SearchTXT.Name = "SearchTXT";
            this.SearchTXT.Size = new System.Drawing.Size(361, 32);
            this.SearchTXT.TabIndex = 295;
            this.SearchTXT.TextChanged += new System.EventHandler(this.SearchTXT_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(255, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(222, 29);
            this.label2.TabIndex = 294;
            this.label2.Text = "Medichine Details";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MedicineName,
            this.Strength,
            this.DosageForm,
            this.QuantityInStock,
            this.Price,
            this.PharmacyName,
            this.Quantity,
            this.Details,
            this.AddToCart,
            this.MedicineID});
            this.dataGridView1.Location = new System.Drawing.Point(-3, 171);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(758, 481);
            this.dataGridView1.TabIndex = 297;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Details";
            this.dataGridViewImageColumn1.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn1.Image")));
            this.dataGridViewImageColumn1.MinimumWidth = 6;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 50;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "Add TO Cart";
            this.dataGridViewImageColumn2.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn2.Image")));
            this.dataGridViewImageColumn2.MinimumWidth = 6;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Width = 50;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(166, 118);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 296;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-3, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(758, 83);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 293;
            this.pictureBox1.TabStop = false;
            // 
            // MedicineName
            // 
            this.MedicineName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.MedicineName.DataPropertyName = "MedicineName";
            this.MedicineName.Frozen = true;
            this.MedicineName.HeaderText = "Name";
            this.MedicineName.MinimumWidth = 6;
            this.MedicineName.Name = "MedicineName";
            this.MedicineName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.MedicineName.Width = 85;
            // 
            // Strength
            // 
            this.Strength.DataPropertyName = "Strength";
            this.Strength.Frozen = true;
            this.Strength.HeaderText = "Strength";
            this.Strength.MinimumWidth = 6;
            this.Strength.Name = "Strength";
            this.Strength.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Strength.Width = 60;
            // 
            // DosageForm
            // 
            this.DosageForm.DataPropertyName = "DosageForm";
            this.DosageForm.Frozen = true;
            this.DosageForm.HeaderText = "DosageForm";
            this.DosageForm.MinimumWidth = 6;
            this.DosageForm.Name = "DosageForm";
            this.DosageForm.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.DosageForm.Width = 70;
            // 
            // QuantityInStock
            // 
            this.QuantityInStock.DataPropertyName = "QuantityInStock";
            this.QuantityInStock.Frozen = true;
            this.QuantityInStock.HeaderText = "Stock";
            this.QuantityInStock.MinimumWidth = 6;
            this.QuantityInStock.Name = "QuantityInStock";
            this.QuantityInStock.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.QuantityInStock.Width = 40;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.Frozen = true;
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Price.Width = 40;
            // 
            // PharmacyName
            // 
            this.PharmacyName.DataPropertyName = "PharmacyName";
            this.PharmacyName.HeaderText = "Pharmacy Name";
            this.PharmacyName.MinimumWidth = 6;
            this.PharmacyName.Name = "PharmacyName";
            this.PharmacyName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.PharmacyName.Width = 70;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.MinimumWidth = 6;
            this.Quantity.Name = "Quantity";
            this.Quantity.Width = 50;
            // 
            // Details
            // 
            this.Details.HeaderText = "Details";
            this.Details.Image = ((System.Drawing.Image)(resources.GetObject("Details.Image")));
            this.Details.MinimumWidth = 6;
            this.Details.Name = "Details";
            this.Details.Width = 50;
            // 
            // AddToCart
            // 
            this.AddToCart.HeaderText = "Add TO Cart";
            this.AddToCart.Image = ((System.Drawing.Image)(resources.GetObject("AddToCart.Image")));
            this.AddToCart.MinimumWidth = 6;
            this.AddToCart.Name = "AddToCart";
            this.AddToCart.Width = 50;
            // 
            // MedicineID
            // 
            this.MedicineID.DataPropertyName = "MedicineID";
            this.MedicineID.HeaderText = "ID";
            this.MedicineID.MinimumWidth = 6;
            this.MedicineID.Name = "MedicineID";
            this.MedicineID.Width = 6;
            // 
            // medicineInPatientPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 653);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.SearchTXT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "medicineInPatientPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "medicineInPatientPage";
            this.Load += new System.EventHandler(this.medicineInPatientPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox SearchTXT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn MedicineName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Strength;
        private System.Windows.Forms.DataGridViewTextBoxColumn DosageForm;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityInStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn PharmacyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewImageColumn Details;
        private System.Windows.Forms.DataGridViewImageColumn AddToCart;
        private System.Windows.Forms.DataGridViewImageColumn MedicineID;
    }
}