namespace MainForm
{
    partial class docPrescribeMed
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
            this.medicinesDGV = new System.Windows.Forms.DataGridView();
            this.patL = new System.Windows.Forms.Label();
            this.medL = new System.Windows.Forms.Label();
            this.patIDL = new System.Windows.Forms.Label();
            this.patIDTB = new System.Windows.Forms.TextBox();
            this.medIDL = new System.Windows.Forms.Label();
            this.medIDTB = new System.Windows.Forms.TextBox();
            this.prescribeB = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.patientsDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicinesDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // patientsDGV
            // 
            this.patientsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.patientsDGV.Location = new System.Drawing.Point(31, 55);
            this.patientsDGV.Name = "patientsDGV";
            this.patientsDGV.RowHeadersWidth = 51;
            this.patientsDGV.RowTemplate.Height = 24;
            this.patientsDGV.Size = new System.Drawing.Size(400, 300);
            this.patientsDGV.TabIndex = 0;
            // 
            // medicinesDGV
            // 
            this.medicinesDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.medicinesDGV.Location = new System.Drawing.Point(469, 55);
            this.medicinesDGV.Name = "medicinesDGV";
            this.medicinesDGV.RowHeadersWidth = 51;
            this.medicinesDGV.RowTemplate.Height = 24;
            this.medicinesDGV.Size = new System.Drawing.Size(400, 300);
            this.medicinesDGV.TabIndex = 1;
            // 
            // patL
            // 
            this.patL.AutoSize = true;
            this.patL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patL.Location = new System.Drawing.Point(134, 21);
            this.patL.Name = "patL";
            this.patL.Size = new System.Drawing.Size(186, 20);
            this.patL.TabIndex = 2;
            this.patL.Text = "Patients and Symptoms";
            // 
            // medL
            // 
            this.medL.AutoSize = true;
            this.medL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medL.Location = new System.Drawing.Point(581, 21);
            this.medL.Name = "medL";
            this.medL.Size = new System.Drawing.Size(208, 20);
            this.medL.TabIndex = 3;
            this.medL.Text = "Medicines and Description";
            // 
            // patIDL
            // 
            this.patIDL.AutoSize = true;
            this.patIDL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patIDL.Location = new System.Drawing.Point(338, 402);
            this.patIDL.Name = "patIDL";
            this.patIDL.Size = new System.Drawing.Size(93, 20);
            this.patIDL.TabIndex = 4;
            this.patIDL.Text = "Patient ID: ";
            // 
            // patIDTB
            // 
            this.patIDTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patIDTB.Location = new System.Drawing.Point(445, 399);
            this.patIDTB.Name = "patIDTB";
            this.patIDTB.Size = new System.Drawing.Size(100, 27);
            this.patIDTB.TabIndex = 5;
            // 
            // medIDL
            // 
            this.medIDL.AutoSize = true;
            this.medIDL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medIDL.Location = new System.Drawing.Point(338, 451);
            this.medIDL.Name = "medIDL";
            this.medIDL.Size = new System.Drawing.Size(103, 20);
            this.medIDL.TabIndex = 6;
            this.medIDL.Text = "Medicine ID:";
            // 
            // medIDTB
            // 
            this.medIDTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medIDTB.Location = new System.Drawing.Point(448, 451);
            this.medIDTB.Name = "medIDTB";
            this.medIDTB.Size = new System.Drawing.Size(100, 27);
            this.medIDTB.TabIndex = 7;
            // 
            // prescribeB
            // 
            this.prescribeB.Location = new System.Drawing.Point(395, 497);
            this.prescribeB.Name = "prescribeB";
            this.prescribeB.Size = new System.Drawing.Size(100, 30);
            this.prescribeB.TabIndex = 8;
            this.prescribeB.Text = "Prescribe";
            this.prescribeB.UseVisualStyleBackColor = true;
            this.prescribeB.Click += new System.EventHandler(this.prescribeB_Click);
            // 
            // docPrescribeMed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 583);
            this.Controls.Add(this.prescribeB);
            this.Controls.Add(this.medIDTB);
            this.Controls.Add(this.medIDL);
            this.Controls.Add(this.patIDTB);
            this.Controls.Add(this.patIDL);
            this.Controls.Add(this.medL);
            this.Controls.Add(this.patL);
            this.Controls.Add(this.medicinesDGV);
            this.Controls.Add(this.patientsDGV);
            this.Name = "docPrescribeMed";
            this.Text = "Prescribe Medicine";
            ((System.ComponentModel.ISupportInitialize)(this.patientsDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicinesDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView patientsDGV;
        private System.Windows.Forms.DataGridView medicinesDGV;
        private System.Windows.Forms.Label patL;
        private System.Windows.Forms.Label medL;
        private System.Windows.Forms.Label patIDL;
        private System.Windows.Forms.TextBox patIDTB;
        private System.Windows.Forms.Label medIDL;
        private System.Windows.Forms.TextBox medIDTB;
        private System.Windows.Forms.Button prescribeB;
    }
}