namespace Patient_Health_Nexus.Code
{
    partial class DoctorListforPatient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoctorListforPatient));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DoctorListBTN = new System.Windows.Forms.Button();
            this.back_BTN = new System.Windows.Forms.Button();
            this.DrApBTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SlateBlue;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.DoctorListBTN);
            this.panel1.Controls.Add(this.back_BTN);
            this.panel1.Controls.Add(this.DrApBTN);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(197, 653);
            this.panel1.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(38, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(103, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 279;
            this.pictureBox1.TabStop = false;
            // 
            // DoctorListBTN
            // 
            this.DoctorListBTN.BackColor = System.Drawing.Color.Transparent;
            this.DoctorListBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DoctorListBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DoctorListBTN.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DoctorListBTN.Image = ((System.Drawing.Image)(resources.GetObject("DoctorListBTN.Image")));
            this.DoctorListBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DoctorListBTN.Location = new System.Drawing.Point(-3, 136);
            this.DoctorListBTN.Name = "DoctorListBTN";
            this.DoctorListBTN.Size = new System.Drawing.Size(200, 67);
            this.DoctorListBTN.TabIndex = 125;
            this.DoctorListBTN.Text = "   Doctor List";
            this.DoctorListBTN.UseVisualStyleBackColor = false;
            this.DoctorListBTN.Click += new System.EventHandler(this.DoctorListBTN_Click);
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
            // DrApBTN
            // 
            this.DrApBTN.BackColor = System.Drawing.Color.Transparent;
            this.DrApBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DrApBTN.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DrApBTN.Image = ((System.Drawing.Image)(resources.GetObject("DrApBTN.Image")));
            this.DrApBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DrApBTN.Location = new System.Drawing.Point(-3, 230);
            this.DrApBTN.Name = "DrApBTN";
            this.DrApBTN.Size = new System.Drawing.Size(200, 70);
            this.DrApBTN.TabIndex = 122;
            this.DrApBTN.Text = "Doctor Appointment";
            this.DrApBTN.UseVisualStyleBackColor = false;
            this.DrApBTN.Click += new System.EventHandler(this.DrApBTN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "Service Type";
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(197, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(785, 653);
            this.panel2.TabIndex = 7;
            // 
            // DoctorListforPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 653);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DoctorListforPatient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DoctorListforPatient";
            this.Load += new System.EventHandler(this.DoctorListforPatient_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button DoctorListBTN;
        private System.Windows.Forms.Button back_BTN;
        private System.Windows.Forms.Button DrApBTN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}