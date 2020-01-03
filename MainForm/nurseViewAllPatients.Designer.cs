namespace MainForm
{
    partial class nurseViewAllPatients
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
            this.patientsDGV = new System.Windows.Forms.DataGridView();
            this.patientsL = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.patientsDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // patientsDGV
            // 
            this.patientsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.patientsDGV.Location = new System.Drawing.Point(25, 55);
            this.patientsDGV.Name = "patientsDGV";
            this.patientsDGV.RowHeadersWidth = 51;
            this.patientsDGV.RowTemplate.Height = 24;
            this.patientsDGV.Size = new System.Drawing.Size(600, 400);
            this.patientsDGV.TabIndex = 0;
            // 
            // patientsL
            // 
            this.patientsL.AutoSize = true;
            this.patientsL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientsL.Location = new System.Drawing.Point(277, 28);
            this.patientsL.Name = "patientsL";
            this.patientsL.Size = new System.Drawing.Size(75, 24);
            this.patientsL.TabIndex = 1;
            this.patientsL.Text = "Patients";
            // 
            // nurseViewAllPatients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 486);
            this.Controls.Add(this.patientsL);
            this.Controls.Add(this.patientsDGV);
            this.Name = "nurseViewAllPatients";
            this.Text = "All Patients";
            ((System.ComponentModel.ISupportInitialize)(this.patientsDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView patientsDGV;
        private System.Windows.Forms.Label patientsL;
    }
}