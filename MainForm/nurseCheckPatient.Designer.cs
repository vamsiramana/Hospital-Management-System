namespace MainForm
{
    partial class nurseCheckPatient
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
            this.roomsAndPatientsDGV = new System.Windows.Forms.DataGridView();
            this.roomsAndPatientsL = new System.Windows.Forms.Label();
            this.lookUpB = new System.Windows.Forms.Button();
            this.patientIDTB = new System.Windows.Forms.TextBox();
            this.patientIDL = new System.Windows.Forms.Label();
            this.patientDetailsRTB = new System.Windows.Forms.RichTextBox();
            this.patientDetailsL = new System.Windows.Forms.Label();
            this.refreshB = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.roomsAndPatientsDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // roomsAndPatientsDGV
            // 
            this.roomsAndPatientsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.roomsAndPatientsDGV.Location = new System.Drawing.Point(12, 45);
            this.roomsAndPatientsDGV.Name = "roomsAndPatientsDGV";
            this.roomsAndPatientsDGV.RowHeadersWidth = 51;
            this.roomsAndPatientsDGV.RowTemplate.Height = 24;
            this.roomsAndPatientsDGV.Size = new System.Drawing.Size(450, 305);
            this.roomsAndPatientsDGV.TabIndex = 0;
            // 
            // roomsAndPatientsL
            // 
            this.roomsAndPatientsL.AutoSize = true;
            this.roomsAndPatientsL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomsAndPatientsL.Location = new System.Drawing.Point(149, 22);
            this.roomsAndPatientsL.Name = "roomsAndPatientsL";
            this.roomsAndPatientsL.Size = new System.Drawing.Size(165, 20);
            this.roomsAndPatientsL.TabIndex = 1;
            this.roomsAndPatientsL.Text = "Rooms and Patients:";
            // 
            // lookUpB
            // 
            this.lookUpB.Location = new System.Drawing.Point(629, 93);
            this.lookUpB.Name = "lookUpB";
            this.lookUpB.Size = new System.Drawing.Size(100, 30);
            this.lookUpB.TabIndex = 2;
            this.lookUpB.Text = "Look Up";
            this.lookUpB.UseVisualStyleBackColor = true;
            this.lookUpB.Click += new System.EventHandler(this.lookUpB_Click);
            // 
            // patientIDTB
            // 
            this.patientIDTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientIDTB.Location = new System.Drawing.Point(569, 63);
            this.patientIDTB.Name = "patientIDTB";
            this.patientIDTB.Size = new System.Drawing.Size(160, 24);
            this.patientIDTB.TabIndex = 3;
            // 
            // patientIDL
            // 
            this.patientIDL.AutoSize = true;
            this.patientIDL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientIDL.Location = new System.Drawing.Point(478, 66);
            this.patientIDL.Name = "patientIDL";
            this.patientIDL.Size = new System.Drawing.Size(75, 18);
            this.patientIDL.TabIndex = 4;
            this.patientIDL.Text = "Patient ID:";
            // 
            // patientDetailsRTB
            // 
            this.patientDetailsRTB.Location = new System.Drawing.Point(469, 160);
            this.patientDetailsRTB.Name = "patientDetailsRTB";
            this.patientDetailsRTB.Size = new System.Drawing.Size(260, 190);
            this.patientDetailsRTB.TabIndex = 5;
            this.patientDetailsRTB.Text = "";
            // 
            // patientDetailsL
            // 
            this.patientDetailsL.AutoSize = true;
            this.patientDetailsL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientDetailsL.Location = new System.Drawing.Point(477, 137);
            this.patientDetailsL.Name = "patientDetailsL";
            this.patientDetailsL.Size = new System.Drawing.Size(119, 20);
            this.patientDetailsL.TabIndex = 6;
            this.patientDetailsL.Text = "Patient Details";
            // 
            // refreshB
            // 
            this.refreshB.Location = new System.Drawing.Point(523, 93);
            this.refreshB.Name = "refreshB";
            this.refreshB.Size = new System.Drawing.Size(100, 30);
            this.refreshB.TabIndex = 7;
            this.refreshB.Text = "Refresh";
            this.refreshB.UseVisualStyleBackColor = true;
            this.refreshB.Click += new System.EventHandler(this.refreshB_Click);
            // 
            // nurseCheckPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 375);
            this.Controls.Add(this.refreshB);
            this.Controls.Add(this.patientDetailsL);
            this.Controls.Add(this.patientDetailsRTB);
            this.Controls.Add(this.patientIDL);
            this.Controls.Add(this.patientIDTB);
            this.Controls.Add(this.lookUpB);
            this.Controls.Add(this.roomsAndPatientsL);
            this.Controls.Add(this.roomsAndPatientsDGV);
            this.Name = "nurseCheckPatient";
            this.Text = "Find Patients";
            ((System.ComponentModel.ISupportInitialize)(this.roomsAndPatientsDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView roomsAndPatientsDGV;
        private System.Windows.Forms.Label roomsAndPatientsL;
        private System.Windows.Forms.Button lookUpB;
        private System.Windows.Forms.TextBox patientIDTB;
        private System.Windows.Forms.Label patientIDL;
        private System.Windows.Forms.RichTextBox patientDetailsRTB;
        private System.Windows.Forms.Label patientDetailsL;
        private System.Windows.Forms.Button refreshB;
    }
}