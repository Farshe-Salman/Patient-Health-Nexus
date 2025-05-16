namespace Patient_Health_Nexus
{
    partial class PatientMainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientMainPage));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.back_BTN = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.addToCartBTN = new System.Windows.Forms.Button();
            this.medicineCartBTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(982, 653);
            this.panel2.TabIndex = 48;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Location = new System.Drawing.Point(227, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(755, 650);
            this.panel3.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 74);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(755, 576);
            this.dataGridView1.TabIndex = 330;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(263, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(234, 43);
            this.button1.TabIndex = 329;
            this.button1.Text = "  Order History";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SlateBlue;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.back_BTN);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.addToCartBTN);
            this.panel1.Controls.Add(this.medicineCartBTN);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(231, 653);
            this.panel1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(42, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(156, 118);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 279;
            this.pictureBox1.TabStop = false;
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
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(-3, 310);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(234, 43);
            this.button2.TabIndex = 122;
            this.button2.Text = "  Order History";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // addToCartBTN
            // 
            this.addToCartBTN.BackColor = System.Drawing.Color.Transparent;
            this.addToCartBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addToCartBTN.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addToCartBTN.Image = ((System.Drawing.Image)(resources.GetObject("addToCartBTN.Image")));
            this.addToCartBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addToCartBTN.Location = new System.Drawing.Point(-3, 241);
            this.addToCartBTN.Name = "addToCartBTN";
            this.addToCartBTN.Size = new System.Drawing.Size(234, 43);
            this.addToCartBTN.TabIndex = 10;
            this.addToCartBTN.Text = "Add to cart";
            this.addToCartBTN.UseVisualStyleBackColor = false;
            this.addToCartBTN.Click += new System.EventHandler(this.addToCartBTN_Click);
            // 
            // medicineCartBTN
            // 
            this.medicineCartBTN.BackColor = System.Drawing.Color.Transparent;
            this.medicineCartBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.medicineCartBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.medicineCartBTN.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medicineCartBTN.Image = ((System.Drawing.Image)(resources.GetObject("medicineCartBTN.Image")));
            this.medicineCartBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.medicineCartBTN.Location = new System.Drawing.Point(0, 174);
            this.medicineCartBTN.Name = "medicineCartBTN";
            this.medicineCartBTN.Size = new System.Drawing.Size(231, 43);
            this.medicineCartBTN.TabIndex = 9;
            this.medicineCartBTN.Text = "Medicine";
            this.medicineCartBTN.UseVisualStyleBackColor = false;
            this.medicineCartBTN.Click += new System.EventHandler(this.medicineCartBTN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "Select Option";
            // 
            // PatientMainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(982, 653);
            this.Controls.Add(this.panel2);
            this.Name = "PatientMainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PatientMainPage";
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button addToCartBTN;
        private System.Windows.Forms.Button medicineCartBTN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button back_BTN;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
    }
}