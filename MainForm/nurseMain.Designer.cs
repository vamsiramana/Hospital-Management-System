namespace MainForm
{
    partial class nurseMain
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
            this.nurseNameL = new System.Windows.Forms.Label();
            this.checkB = new System.Windows.Forms.Button();
            this.allotRoomB = new System.Windows.Forms.Button();
            this.dischargeB = new System.Windows.Forms.Button();
            this.scheduleB = new System.Windows.Forms.Button();
            this.allPatientsB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nurseNameL
            // 
            this.nurseNameL.AutoSize = true;
            this.nurseNameL.Location = new System.Drawing.Point(12, 20);
            this.nurseNameL.Name = "nurseNameL";
            this.nurseNameL.Size = new System.Drawing.Size(95, 17);
            this.nurseNameL.TabIndex = 0;
            this.nurseNameL.Text = "Nurse Name: ";
            // 
            // checkB
            // 
            this.checkB.Location = new System.Drawing.Point(28, 51);
            this.checkB.Name = "checkB";
            this.checkB.Size = new System.Drawing.Size(100, 30);
            this.checkB.TabIndex = 1;
            this.checkB.Text = "Check";
            this.checkB.UseVisualStyleBackColor = true;
            this.checkB.Click += new System.EventHandler(this.checkB_Click);
            // 
            // allotRoomB
            // 
            this.allotRoomB.Location = new System.Drawing.Point(154, 51);
            this.allotRoomB.Name = "allotRoomB";
            this.allotRoomB.Size = new System.Drawing.Size(100, 30);
            this.allotRoomB.TabIndex = 3;
            this.allotRoomB.Text = "Allot Room";
            this.allotRoomB.UseVisualStyleBackColor = true;
            this.allotRoomB.Click += new System.EventHandler(this.allotRoomB_Click);
            // 
            // dischargeB
            // 
            this.dischargeB.Location = new System.Drawing.Point(28, 98);
            this.dischargeB.Name = "dischargeB";
            this.dischargeB.Size = new System.Drawing.Size(100, 30);
            this.dischargeB.TabIndex = 4;
            this.dischargeB.Text = "Discharge";
            this.dischargeB.UseVisualStyleBackColor = true;
            this.dischargeB.Click += new System.EventHandler(this.dischargeB_Click);
            // 
            // scheduleB
            // 
            this.scheduleB.Location = new System.Drawing.Point(154, 98);
            this.scheduleB.Name = "scheduleB";
            this.scheduleB.Size = new System.Drawing.Size(100, 30);
            this.scheduleB.TabIndex = 5;
            this.scheduleB.Text = "Schedule";
            this.scheduleB.UseVisualStyleBackColor = true;
            this.scheduleB.Click += new System.EventHandler(this.scheduleB_Click);
            // 
            // allPatientsB
            // 
            this.allPatientsB.Location = new System.Drawing.Point(60, 149);
            this.allPatientsB.Name = "allPatientsB";
            this.allPatientsB.Size = new System.Drawing.Size(160, 30);
            this.allPatientsB.TabIndex = 6;
            this.allPatientsB.Text = "All Patients";
            this.allPatientsB.UseVisualStyleBackColor = true;
            this.allPatientsB.Click += new System.EventHandler(this.allPatientsB_Click);
            // 
            // nurseMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 205);
            this.Controls.Add(this.allPatientsB);
            this.Controls.Add(this.scheduleB);
            this.Controls.Add(this.dischargeB);
            this.Controls.Add(this.allotRoomB);
            this.Controls.Add(this.checkB);
            this.Controls.Add(this.nurseNameL);
            this.Name = "nurseMain";
            this.Text = "Nurse";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nurseNameL;
        private System.Windows.Forms.Button checkB;
        private System.Windows.Forms.Button allotRoomB;
        private System.Windows.Forms.Button dischargeB;
        private System.Windows.Forms.Button scheduleB;
        private System.Windows.Forms.Button allPatientsB;
    }
}