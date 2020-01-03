namespace MainForm
{
    partial class mainForm
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
            this.adminB = new System.Windows.Forms.Button();
            this.doctorB = new System.Windows.Forms.Button();
            this.nurseB = new System.Windows.Forms.Button();
            this.internB = new System.Windows.Forms.Button();
            this.pharmacistB = new System.Windows.Forms.Button();
            this.patientB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // adminB
            // 
            this.adminB.Location = new System.Drawing.Point(63, 28);
            this.adminB.Name = "adminB";
            this.adminB.Size = new System.Drawing.Size(180, 30);
            this.adminB.TabIndex = 0;
            this.adminB.Text = "Admin";
            this.adminB.UseVisualStyleBackColor = true;
            this.adminB.Click += new System.EventHandler(this.adminB_Click);
            // 
            // doctorB
            // 
            this.doctorB.Location = new System.Drawing.Point(63, 64);
            this.doctorB.Name = "doctorB";
            this.doctorB.Size = new System.Drawing.Size(180, 30);
            this.doctorB.TabIndex = 1;
            this.doctorB.Text = "Doctor";
            this.doctorB.UseVisualStyleBackColor = true;
            this.doctorB.Click += new System.EventHandler(this.doctorB_Click);
            // 
            // nurseB
            // 
            this.nurseB.Location = new System.Drawing.Point(63, 101);
            this.nurseB.Name = "nurseB";
            this.nurseB.Size = new System.Drawing.Size(180, 30);
            this.nurseB.TabIndex = 2;
            this.nurseB.Text = "Nurse";
            this.nurseB.UseVisualStyleBackColor = true;
            this.nurseB.Click += new System.EventHandler(this.nurseB_Click);
            // 
            // internB
            // 
            this.internB.Location = new System.Drawing.Point(63, 138);
            this.internB.Name = "internB";
            this.internB.Size = new System.Drawing.Size(180, 30);
            this.internB.TabIndex = 3;
            this.internB.Text = "Intern";
            this.internB.UseVisualStyleBackColor = true;
            this.internB.Click += new System.EventHandler(this.internB_Click);
            // 
            // pharmacistB
            // 
            this.pharmacistB.Location = new System.Drawing.Point(63, 175);
            this.pharmacistB.Name = "pharmacistB";
            this.pharmacistB.Size = new System.Drawing.Size(180, 30);
            this.pharmacistB.TabIndex = 4;
            this.pharmacistB.Text = "Pharmacist";
            this.pharmacistB.UseVisualStyleBackColor = true;
            this.pharmacistB.Click += new System.EventHandler(this.pharmacistB_Click);
            // 
            // patientB
            // 
            this.patientB.Location = new System.Drawing.Point(63, 212);
            this.patientB.Name = "patientB";
            this.patientB.Size = new System.Drawing.Size(180, 30);
            this.patientB.TabIndex = 5;
            this.patientB.Text = "Patient";
            this.patientB.UseVisualStyleBackColor = true;
            this.patientB.Click += new System.EventHandler(this.patientB_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 275);
            this.Controls.Add(this.patientB);
            this.Controls.Add(this.pharmacistB);
            this.Controls.Add(this.internB);
            this.Controls.Add(this.nurseB);
            this.Controls.Add(this.doctorB);
            this.Controls.Add(this.adminB);
            this.Name = "mainForm";
            this.Text = "Hospital";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button adminB;
        private System.Windows.Forms.Button doctorB;
        private System.Windows.Forms.Button nurseB;
        private System.Windows.Forms.Button internB;
        private System.Windows.Forms.Button pharmacistB;
        private System.Windows.Forms.Button patientB;
    }
}

