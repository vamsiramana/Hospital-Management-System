namespace MainForm
{
    partial class doctorTreatsPatient
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
            this.allotedNursesDGV = new System.Windows.Forms.DataGridView();
            this.dGVL = new System.Windows.Forms.Label();
            this.patientIDL = new System.Windows.Forms.Label();
            this.patientIDTB = new System.Windows.Forms.TextBox();
            this.fixB = new System.Windows.Forms.Button();
            this.treatmentL = new System.Windows.Forms.Label();
            this.treatmentTB = new System.Windows.Forms.TextBox();
            this.helpL = new System.Windows.Forms.Label();
            this.fillB = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.allotedNursesDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // allotedNursesDGV
            // 
            this.allotedNursesDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.allotedNursesDGV.Location = new System.Drawing.Point(40, 77);
            this.allotedNursesDGV.Name = "allotedNursesDGV";
            this.allotedNursesDGV.RowHeadersWidth = 51;
            this.allotedNursesDGV.RowTemplate.Height = 24;
            this.allotedNursesDGV.Size = new System.Drawing.Size(360, 320);
            this.allotedNursesDGV.TabIndex = 0;
            // 
            // dGVL
            // 
            this.dGVL.AutoSize = true;
            this.dGVL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dGVL.Location = new System.Drawing.Point(36, 32);
            this.dGVL.Name = "dGVL";
            this.dGVL.Size = new System.Drawing.Size(230, 24);
            this.dGVL.TabIndex = 1;
            this.dGVL.Text = "Nurses Alloted And Dates:";
            // 
            // patientIDL
            // 
            this.patientIDL.AutoSize = true;
            this.patientIDL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientIDL.Location = new System.Drawing.Point(432, 116);
            this.patientIDL.Name = "patientIDL";
            this.patientIDL.Size = new System.Drawing.Size(88, 20);
            this.patientIDL.TabIndex = 2;
            this.patientIDL.Text = "Patient ID:";
            // 
            // patientIDTB
            // 
            this.patientIDTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientIDTB.Location = new System.Drawing.Point(527, 116);
            this.patientIDTB.Name = "patientIDTB";
            this.patientIDTB.Size = new System.Drawing.Size(180, 24);
            this.patientIDTB.TabIndex = 3;
            // 
            // fixB
            // 
            this.fixB.Location = new System.Drawing.Point(604, 230);
            this.fixB.Name = "fixB";
            this.fixB.Size = new System.Drawing.Size(100, 30);
            this.fixB.TabIndex = 4;
            this.fixB.Text = "Fix";
            this.fixB.UseVisualStyleBackColor = true;
            this.fixB.Click += new System.EventHandler(this.fixB_Click);
            // 
            // treatmentL
            // 
            this.treatmentL.AutoSize = true;
            this.treatmentL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treatmentL.Location = new System.Drawing.Point(432, 183);
            this.treatmentL.Name = "treatmentL";
            this.treatmentL.Size = new System.Drawing.Size(131, 20);
            this.treatmentL.TabIndex = 5;
            this.treatmentL.Text = "Treatment Date:";
            // 
            // treatmentTB
            // 
            this.treatmentTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treatmentTB.Location = new System.Drawing.Point(569, 183);
            this.treatmentTB.Name = "treatmentTB";
            this.treatmentTB.Size = new System.Drawing.Size(135, 24);
            this.treatmentTB.TabIndex = 6;
            // 
            // helpL
            // 
            this.helpL.AutoSize = true;
            this.helpL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpL.Location = new System.Drawing.Point(433, 310);
            this.helpL.Name = "helpL";
            this.helpL.Size = new System.Drawing.Size(254, 18);
            this.helpL.TabIndex = 7;
            this.helpL.Text = "*Enter Date in \'YYYY-MM-DD\' format.";
            // 
            // fillB
            // 
            this.fillB.Location = new System.Drawing.Point(498, 230);
            this.fillB.Name = "fillB";
            this.fillB.Size = new System.Drawing.Size(100, 30);
            this.fillB.TabIndex = 8;
            this.fillB.Text = "Fill";
            this.fillB.UseVisualStyleBackColor = true;
            this.fillB.Click += new System.EventHandler(this.fillB_Click);
            // 
            // doctorTreatsPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 432);
            this.Controls.Add(this.fillB);
            this.Controls.Add(this.helpL);
            this.Controls.Add(this.treatmentTB);
            this.Controls.Add(this.treatmentL);
            this.Controls.Add(this.fixB);
            this.Controls.Add(this.patientIDTB);
            this.Controls.Add(this.patientIDL);
            this.Controls.Add(this.dGVL);
            this.Controls.Add(this.allotedNursesDGV);
            this.Name = "doctorTreatsPatient";
            this.Text = "Treat Patient";
            ((System.ComponentModel.ISupportInitialize)(this.allotedNursesDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView allotedNursesDGV;
        private System.Windows.Forms.Label dGVL;
        private System.Windows.Forms.Label patientIDL;
        private System.Windows.Forms.TextBox patientIDTB;
        private System.Windows.Forms.Button fixB;
        private System.Windows.Forms.Label treatmentL;
        private System.Windows.Forms.TextBox treatmentTB;
        private System.Windows.Forms.Label helpL;
        private System.Windows.Forms.Button fillB;
    }
}