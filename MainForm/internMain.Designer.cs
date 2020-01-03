namespace MainForm
{
    partial class internMain
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
            this.diagnoseB = new System.Windows.Forms.Button();
            this.patientSymptomDGV = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.internIDL = new System.Windows.Forms.Label();
            this.refreshB = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.patientSymptomDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // diagnoseB
            // 
            this.diagnoseB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diagnoseB.Location = new System.Drawing.Point(54, 364);
            this.diagnoseB.Name = "diagnoseB";
            this.diagnoseB.Size = new System.Drawing.Size(180, 30);
            this.diagnoseB.TabIndex = 0;
            this.diagnoseB.Text = "Diagnose";
            this.diagnoseB.UseVisualStyleBackColor = true;
            this.diagnoseB.Click += new System.EventHandler(this.diagnoseB_Click);
            // 
            // patientSymptomDGV
            // 
            this.patientSymptomDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.patientSymptomDGV.Location = new System.Drawing.Point(44, 38);
            this.patientSymptomDGV.Name = "patientSymptomDGV";
            this.patientSymptomDGV.RowHeadersWidth = 51;
            this.patientSymptomDGV.RowTemplate.Height = 24;
            this.patientSymptomDGV.Size = new System.Drawing.Size(400, 320);
            this.patientSymptomDGV.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Patients and Symptoms";
            // 
            // internIDL
            // 
            this.internIDL.AutoSize = true;
            this.internIDL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.internIDL.Location = new System.Drawing.Point(357, 9);
            this.internIDL.Name = "internIDL";
            this.internIDL.Size = new System.Drawing.Size(32, 24);
            this.internIDL.TabIndex = 5;
            this.internIDL.Text = "ID:";
            // 
            // refreshB
            // 
            this.refreshB.Location = new System.Drawing.Point(253, 364);
            this.refreshB.Name = "refreshB";
            this.refreshB.Size = new System.Drawing.Size(180, 30);
            this.refreshB.TabIndex = 6;
            this.refreshB.Text = "Refresh";
            this.refreshB.UseVisualStyleBackColor = true;
            this.refreshB.Click += new System.EventHandler(this.refreshB_Click);
            // 
            // internMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 430);
            this.Controls.Add(this.refreshB);
            this.Controls.Add(this.internIDL);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.patientSymptomDGV);
            this.Controls.Add(this.diagnoseB);
            this.Name = "internMain";
            this.Text = "Intern";
            ((System.ComponentModel.ISupportInitialize)(this.patientSymptomDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button diagnoseB;
        private System.Windows.Forms.DataGridView patientSymptomDGV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label internIDL;
        private System.Windows.Forms.Button refreshB;
    }
}