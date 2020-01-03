namespace MainForm
{
    partial class doctorAppointNurses
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
            this.appointB = new System.Windows.Forms.Button();
            this.findB = new System.Windows.Forms.Button();
            this.availableNursesDGV = new System.Windows.Forms.DataGridView();
            this.dateL = new System.Windows.Forms.Label();
            this.dateTB = new System.Windows.Forms.TextBox();
            this.nurseIDL = new System.Windows.Forms.Label();
            this.availableNursesL = new System.Windows.Forms.Label();
            this.nurseIDTB = new System.Windows.Forms.TextBox();
            this.dateInfoL = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.availableNursesDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // appointB
            // 
            this.appointB.Location = new System.Drawing.Point(289, 414);
            this.appointB.Name = "appointB";
            this.appointB.Size = new System.Drawing.Size(80, 30);
            this.appointB.TabIndex = 0;
            this.appointB.Text = "Appoint";
            this.appointB.UseVisualStyleBackColor = true;
            this.appointB.Click += new System.EventHandler(this.appointB_Click);
            // 
            // findB
            // 
            this.findB.Location = new System.Drawing.Point(289, 57);
            this.findB.Name = "findB";
            this.findB.Size = new System.Drawing.Size(80, 30);
            this.findB.TabIndex = 1;
            this.findB.Text = "Find";
            this.findB.UseVisualStyleBackColor = true;
            this.findB.Click += new System.EventHandler(this.findB_Click);
            // 
            // availableNursesDGV
            // 
            this.availableNursesDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.availableNursesDGV.Location = new System.Drawing.Point(49, 103);
            this.availableNursesDGV.Name = "availableNursesDGV";
            this.availableNursesDGV.RowHeadersWidth = 51;
            this.availableNursesDGV.RowTemplate.Height = 24;
            this.availableNursesDGV.Size = new System.Drawing.Size(320, 250);
            this.availableNursesDGV.TabIndex = 2;
            // 
            // dateL
            // 
            this.dateL.AutoSize = true;
            this.dateL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateL.Location = new System.Drawing.Point(28, 27);
            this.dateL.Name = "dateL";
            this.dateL.Size = new System.Drawing.Size(145, 20);
            this.dateL.TabIndex = 3;
            this.dateL.Text = "Date of Treatment";
            // 
            // dateTB
            // 
            this.dateTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTB.Location = new System.Drawing.Point(189, 27);
            this.dateTB.Name = "dateTB";
            this.dateTB.Size = new System.Drawing.Size(180, 24);
            this.dateTB.TabIndex = 4;
            // 
            // nurseIDL
            // 
            this.nurseIDL.AutoSize = true;
            this.nurseIDL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nurseIDL.Location = new System.Drawing.Point(38, 380);
            this.nurseIDL.Name = "nurseIDL";
            this.nurseIDL.Size = new System.Drawing.Size(76, 20);
            this.nurseIDL.TabIndex = 5;
            this.nurseIDL.Text = "Nurse ID";
            // 
            // availableNursesL
            // 
            this.availableNursesL.AutoSize = true;
            this.availableNursesL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.availableNursesL.Location = new System.Drawing.Point(38, 80);
            this.availableNursesL.Name = "availableNursesL";
            this.availableNursesL.Size = new System.Drawing.Size(135, 20);
            this.availableNursesL.TabIndex = 6;
            this.availableNursesL.Text = "Available Nurses";
            // 
            // nurseIDTB
            // 
            this.nurseIDTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nurseIDTB.Location = new System.Drawing.Point(129, 376);
            this.nurseIDTB.Name = "nurseIDTB";
            this.nurseIDTB.Size = new System.Drawing.Size(240, 24);
            this.nurseIDTB.TabIndex = 7;
            // 
            // dateInfoL
            // 
            this.dateInfoL.AutoSize = true;
            this.dateInfoL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateInfoL.Location = new System.Drawing.Point(39, 419);
            this.dateInfoL.Name = "dateInfoL";
            this.dateInfoL.Size = new System.Drawing.Size(199, 18);
            this.dateInfoL.TabIndex = 8;
            this.dateInfoL.Text = "*Date Format: YYYY-MM-DD";
            // 
            // doctorAppointNurses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 481);
            this.Controls.Add(this.dateInfoL);
            this.Controls.Add(this.nurseIDTB);
            this.Controls.Add(this.availableNursesL);
            this.Controls.Add(this.nurseIDL);
            this.Controls.Add(this.dateTB);
            this.Controls.Add(this.dateL);
            this.Controls.Add(this.availableNursesDGV);
            this.Controls.Add(this.findB);
            this.Controls.Add(this.appointB);
            this.Name = "doctorAppointNurses";
            this.Text = "Appoint Nurse";
            ((System.ComponentModel.ISupportInitialize)(this.availableNursesDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button appointB;
        private System.Windows.Forms.Button findB;
        private System.Windows.Forms.DataGridView availableNursesDGV;
        private System.Windows.Forms.Label dateL;
        private System.Windows.Forms.TextBox dateTB;
        private System.Windows.Forms.Label nurseIDL;
        private System.Windows.Forms.Label availableNursesL;
        private System.Windows.Forms.TextBox nurseIDTB;
        private System.Windows.Forms.Label dateInfoL;
    }
}