namespace MainForm
{
    partial class patientNewLoginForm
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
            this.nameL = new System.Windows.Forms.Label();
            this.Gender = new System.Windows.Forms.Label();
            this.ageL = new System.Windows.Forms.Label();
            this.symptomL = new System.Windows.Forms.Label();
            this.nameTB = new System.Windows.Forms.TextBox();
            this.genderTB = new System.Windows.Forms.TextBox();
            this.ageTB = new System.Windows.Forms.TextBox();
            this.symptomTB = new System.Windows.Forms.TextBox();
            this.submitB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameL
            // 
            this.nameL.AutoSize = true;
            this.nameL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameL.Location = new System.Drawing.Point(45, 31);
            this.nameL.Name = "nameL";
            this.nameL.Size = new System.Drawing.Size(58, 20);
            this.nameL.TabIndex = 0;
            this.nameL.Text = "Name:";
            // 
            // Gender
            // 
            this.Gender.AutoSize = true;
            this.Gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gender.Location = new System.Drawing.Point(45, 71);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(69, 20);
            this.Gender.TabIndex = 1;
            this.Gender.Text = "Gender:";
            // 
            // ageL
            // 
            this.ageL.AutoSize = true;
            this.ageL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ageL.Location = new System.Drawing.Point(45, 113);
            this.ageL.Name = "ageL";
            this.ageL.Size = new System.Drawing.Size(43, 20);
            this.ageL.TabIndex = 2;
            this.ageL.Text = "Age:";
            // 
            // symptomL
            // 
            this.symptomL.AutoSize = true;
            this.symptomL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.symptomL.Location = new System.Drawing.Point(45, 153);
            this.symptomL.Name = "symptomL";
            this.symptomL.Size = new System.Drawing.Size(84, 20);
            this.symptomL.TabIndex = 3;
            this.symptomL.Text = "Symptom:";
            // 
            // nameTB
            // 
            this.nameTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTB.Location = new System.Drawing.Point(154, 31);
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(180, 24);
            this.nameTB.TabIndex = 4;
            // 
            // genderTB
            // 
            this.genderTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderTB.Location = new System.Drawing.Point(154, 71);
            this.genderTB.Name = "genderTB";
            this.genderTB.Size = new System.Drawing.Size(180, 24);
            this.genderTB.TabIndex = 5;
            // 
            // ageTB
            // 
            this.ageTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ageTB.Location = new System.Drawing.Point(154, 110);
            this.ageTB.Name = "ageTB";
            this.ageTB.Size = new System.Drawing.Size(180, 24);
            this.ageTB.TabIndex = 6;
            // 
            // symptomTB
            // 
            this.symptomTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.symptomTB.Location = new System.Drawing.Point(154, 153);
            this.symptomTB.Name = "symptomTB";
            this.symptomTB.Size = new System.Drawing.Size(180, 24);
            this.symptomTB.TabIndex = 7;
            // 
            // submitB
            // 
            this.submitB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitB.Location = new System.Drawing.Point(252, 195);
            this.submitB.Name = "submitB";
            this.submitB.Size = new System.Drawing.Size(100, 30);
            this.submitB.TabIndex = 8;
            this.submitB.Text = "Submit";
            this.submitB.UseVisualStyleBackColor = true;
            this.submitB.Click += new System.EventHandler(this.loginB_Click);
            // 
            // patientNewLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 254);
            this.Controls.Add(this.submitB);
            this.Controls.Add(this.symptomTB);
            this.Controls.Add(this.ageTB);
            this.Controls.Add(this.genderTB);
            this.Controls.Add(this.nameTB);
            this.Controls.Add(this.symptomL);
            this.Controls.Add(this.ageL);
            this.Controls.Add(this.Gender);
            this.Controls.Add(this.nameL);
            this.Name = "patientNewLoginForm";
            this.Text = "New Patient";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameL;
        private System.Windows.Forms.Label Gender;
        private System.Windows.Forms.Label ageL;
        private System.Windows.Forms.Label symptomL;
        private System.Windows.Forms.TextBox nameTB;
        private System.Windows.Forms.TextBox genderTB;
        private System.Windows.Forms.TextBox ageTB;
        private System.Windows.Forms.TextBox symptomTB;
        private System.Windows.Forms.Button submitB;
    }
}