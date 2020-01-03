namespace MainForm
{
    partial class internDiagnose
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
            this.updateB = new System.Windows.Forms.Button();
            this.patientIDTB = new System.Windows.Forms.TextBox();
            this.oldSymptomTB = new System.Windows.Forms.TextBox();
            this.diagnosisTB = new System.Windows.Forms.TextBox();
            this.patientIDL = new System.Windows.Forms.Label();
            this.oldSymptomL = new System.Windows.Forms.Label();
            this.diagnosisL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // updateB
            // 
            this.updateB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateB.Location = new System.Drawing.Point(274, 159);
            this.updateB.Name = "updateB";
            this.updateB.Size = new System.Drawing.Size(100, 30);
            this.updateB.TabIndex = 0;
            this.updateB.Text = "Update";
            this.updateB.UseVisualStyleBackColor = true;
            this.updateB.Click += new System.EventHandler(this.updateB_Click);
            // 
            // patientIDTB
            // 
            this.patientIDTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientIDTB.Location = new System.Drawing.Point(194, 36);
            this.patientIDTB.Name = "patientIDTB";
            this.patientIDTB.Size = new System.Drawing.Size(180, 24);
            this.patientIDTB.TabIndex = 1;
            // 
            // oldSymptomTB
            // 
            this.oldSymptomTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oldSymptomTB.Location = new System.Drawing.Point(194, 77);
            this.oldSymptomTB.Name = "oldSymptomTB";
            this.oldSymptomTB.Size = new System.Drawing.Size(180, 24);
            this.oldSymptomTB.TabIndex = 2;
            // 
            // diagnosisTB
            // 
            this.diagnosisTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diagnosisTB.Location = new System.Drawing.Point(194, 119);
            this.diagnosisTB.Name = "diagnosisTB";
            this.diagnosisTB.Size = new System.Drawing.Size(180, 24);
            this.diagnosisTB.TabIndex = 3;
            // 
            // patientIDL
            // 
            this.patientIDL.AutoSize = true;
            this.patientIDL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientIDL.Location = new System.Drawing.Point(32, 38);
            this.patientIDL.Name = "patientIDL";
            this.patientIDL.Size = new System.Drawing.Size(93, 20);
            this.patientIDL.TabIndex = 4;
            this.patientIDL.Text = "Patient ID: ";
            // 
            // oldSymptomL
            // 
            this.oldSymptomL.AutoSize = true;
            this.oldSymptomL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oldSymptomL.Location = new System.Drawing.Point(32, 79);
            this.oldSymptomL.Name = "oldSymptomL";
            this.oldSymptomL.Size = new System.Drawing.Size(115, 20);
            this.oldSymptomL.TabIndex = 5;
            this.oldSymptomL.Text = "Old Symptom:";
            // 
            // diagnosisL
            // 
            this.diagnosisL.AutoSize = true;
            this.diagnosisL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diagnosisL.Location = new System.Drawing.Point(32, 121);
            this.diagnosisL.Name = "diagnosisL";
            this.diagnosisL.Size = new System.Drawing.Size(89, 20);
            this.diagnosisL.TabIndex = 6;
            this.diagnosisL.Text = "Diagnosis:";
            // 
            // internDiagnose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 214);
            this.Controls.Add(this.diagnosisL);
            this.Controls.Add(this.oldSymptomL);
            this.Controls.Add(this.patientIDL);
            this.Controls.Add(this.diagnosisTB);
            this.Controls.Add(this.oldSymptomTB);
            this.Controls.Add(this.patientIDTB);
            this.Controls.Add(this.updateB);
            this.Name = "internDiagnose";
            this.Text = "Update Diagnosis";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button updateB;
        private System.Windows.Forms.TextBox patientIDTB;
        private System.Windows.Forms.TextBox oldSymptomTB;
        private System.Windows.Forms.TextBox diagnosisTB;
        private System.Windows.Forms.Label patientIDL;
        private System.Windows.Forms.Label oldSymptomL;
        private System.Windows.Forms.Label diagnosisL;
    }
}