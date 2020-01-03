namespace MainForm
{
    partial class patientMain
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
            this.testBillsDGV = new System.Windows.Forms.DataGridView();
            this.totalMedL = new System.Windows.Forms.Label();
            this.medTableL = new System.Windows.Forms.Label();
            this.testTableL = new System.Windows.Forms.Label();
            this.totalTestBillL = new System.Windows.Forms.Label();
            this.medicineBillsDGV = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.testBillsDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicineBillsDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // testBillsDGV
            // 
            this.testBillsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.testBillsDGV.Location = new System.Drawing.Point(444, 47);
            this.testBillsDGV.Name = "testBillsDGV";
            this.testBillsDGV.RowHeadersWidth = 51;
            this.testBillsDGV.RowTemplate.Height = 24;
            this.testBillsDGV.Size = new System.Drawing.Size(320, 380);
            this.testBillsDGV.TabIndex = 1;
            // 
            // totalMedL
            // 
            this.totalMedL.AutoSize = true;
            this.totalMedL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalMedL.Location = new System.Drawing.Point(71, 444);
            this.totalMedL.Name = "totalMedL";
            this.totalMedL.Size = new System.Drawing.Size(157, 20);
            this.totalMedL.TabIndex = 2;
            this.totalMedL.Text = "Total Medicine Bill: ";
            // 
            // medTableL
            // 
            this.medTableL.AutoSize = true;
            this.medTableL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medTableL.Location = new System.Drawing.Point(120, 19);
            this.medTableL.Name = "medTableL";
            this.medTableL.Size = new System.Drawing.Size(131, 25);
            this.medTableL.TabIndex = 3;
            this.medTableL.Text = "Medicine Bills";
            // 
            // testTableL
            // 
            this.testTableL.AutoSize = true;
            this.testTableL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.testTableL.Location = new System.Drawing.Point(562, 19);
            this.testTableL.Name = "testTableL";
            this.testTableL.Size = new System.Drawing.Size(91, 25);
            this.testTableL.TabIndex = 4;
            this.testTableL.Text = "Test Bills";
            // 
            // totalTestBillL
            // 
            this.totalTestBillL.AutoSize = true;
            this.totalTestBillL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalTestBillL.Location = new System.Drawing.Point(492, 444);
            this.totalTestBillL.Name = "totalTestBillL";
            this.totalTestBillL.Size = new System.Drawing.Size(118, 20);
            this.totalTestBillL.TabIndex = 5;
            this.totalTestBillL.Text = "Total Test Bill:";
            // 
            // medicineBillsDGV
            // 
            this.medicineBillsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.medicineBillsDGV.Location = new System.Drawing.Point(34, 47);
            this.medicineBillsDGV.Name = "medicineBillsDGV";
            this.medicineBillsDGV.RowHeadersWidth = 51;
            this.medicineBillsDGV.RowTemplate.Height = 24;
            this.medicineBillsDGV.Size = new System.Drawing.Size(320, 380);
            this.medicineBillsDGV.TabIndex = 6;
            // 
            // patientMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 513);
            this.Controls.Add(this.medicineBillsDGV);
            this.Controls.Add(this.totalTestBillL);
            this.Controls.Add(this.testTableL);
            this.Controls.Add(this.medTableL);
            this.Controls.Add(this.totalMedL);
            this.Controls.Add(this.testBillsDGV);
            this.Name = "patientMain";
            this.Text = "Patient";
            ((System.ComponentModel.ISupportInitialize)(this.testBillsDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicineBillsDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView testBillsDGV;
        private System.Windows.Forms.Label totalMedL;
        private System.Windows.Forms.Label medTableL;
        private System.Windows.Forms.Label testTableL;
        private System.Windows.Forms.Label totalTestBillL;
        private System.Windows.Forms.DataGridView medicineBillsDGV;
    }
}