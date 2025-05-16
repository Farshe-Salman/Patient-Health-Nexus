namespace Patient_Health_Nexus.Code
{
    partial class Signup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Signup));
            this.panel1 = new System.Windows.Forms.Panel();
            this.back_BTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pharmacyBTN = new System.Windows.Forms.Button();
            this.hospitalBTN = new System.Windows.Forms.Button();
            this.patientBTN = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.back_BTN);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.pharmacyBTN);
            this.panel1.Controls.Add(this.hospitalBTN);
            this.panel1.Controls.Add(this.patientBTN);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(217, 653);
            this.panel1.TabIndex = 0;
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
            this.back_BTN.TabIndex = 42;
            this.back_BTN.UseVisualStyleBackColor = false;
            this.back_BTN.Click += new System.EventHandler(this.back_BTN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "User Type";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(184, 126);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // pharmacyBTN
            // 
            this.pharmacyBTN.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pharmacyBTN.Image = ((System.Drawing.Image)(resources.GetObject("pharmacyBTN.Image")));
            this.pharmacyBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pharmacyBTN.Location = new System.Drawing.Point(0, 281);
            this.pharmacyBTN.Name = "pharmacyBTN";
            this.pharmacyBTN.Size = new System.Drawing.Size(217, 43);
            this.pharmacyBTN.TabIndex = 2;
            this.pharmacyBTN.Text = "Pharmacy";
            this.pharmacyBTN.UseVisualStyleBackColor = true;
            this.pharmacyBTN.Click += new System.EventHandler(this.pharmacyBTN_Click);
            // 
            // hospitalBTN
            // 
            this.hospitalBTN.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hospitalBTN.Image = ((System.Drawing.Image)(resources.GetObject("hospitalBTN.Image")));
            this.hospitalBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.hospitalBTN.Location = new System.Drawing.Point(0, 232);
            this.hospitalBTN.Name = "hospitalBTN";
            this.hospitalBTN.Size = new System.Drawing.Size(217, 43);
            this.hospitalBTN.TabIndex = 1;
            this.hospitalBTN.Text = "Hosptal";
            this.hospitalBTN.UseVisualStyleBackColor = true;
            this.hospitalBTN.Click += new System.EventHandler(this.hospitalBTN_Click);
            // 
            // patientBTN
            // 
            this.patientBTN.BackColor = System.Drawing.Color.Transparent;
            this.patientBTN.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientBTN.Image = ((System.Drawing.Image)(resources.GetObject("patientBTN.Image")));
            this.patientBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.patientBTN.Location = new System.Drawing.Point(0, 183);
            this.patientBTN.Name = "patientBTN";
            this.patientBTN.Size = new System.Drawing.Size(217, 43);
            this.patientBTN.TabIndex = 0;
            this.patientBTN.Text = "Patient";
            this.patientBTN.UseVisualStyleBackColor = false;
            this.patientBTN.Click += new System.EventHandler(this.patientBTN_Click);
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(217, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(765, 653);
            this.panel3.TabIndex = 2;
            // 
            // Signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 653);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Signup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Signup";
            this.Load += new System.EventHandler(this.Signup_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button pharmacyBTN;
        private System.Windows.Forms.Button hospitalBTN;
        private System.Windows.Forms.Button patientBTN;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button back_BTN;
    }
}