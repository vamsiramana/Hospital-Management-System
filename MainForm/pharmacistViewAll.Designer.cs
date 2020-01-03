namespace MainForm
{
    partial class pharmacistViewAll
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
            this.medicinesDGV = new System.Windows.Forms.DataGridView();
            this.medicineL = new System.Windows.Forms.Label();
            this.refreshB = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.medicinesDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // medicinesDGV
            // 
            this.medicinesDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.medicinesDGV.Location = new System.Drawing.Point(12, 52);
            this.medicinesDGV.Name = "medicinesDGV";
            this.medicinesDGV.RowHeadersWidth = 51;
            this.medicinesDGV.RowTemplate.Height = 24;
            this.medicinesDGV.Size = new System.Drawing.Size(650, 440);
            this.medicinesDGV.TabIndex = 0;
            // 
            // medicineL
            // 
            this.medicineL.AutoSize = true;
            this.medicineL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medicineL.Location = new System.Drawing.Point(110, 16);
            this.medicineL.Name = "medicineL";
            this.medicineL.Size = new System.Drawing.Size(213, 25);
            this.medicineL.TabIndex = 1;
            this.medicineL.Text = "All Available Medicines";
            // 
            // refreshB
            // 
            this.refreshB.Location = new System.Drawing.Point(452, 16);
            this.refreshB.Name = "refreshB";
            this.refreshB.Size = new System.Drawing.Size(180, 30);
            this.refreshB.TabIndex = 2;
            this.refreshB.Text = "Refresh";
            this.refreshB.UseVisualStyleBackColor = true;
            this.refreshB.Click += new System.EventHandler(this.refreshB_Click);
            // 
            // pharmacistViewAll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 504);
            this.Controls.Add(this.refreshB);
            this.Controls.Add(this.medicineL);
            this.Controls.Add(this.medicinesDGV);
            this.Name = "pharmacistViewAll";
            this.Text = "View All Medicines";
            ((System.ComponentModel.ISupportInitialize)(this.medicinesDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView medicinesDGV;
        private System.Windows.Forms.Label medicineL;
        private System.Windows.Forms.Button refreshB;
    }
}