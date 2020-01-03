namespace MainForm
{
    partial class nurseDischarge
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
            this.allotedPatientsL = new System.Windows.Forms.Label();
            this.dischargeDateL = new System.Windows.Forms.Label();
            this.patientIDL = new System.Windows.Forms.Label();
            this.dischargeDateTB = new System.Windows.Forms.TextBox();
            this.patientIDTB = new System.Windows.Forms.TextBox();
            this.dischargeB = new System.Windows.Forms.Button();
            this.dateFormatL = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.patientsDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // patientsDGV
            // 
            this.patientsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.patientsDGV.Location = new System.Drawing.Point(40, 51);
            this.patientsDGV.Name = "patientsDGV";
            this.patientsDGV.RowHeadersWidth = 51;
            this.patientsDGV.RowTemplate.Height = 24;
            this.patientsDGV.Size = new System.Drawing.Size(400, 300);
            this.patientsDGV.TabIndex = 0;
            // 
            // allotedPatientsL
            // 
            this.allotedPatientsL.AutoSize = true;
            this.allotedPatientsL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allotedPatientsL.Location = new System.Drawing.Point(143, 23);
            this.allotedPatientsL.Name = "allotedPatientsL";
            this.allotedPatientsL.Size = new System.Drawing.Size(170, 25);
            this.allotedPatientsL.TabIndex = 1;
            this.allotedPatientsL.Text = "Patients Admitted:";
            // 
            // dischargeDateL
            // 
            this.dischargeDateL.AutoSize = true;
            this.dischargeDateL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dischargeDateL.Location = new System.Drawing.Point(474, 78);
            this.dischargeDateL.Name = "dischargeDateL";
            this.dischargeDateL.Size = new System.Drawing.Size(132, 20);
            this.dischargeDateL.TabIndex = 2;
            this.dischargeDateL.Text = "Discharge Date:";
            // 
            // patientIDL
            // 
            this.patientIDL.AutoSize = true;
            this.patientIDL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientIDL.Location = new System.Drawing.Point(474, 151);
            this.patientIDL.Name = "patientIDL";
            this.patientIDL.Size = new System.Drawing.Size(88, 20);
            this.patientIDL.TabIndex = 3;
            this.patientIDL.Text = "Patient ID:";
            // 
            // dischargeDateTB
            // 
            this.dischargeDateTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dischargeDateTB.Location = new System.Drawing.Point(506, 111);
            this.dischargeDateTB.Name = "dischargeDateTB";
            this.dischargeDateTB.Size = new System.Drawing.Size(180, 24);
            this.dischargeDateTB.TabIndex = 4;
            // 
            // patientIDTB
            // 
            this.patientIDTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientIDTB.Location = new System.Drawing.Point(506, 184);
            this.patientIDTB.Name = "patientIDTB";
            this.patientIDTB.Size = new System.Drawing.Size(180, 24);
            this.patientIDTB.TabIndex = 5;
            // 
            // dischargeB
            // 
            this.dischargeB.Location = new System.Drawing.Point(586, 227);
            this.dischargeB.Name = "dischargeB";
            this.dischargeB.Size = new System.Drawing.Size(100, 30);
            this.dischargeB.TabIndex = 6;
            this.dischargeB.Text = "Discharge";
            this.dischargeB.UseVisualStyleBackColor = true;
            this.dischargeB.Click += new System.EventHandler(this.dischargeB_Click);
            // 
            // dateFormatL
            // 
            this.dateFormatL.AutoSize = true;
            this.dateFormatL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateFormatL.Location = new System.Drawing.Point(474, 331);
            this.dateFormatL.Name = "dateFormatL";
            this.dateFormatL.Size = new System.Drawing.Size(231, 20);
            this.dateFormatL.TabIndex = 7;
            this.dateFormatL.Text = "*Date Format - YYYY-MM-DD";
            // 
            // nurseDischarge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 396);
            this.Controls.Add(this.dateFormatL);
            this.Controls.Add(this.dischargeB);
            this.Controls.Add(this.patientIDTB);
            this.Controls.Add(this.dischargeDateTB);
            this.Controls.Add(this.patientIDL);
            this.Controls.Add(this.dischargeDateL);
            this.Controls.Add(this.allotedPatientsL);
            this.Controls.Add(this.patientsDGV);
            this.Name = "nurseDischarge";
            this.Text = "Discharge Patient";
            ((System.ComponentModel.ISupportInitialize)(this.patientsDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView patientsDGV;
        private System.Windows.Forms.Label allotedPatientsL;
        private System.Windows.Forms.Label dischargeDateL;
        private System.Windows.Forms.Label patientIDL;
        private System.Windows.Forms.TextBox dischargeDateTB;
        private System.Windows.Forms.TextBox patientIDTB;
        private System.Windows.Forms.Button dischargeB;
        private System.Windows.Forms.Label dateFormatL;
    }
}