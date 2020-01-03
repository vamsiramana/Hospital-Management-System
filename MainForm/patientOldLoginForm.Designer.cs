namespace MainForm
{
    partial class patientOldLoginForm
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
            this.submitB = new System.Windows.Forms.Button();
            this.nameL = new System.Windows.Forms.Label();
            this.nameTB = new System.Windows.Forms.TextBox();
            this.symptomL = new System.Windows.Forms.Label();
            this.symptomTB = new System.Windows.Forms.TextBox();
            this.billsB = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.treatmentB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // submitB
            // 
            this.submitB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitB.Location = new System.Drawing.Point(291, 121);
            this.submitB.Name = "submitB";
            this.submitB.Size = new System.Drawing.Size(80, 30);
            this.submitB.TabIndex = 0;
            this.submitB.Text = "Submit";
            this.submitB.UseVisualStyleBackColor = true;
            this.submitB.Click += new System.EventHandler(this.loginB_Click);
            // 
            // nameL
            // 
            this.nameL.AutoSize = true;
            this.nameL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameL.Location = new System.Drawing.Point(64, 38);
            this.nameL.Name = "nameL";
            this.nameL.Size = new System.Drawing.Size(58, 20);
            this.nameL.TabIndex = 1;
            this.nameL.Text = "Name:";
            // 
            // nameTB
            // 
            this.nameTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTB.Location = new System.Drawing.Point(158, 38);
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(180, 24);
            this.nameTB.TabIndex = 2;
            // 
            // symptomL
            // 
            this.symptomL.AutoSize = true;
            this.symptomL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.symptomL.Location = new System.Drawing.Point(64, 85);
            this.symptomL.Name = "symptomL";
            this.symptomL.Size = new System.Drawing.Size(84, 20);
            this.symptomL.TabIndex = 3;
            this.symptomL.Text = "Symptom:";
            // 
            // symptomTB
            // 
            this.symptomTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.symptomTB.Location = new System.Drawing.Point(158, 83);
            this.symptomTB.Name = "symptomTB";
            this.symptomTB.Size = new System.Drawing.Size(180, 24);
            this.symptomTB.TabIndex = 4;
            // 
            // billsB
            // 
            this.billsB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billsB.Location = new System.Drawing.Point(205, 121);
            this.billsB.Name = "billsB";
            this.billsB.Size = new System.Drawing.Size(80, 30);
            this.billsB.TabIndex = 5;
            this.billsB.Text = "Bills";
            this.billsB.UseVisualStyleBackColor = true;
            this.billsB.Click += new System.EventHandler(this.billsB_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Enter Your Name Before Selecting ";
            // 
            // treatmentB
            // 
            this.treatmentB.Location = new System.Drawing.Point(39, 121);
            this.treatmentB.Name = "treatmentB";
            this.treatmentB.Size = new System.Drawing.Size(160, 30);
            this.treatmentB.TabIndex = 7;
            this.treatmentB.Text = "Treatment Date";
            this.treatmentB.UseVisualStyleBackColor = true;
            this.treatmentB.Click += new System.EventHandler(this.treatmentB_Click);
            // 
            // patientOldLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 210);
            this.Controls.Add(this.treatmentB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.billsB);
            this.Controls.Add(this.symptomTB);
            this.Controls.Add(this.symptomL);
            this.Controls.Add(this.nameTB);
            this.Controls.Add(this.nameL);
            this.Controls.Add(this.submitB);
            this.Name = "patientOldLoginForm";
            this.Text = "Old Patient";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button submitB;
        private System.Windows.Forms.Label nameL;
        private System.Windows.Forms.TextBox nameTB;
        private System.Windows.Forms.Label symptomL;
        private System.Windows.Forms.TextBox symptomTB;
        private System.Windows.Forms.Button billsB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button treatmentB;
    }
}