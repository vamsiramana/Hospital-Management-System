namespace MainForm
{
    partial class docPrescribeTest
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
            this.prescribeB = new System.Windows.Forms.Button();
            this.testIDTB = new System.Windows.Forms.TextBox();
            this.testIDL = new System.Windows.Forms.Label();
            this.patIDTB = new System.Windows.Forms.TextBox();
            this.patIDL = new System.Windows.Forms.Label();
            this.testL = new System.Windows.Forms.Label();
            this.patL = new System.Windows.Forms.Label();
            this.testsDGV = new System.Windows.Forms.DataGridView();
            this.patientsDGV = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.testsDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // prescribeB
            // 
            this.prescribeB.Location = new System.Drawing.Point(403, 488);
            this.prescribeB.Name = "prescribeB";
            this.prescribeB.Size = new System.Drawing.Size(100, 30);
            this.prescribeB.TabIndex = 17;
            this.prescribeB.Text = "Prescribe";
            this.prescribeB.UseVisualStyleBackColor = true;
            this.prescribeB.Click += new System.EventHandler(this.prescribeB_Click);
            // 
            // testIDTB
            // 
            this.testIDTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.testIDTB.Location = new System.Drawing.Point(453, 442);
            this.testIDTB.Name = "testIDTB";
            this.testIDTB.Size = new System.Drawing.Size(100, 27);
            this.testIDTB.TabIndex = 16;
            // 
            // testIDL
            // 
            this.testIDL.AutoSize = true;
            this.testIDL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.testIDL.Location = new System.Drawing.Point(346, 442);
            this.testIDL.Name = "testIDL";
            this.testIDL.Size = new System.Drawing.Size(69, 20);
            this.testIDL.TabIndex = 15;
            this.testIDL.Text = "Test ID:";
            // 
            // patIDTB
            // 
            this.patIDTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patIDTB.Location = new System.Drawing.Point(453, 390);
            this.patIDTB.Name = "patIDTB";
            this.patIDTB.Size = new System.Drawing.Size(100, 27);
            this.patIDTB.TabIndex = 14;
            // 
            // patIDL
            // 
            this.patIDL.AutoSize = true;
            this.patIDL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patIDL.Location = new System.Drawing.Point(346, 393);
            this.patIDL.Name = "patIDL";
            this.patIDL.Size = new System.Drawing.Size(93, 20);
            this.patIDL.TabIndex = 13;
            this.patIDL.Text = "Patient ID: ";
            // 
            // testL
            // 
            this.testL.AutoSize = true;
            this.testL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.testL.Location = new System.Drawing.Point(589, 12);
            this.testL.Name = "testL";
            this.testL.Size = new System.Drawing.Size(174, 20);
            this.testL.TabIndex = 12;
            this.testL.Text = "Tests and Description";
            // 
            // patL
            // 
            this.patL.AutoSize = true;
            this.patL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patL.Location = new System.Drawing.Point(142, 12);
            this.patL.Name = "patL";
            this.patL.Size = new System.Drawing.Size(186, 20);
            this.patL.TabIndex = 11;
            this.patL.Text = "Patients and Symptoms";
            // 
            // testsDGV
            // 
            this.testsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.testsDGV.Location = new System.Drawing.Point(477, 46);
            this.testsDGV.Name = "testsDGV";
            this.testsDGV.RowHeadersWidth = 51;
            this.testsDGV.RowTemplate.Height = 24;
            this.testsDGV.Size = new System.Drawing.Size(400, 300);
            this.testsDGV.TabIndex = 10;
            // 
            // patientsDGV
            // 
            this.patientsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.patientsDGV.Location = new System.Drawing.Point(39, 46);
            this.patientsDGV.Name = "patientsDGV";
            this.patientsDGV.RowHeadersWidth = 51;
            this.patientsDGV.RowTemplate.Height = 24;
            this.patientsDGV.Size = new System.Drawing.Size(400, 300);
            this.patientsDGV.TabIndex = 9;
            // 
            // docPrescribeTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 542);
            this.Controls.Add(this.prescribeB);
            this.Controls.Add(this.testIDTB);
            this.Controls.Add(this.testIDL);
            this.Controls.Add(this.patIDTB);
            this.Controls.Add(this.patIDL);
            this.Controls.Add(this.testL);
            this.Controls.Add(this.patL);
            this.Controls.Add(this.testsDGV);
            this.Controls.Add(this.patientsDGV);
            this.Name = "docPrescribeTest";
            this.Text = "docPrescribeTest";
            ((System.ComponentModel.ISupportInitialize)(this.testsDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button prescribeB;
        private System.Windows.Forms.TextBox testIDTB;
        private System.Windows.Forms.Label testIDL;
        private System.Windows.Forms.TextBox patIDTB;
        private System.Windows.Forms.Label patIDL;
        private System.Windows.Forms.Label testL;
        private System.Windows.Forms.Label patL;
        private System.Windows.Forms.DataGridView testsDGV;
        private System.Windows.Forms.DataGridView patientsDGV;
    }
}