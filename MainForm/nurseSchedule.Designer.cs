namespace MainForm
{
    partial class nurseSchedule
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
            this.datesDGV = new System.Windows.Forms.DataGridView();
            this.datesL = new System.Windows.Forms.Label();
            this.iDL = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.datesDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // datesDGV
            // 
            this.datesDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datesDGV.Location = new System.Drawing.Point(31, 51);
            this.datesDGV.Name = "datesDGV";
            this.datesDGV.RowHeadersWidth = 51;
            this.datesDGV.RowTemplate.Height = 24;
            this.datesDGV.Size = new System.Drawing.Size(360, 320);
            this.datesDGV.TabIndex = 0;
            // 
            // datesL
            // 
            this.datesL.AutoSize = true;
            this.datesL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datesL.Location = new System.Drawing.Point(26, 23);
            this.datesL.Name = "datesL";
            this.datesL.Size = new System.Drawing.Size(128, 25);
            this.datesL.TabIndex = 1;
            this.datesL.Text = "Alloted Dates";
            // 
            // iDL
            // 
            this.iDL.AutoSize = true;
            this.iDL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iDL.Location = new System.Drawing.Point(270, 23);
            this.iDL.Name = "iDL";
            this.iDL.Size = new System.Drawing.Size(42, 25);
            this.iDL.TabIndex = 2;
            this.iDL.Text = "ID: ";
            // 
            // nurseSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 383);
            this.Controls.Add(this.iDL);
            this.Controls.Add(this.datesL);
            this.Controls.Add(this.datesDGV);
            this.Name = "nurseSchedule";
            this.Text = "My Schedule";
            ((System.ComponentModel.ISupportInitialize)(this.datesDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView datesDGV;
        private System.Windows.Forms.Label datesL;
        private System.Windows.Forms.Label iDL;
    }
}