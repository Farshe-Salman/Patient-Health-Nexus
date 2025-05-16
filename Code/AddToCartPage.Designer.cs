namespace Patient_Health_Nexus.Code
{
    partial class AddToCartPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddToCartPage));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MedicineName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CartID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityInStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Add = new System.Windows.Forms.DataGridViewImageColumn();
            this.Subtruct = new System.Windows.Forms.DataGridViewImageColumn();
            this.Remove = new System.Windows.Forms.DataGridViewImageColumn();
            this.labelforFullPrice = new System.Windows.Forms.Label();
            this.proceedBTN = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.divisionCB = new System.Windows.Forms.ComboBox();
            this.cityTXT = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.phNumberTXT = new System.Windows.Forms.TextBox();
            this.ShippingAddTXT = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(754, 81);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.Location = new System.Drawing.Point(349, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 54);
            this.label1.TabIndex = 296;
            this.label1.Text = "Cart";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(225, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 51);
            this.label2.TabIndex = 295;
            this.label2.Text = "Your";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MedicineName,
            this.CartID,
            this.Price,
            this.QuantityInStock,
            this.Quantity,
            this.TotalPrice,
            this.Add,
            this.Subtruct,
            this.Remove});
            this.dataGridView1.Location = new System.Drawing.Point(0, 78);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(754, 324);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // MedicineName
            // 
            this.MedicineName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MedicineName.DataPropertyName = "MedicineName";
            this.MedicineName.HeaderText = "Medicine";
            this.MedicineName.MinimumWidth = 6;
            this.MedicineName.Name = "MedicineName";
            // 
            // CartID
            // 
            this.CartID.DataPropertyName = "CartID";
            this.CartID.HeaderText = "CartID";
            this.CartID.MinimumWidth = 6;
            this.CartID.Name = "CartID";
            this.CartID.Width = 50;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.Width = 50;
            // 
            // QuantityInStock
            // 
            this.QuantityInStock.DataPropertyName = "QuantityInStock";
            this.QuantityInStock.HeaderText = "Quantity In Stock";
            this.QuantityInStock.MinimumWidth = 6;
            this.QuantityInStock.Name = "QuantityInStock";
            this.QuantityInStock.Width = 50;
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.MinimumWidth = 6;
            this.Quantity.Name = "Quantity";
            this.Quantity.Width = 50;
            // 
            // TotalPrice
            // 
            this.TotalPrice.HeaderText = "Total Price";
            this.TotalPrice.MinimumWidth = 6;
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.Width = 50;
            // 
            // Add
            // 
            this.Add.HeaderText = "    +";
            this.Add.Image = ((System.Drawing.Image)(resources.GetObject("Add.Image")));
            this.Add.MinimumWidth = 6;
            this.Add.Name = "Add";
            this.Add.Width = 50;
            // 
            // Subtruct
            // 
            this.Subtruct.HeaderText = "    -";
            this.Subtruct.Image = ((System.Drawing.Image)(resources.GetObject("Subtruct.Image")));
            this.Subtruct.MinimumWidth = 6;
            this.Subtruct.Name = "Subtruct";
            this.Subtruct.Width = 50;
            // 
            // Remove
            // 
            this.Remove.HeaderText = "Remove";
            this.Remove.Image = ((System.Drawing.Image)(resources.GetObject("Remove.Image")));
            this.Remove.MinimumWidth = 6;
            this.Remove.Name = "Remove";
            this.Remove.Width = 50;
            // 
            // labelforFullPrice
            // 
            this.labelforFullPrice.AutoSize = true;
            this.labelforFullPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelforFullPrice.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelforFullPrice.Location = new System.Drawing.Point(164, 435);
            this.labelforFullPrice.Name = "labelforFullPrice";
            this.labelforFullPrice.Size = new System.Drawing.Size(127, 27);
            this.labelforFullPrice.TabIndex = 2;
            this.labelforFullPrice.Text = "Details View";
            this.labelforFullPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // proceedBTN
            // 
            this.proceedBTN.BackColor = System.Drawing.Color.Gray;
            this.proceedBTN.FlatAppearance.BorderSize = 0;
            this.proceedBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.proceedBTN.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proceedBTN.ForeColor = System.Drawing.Color.Snow;
            this.proceedBTN.Image = ((System.Drawing.Image)(resources.GetObject("proceedBTN.Image")));
            this.proceedBTN.Location = new System.Drawing.Point(254, 581);
            this.proceedBTN.Margin = new System.Windows.Forms.Padding(4);
            this.proceedBTN.Name = "proceedBTN";
            this.proceedBTN.Size = new System.Drawing.Size(228, 55);
            this.proceedBTN.TabIndex = 48;
            this.proceedBTN.Text = "Proceed To buy";
            this.proceedBTN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.proceedBTN.UseVisualStyleBackColor = false;
            this.proceedBTN.Click += new System.EventHandler(this.proceedBTN_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.radioButton2);
            this.panel2.Controls.Add(this.radioButton1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.divisionCB);
            this.panel2.Controls.Add(this.cityTXT);
            this.panel2.Controls.Add(this.textBox3);
            this.panel2.Controls.Add(this.phNumberTXT);
            this.panel2.Controls.Add(this.ShippingAddTXT);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(127, 9);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(486, 643);
            this.panel2.TabIndex = 49;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(375, 538);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(77, 20);
            this.radioButton2.TabIndex = 9;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Banking";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(231, 537);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(132, 20);
            this.radioButton1.TabIndex = 8;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Cash On Delivery";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 535);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 22);
            this.label3.TabIndex = 7;
            this.label3.Text = "How do you like to pay:-";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(157, 586);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 41);
            this.button1.TabIndex = 6;
            this.button1.Text = "Buy Now";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // divisionCB
            // 
            this.divisionCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divisionCB.FormattingEnabled = true;
            this.divisionCB.Items.AddRange(new object[] {
            "DHAKA",
            "KHULNA",
            "RAJSHAI",
            "RANGPUR",
            "SYLHET",
            "CHITTAGONG",
            "MOYMONSINGH",
            "BARISHAL"});
            this.divisionCB.Location = new System.Drawing.Point(62, 390);
            this.divisionCB.Name = "divisionCB";
            this.divisionCB.Size = new System.Drawing.Size(352, 33);
            this.divisionCB.TabIndex = 5;
            // 
            // cityTXT
            // 
            this.cityTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityTXT.Location = new System.Drawing.Point(252, 307);
            this.cityTXT.Name = "cityTXT";
            this.cityTXT.Size = new System.Drawing.Size(162, 30);
            this.cityTXT.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(62, 307);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(153, 30);
            this.textBox3.TabIndex = 3;
            // 
            // phNumberTXT
            // 
            this.phNumberTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phNumberTXT.Location = new System.Drawing.Point(62, 482);
            this.phNumberTXT.Name = "phNumberTXT";
            this.phNumberTXT.Size = new System.Drawing.Size(352, 30);
            this.phNumberTXT.TabIndex = 2;
            // 
            // ShippingAddTXT
            // 
            this.ShippingAddTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShippingAddTXT.Location = new System.Drawing.Point(62, 208);
            this.ShippingAddTXT.Name = "ShippingAddTXT";
            this.ShippingAddTXT.Size = new System.Drawing.Size(352, 30);
            this.ShippingAddTXT.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, -9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(483, 649);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // AddToCartPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 653);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.proceedBTN);
            this.Controls.Add(this.labelforFullPrice);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddToCartPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddToCartPage";
            this.Load += new System.EventHandler(this.AddToCartPage_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelforFullPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn MedicineName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CartID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityInStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPrice;
        private System.Windows.Forms.DataGridViewImageColumn Add;
        private System.Windows.Forms.DataGridViewImageColumn Subtruct;
        private System.Windows.Forms.DataGridViewImageColumn Remove;
        private System.Windows.Forms.Button proceedBTN;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox phNumberTXT;
        private System.Windows.Forms.TextBox ShippingAddTXT;
        private System.Windows.Forms.ComboBox divisionCB;
        private System.Windows.Forms.TextBox cityTXT;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}