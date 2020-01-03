namespace MainForm
{
    partial class doctorMain
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
            this.viewPatientsB = new System.Windows.Forms.Button();
            this.doctorNameL = new System.Windows.Forms.Label();
            this.prescribeMedB = new System.Windows.Forms.Button();
            this.prescribeTestB = new System.Windows.Forms.Button();
            this.appointNurseB = new System.Windows.Forms.Button();
            this.patientsDGV = new System.Windows.Forms.DataGridView();
            this.exitB = new System.Windows.Forms.Button();
            this.treatsB = new System.Windows.Forms.Button();
            this.patientSymptomB = new System.Windows.Forms.Button();
            this.admittedPatientsB = new System.Windows.Forms.Button();
            this.scheduleB = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.patientsDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // viewPatientsB
            // 
            this.viewPatientsB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewPatientsB.Location = new System.Drawing.Point(16, 120);
            this.viewPatientsB.Name = "viewPatientsB";
            this.viewPatientsB.Size = new System.Drawing.Size(180, 30);
            this.viewPatientsB.TabIndex = 0;
            this.viewPatientsB.Text = "View Patients";
            this.viewPatientsB.UseVisualStyleBackColor = true;
            this.viewPatientsB.Click += new System.EventHandler(this.viewPatientsB_Click);
            // 
            // doctorNameL
            // 
            this.doctorNameL.AutoSize = true;
            this.doctorNameL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doctorNameL.Location = new System.Drawing.Point(12, 63);
            this.doctorNameL.Name = "doctorNameL";
            this.doctorNameL.Size = new System.Drawing.Size(75, 20);
            this.doctorNameL.TabIndex = 1;
            this.doctorNameL.Text = "Doctor : ";
            // 
            // prescribeMedB
            // 
            this.prescribeMedB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prescribeMedB.Location = new System.Drawing.Point(15, 156);
            this.prescribeMedB.Name = "prescribeMedB";
            this.prescribeMedB.Size = new System.Drawing.Size(180, 30);
            this.prescribeMedB.TabIndex = 2;
            this.prescribeMedB.Text = "Prescribe Medicine";
            this.prescribeMedB.UseVisualStyleBackColor = true;
            this.prescribeMedB.Click += new System.EventHandler(this.prescribeMedB_Click);
            // 
            // prescribeTestB
            // 
            this.prescribeTestB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prescribeTestB.Location = new System.Drawing.Point(16, 193);
            this.prescribeTestB.Name = "prescribeTestB";
            this.prescribeTestB.Size = new System.Drawing.Size(180, 30);
            this.prescribeTestB.TabIndex = 3;
            this.prescribeTestB.Text = "Prescribe Test";
            this.prescribeTestB.UseVisualStyleBackColor = true;
            this.prescribeTestB.Click += new System.EventHandler(this.prescribeTestB_Click);
            // 
            // appointNurseB
            // 
            this.appointNurseB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appointNurseB.Location = new System.Drawing.Point(15, 229);
            this.appointNurseB.Name = "appointNurseB";
            this.appointNurseB.Size = new System.Drawing.Size(180, 30);
            this.appointNurseB.TabIndex = 5;
            this.appointNurseB.Text = "Appoint Nurse";
            this.appointNurseB.UseVisualStyleBackColor = true;
            this.appointNurseB.Click += new System.EventHandler(this.appointNurseB_Click);
            // 
            // patientsDGV
            // 
            this.patientsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.patientsDGV.Location = new System.Drawing.Point(227, 40);
            this.patientsDGV.Name = "patientsDGV";
            this.patientsDGV.RowHeadersWidth = 51;
            this.patientsDGV.RowTemplate.Height = 24;
            this.patientsDGV.Size = new System.Drawing.Size(380, 350);
            this.patientsDGV.TabIndex = 6;
            // 
            // exitB
            // 
            this.exitB.Location = new System.Drawing.Point(527, 396);
            this.exitB.Name = "exitB";
            this.exitB.Size = new System.Drawing.Size(80, 30);
            this.exitB.TabIndex = 7;
            this.exitB.Text = "Exit";
            this.exitB.UseVisualStyleBackColor = true;
            this.exitB.Click += new System.EventHandler(this.exitB_Click);
            // 
            // treatsB
            // 
            this.treatsB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treatsB.Location = new System.Drawing.Point(16, 266);
            this.treatsB.Name = "treatsB";
            this.treatsB.Size = new System.Drawing.Size(180, 30);
            this.treatsB.TabIndex = 8;
            this.treatsB.Text = "Treat Patient";
            this.treatsB.UseVisualStyleBackColor = true;
            this.treatsB.Click += new System.EventHandler(this.treatsB_Click);
            // 
            // patientSymptomB
            // 
            this.patientSymptomB.Location = new System.Drawing.Point(16, 303);
            this.patientSymptomB.Name = "patientSymptomB";
            this.patientSymptomB.Size = new System.Drawing.Size(180, 30);
            this.patientSymptomB.TabIndex = 9;
            this.patientSymptomB.Text = "Patients And Symptoms";
            this.patientSymptomB.UseVisualStyleBackColor = true;
            this.patientSymptomB.Click += new System.EventHandler(this.patientSymptomB_Click);
            // 
            // admittedPatientsB
            // 
            this.admittedPatientsB.Location = new System.Drawing.Point(16, 340);
            this.admittedPatientsB.Name = "admittedPatientsB";
            this.admittedPatientsB.Size = new System.Drawing.Size(180, 30);
            this.admittedPatientsB.TabIndex = 10;
            this.admittedPatientsB.Text = "Admitted Patients";
            this.admittedPatientsB.UseVisualStyleBackColor = true;
            this.admittedPatientsB.Click += new System.EventHandler(this.admittedPatientsB_Click);
            // 
            // scheduleB
            // 
            this.scheduleB.Location = new System.Drawing.Point(16, 377);
            this.scheduleB.Name = "scheduleB";
            this.scheduleB.Size = new System.Drawing.Size(180, 30);
            this.scheduleB.TabIndex = 11;
            this.scheduleB.Text = "Schedule";
            this.scheduleB.UseVisualStyleBackColor = true;
            this.scheduleB.Click += new System.EventHandler(this.scheduleB_Click);
            // 
            // doctorMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 438);
            this.Controls.Add(this.scheduleB);
            this.Controls.Add(this.admittedPatientsB);
            this.Controls.Add(this.patientSymptomB);
            this.Controls.Add(this.treatsB);
            this.Controls.Add(this.exitB);
            this.Controls.Add(this.patientsDGV);
            this.Controls.Add(this.appointNurseB);
            this.Controls.Add(this.prescribeTestB);
            this.Controls.Add(this.prescribeMedB);
            this.Controls.Add(this.doctorNameL);
            this.Controls.Add(this.viewPatientsB);
            this.Name = "doctorMain";
            this.Text = "Doctor Operations";
            ((System.ComponentModel.ISupportInitialize)(this.patientsDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button viewPatientsB;
        private System.Windows.Forms.Label doctorNameL;
        private System.Windows.Forms.Button prescribeMedB;
        private System.Windows.Forms.Button prescribeTestB;
        private System.Windows.Forms.Button appointNurseB;
        private System.Windows.Forms.DataGridView patientsDGV;
        private System.Windows.Forms.Button exitB;
        private System.Windows.Forms.Button treatsB;
        private System.Windows.Forms.Button patientSymptomB;
        private System.Windows.Forms.Button admittedPatientsB;
        private System.Windows.Forms.Button scheduleB;
    }
}