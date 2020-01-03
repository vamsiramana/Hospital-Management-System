namespace MainForm
{
    partial class pharmacistQuantity
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
            this.medicineL = new System.Windows.Forms.Label();
            this.modifyB = new System.Windows.Forms.Button();
            this.modifyL = new System.Windows.Forms.Label();
            this.medicineIDTB = new System.Windows.Forms.TextBox();
            this.modifyTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // medicineL
            // 
            this.medicineL.AutoSize = true;
            this.medicineL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medicineL.Location = new System.Drawing.Point(45, 51);
            this.medicineL.Name = "medicineL";
            this.medicineL.Size = new System.Drawing.Size(103, 20);
            this.medicineL.TabIndex = 0;
            this.medicineL.Text = "Medicine ID:";
            // 
            // modifyB
            // 
            this.modifyB.Location = new System.Drawing.Point(244, 138);
            this.modifyB.Name = "modifyB";
            this.modifyB.Size = new System.Drawing.Size(90, 30);
            this.modifyB.TabIndex = 1;
            this.modifyB.Text = "Modify";
            this.modifyB.UseVisualStyleBackColor = true;
            this.modifyB.Click += new System.EventHandler(this.modifyB_Click);
            // 
            // modifyL
            // 
            this.modifyL.AutoSize = true;
            this.modifyL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyL.Location = new System.Drawing.Point(49, 100);
            this.modifyL.Name = "modifyL";
            this.modifyL.Size = new System.Drawing.Size(88, 20);
            this.modifyL.TabIndex = 2;
            this.modifyL.Text = "Modify By:";
            // 
            // medicineIDTB
            // 
            this.medicineIDTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medicineIDTB.Location = new System.Drawing.Point(154, 47);
            this.medicineIDTB.Name = "medicineIDTB";
            this.medicineIDTB.Size = new System.Drawing.Size(180, 24);
            this.medicineIDTB.TabIndex = 3;
            // 
            // modifyTB
            // 
            this.modifyTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyTB.Location = new System.Drawing.Point(154, 96);
            this.modifyTB.Name = "modifyTB";
            this.modifyTB.Size = new System.Drawing.Size(180, 24);
            this.modifyTB.TabIndex = 4;
            // 
            // pharmacistQuantity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 198);
            this.Controls.Add(this.modifyTB);
            this.Controls.Add(this.medicineIDTB);
            this.Controls.Add(this.modifyL);
            this.Controls.Add(this.modifyB);
            this.Controls.Add(this.medicineL);
            this.Name = "pharmacistQuantity";
            this.Text = "Modify Quantity";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label medicineL;
        private System.Windows.Forms.Button modifyB;
        private System.Windows.Forms.Label modifyL;
        private System.Windows.Forms.TextBox medicineIDTB;
        private System.Windows.Forms.TextBox modifyTB;
    }
}