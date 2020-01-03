namespace MainForm
{
    partial class doctorSchedule
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
            this.treatmentL = new System.Windows.Forms.Label();
            this.datesDGV = new System.Windows.Forms.DataGridView();
            this.IDL = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.datesDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // treatmentL
            // 
            this.treatmentL.AutoSize = true;
            this.treatmentL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treatmentL.Location = new System.Drawing.Point(46, 30);
            this.treatmentL.Name = "treatmentL";
            this.treatmentL.Size = new System.Drawing.Size(147, 24);
            this.treatmentL.TabIndex = 0;
            this.treatmentL.Text = "Treatment Dates";
            // 
            // datesDGV
            // 
            this.datesDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datesDGV.Location = new System.Drawing.Point(33, 57);
            this.datesDGV.Name = "datesDGV";
            this.datesDGV.RowHeadersWidth = 51;
            this.datesDGV.RowTemplate.Height = 24;
            this.datesDGV.Size = new System.Drawing.Size(400, 360);
            this.datesDGV.TabIndex = 1;
            // 
            // IDL
            // 
            this.IDL.AutoSize = true;
            this.IDL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDL.Location = new System.Drawing.Point(290, 30);
            this.IDL.Name = "IDL";
            this.IDL.Size = new System.Drawing.Size(32, 24);
            this.IDL.TabIndex = 2;
            this.IDL.Text = "ID:";
            // 
            // doctorSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 443);
            this.Controls.Add(this.IDL);
            this.Controls.Add(this.datesDGV);
            this.Controls.Add(this.treatmentL);
            this.Name = "doctorSchedule";
            this.Text = "My Schedule";
            ((System.ComponentModel.ISupportInitialize)(this.datesDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label treatmentL;
        private System.Windows.Forms.DataGridView datesDGV;
        private System.Windows.Forms.Label IDL;
    }
}