namespace MainForm
{
    partial class pharmacistMain
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
            this.medicineIDL = new System.Windows.Forms.Label();
            this.medicineIDTB = new System.Windows.Forms.TextBox();
            this.viewB = new System.Windows.Forms.Button();
            this.viewAllB = new System.Windows.Forms.Button();
            this.reduceB = new System.Windows.Forms.Button();
            this.increaseB = new System.Windows.Forms.Button();
            this.addB = new System.Windows.Forms.Button();
            this.modifyB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // medicineIDL
            // 
            this.medicineIDL.AutoSize = true;
            this.medicineIDL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medicineIDL.Location = new System.Drawing.Point(33, 35);
            this.medicineIDL.Name = "medicineIDL";
            this.medicineIDL.Size = new System.Drawing.Size(103, 20);
            this.medicineIDL.TabIndex = 0;
            this.medicineIDL.Text = "Medicine ID:";
            // 
            // medicineIDTB
            // 
            this.medicineIDTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medicineIDTB.Location = new System.Drawing.Point(142, 33);
            this.medicineIDTB.Name = "medicineIDTB";
            this.medicineIDTB.Size = new System.Drawing.Size(180, 24);
            this.medicineIDTB.TabIndex = 1;
            // 
            // viewB
            // 
            this.viewB.Location = new System.Drawing.Point(328, 31);
            this.viewB.Name = "viewB";
            this.viewB.Size = new System.Drawing.Size(80, 30);
            this.viewB.TabIndex = 2;
            this.viewB.Text = "View";
            this.viewB.UseVisualStyleBackColor = true;
            this.viewB.Click += new System.EventHandler(this.viewB_Click);
            // 
            // viewAllB
            // 
            this.viewAllB.Location = new System.Drawing.Point(414, 31);
            this.viewAllB.Name = "viewAllB";
            this.viewAllB.Size = new System.Drawing.Size(80, 30);
            this.viewAllB.TabIndex = 3;
            this.viewAllB.Text = "View All";
            this.viewAllB.UseVisualStyleBackColor = true;
            this.viewAllB.Click += new System.EventHandler(this.viewAllB_Click);
            // 
            // reduceB
            // 
            this.reduceB.Location = new System.Drawing.Point(67, 86);
            this.reduceB.Name = "reduceB";
            this.reduceB.Size = new System.Drawing.Size(180, 30);
            this.reduceB.TabIndex = 4;
            this.reduceB.Text = "Reduce Quantity";
            this.reduceB.UseVisualStyleBackColor = true;
            this.reduceB.Click += new System.EventHandler(this.reduceB_Click);
            // 
            // increaseB
            // 
            this.increaseB.Location = new System.Drawing.Point(271, 86);
            this.increaseB.Name = "increaseB";
            this.increaseB.Size = new System.Drawing.Size(180, 30);
            this.increaseB.TabIndex = 5;
            this.increaseB.Text = "Increase Quantity";
            this.increaseB.UseVisualStyleBackColor = true;
            this.increaseB.Click += new System.EventHandler(this.increaseB_Click);
            // 
            // addB
            // 
            this.addB.Location = new System.Drawing.Point(67, 133);
            this.addB.Name = "addB";
            this.addB.Size = new System.Drawing.Size(230, 30);
            this.addB.TabIndex = 6;
            this.addB.Text = "Add a new Medicine";
            this.addB.UseVisualStyleBackColor = true;
            this.addB.Click += new System.EventHandler(this.addB_Click);
            // 
            // modifyB
            // 
            this.modifyB.Location = new System.Drawing.Point(308, 133);
            this.modifyB.Name = "modifyB";
            this.modifyB.Size = new System.Drawing.Size(140, 30);
            this.modifyB.TabIndex = 7;
            this.modifyB.Text = "Modify";
            this.modifyB.UseVisualStyleBackColor = true;
            this.modifyB.Click += new System.EventHandler(this.modifyB_Click);
            // 
            // pharmacistMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 190);
            this.Controls.Add(this.modifyB);
            this.Controls.Add(this.addB);
            this.Controls.Add(this.increaseB);
            this.Controls.Add(this.reduceB);
            this.Controls.Add(this.viewAllB);
            this.Controls.Add(this.viewB);
            this.Controls.Add(this.medicineIDTB);
            this.Controls.Add(this.medicineIDL);
            this.Name = "pharmacistMain";
            this.Text = "Pharmacist";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label medicineIDL;
        private System.Windows.Forms.TextBox medicineIDTB;
        private System.Windows.Forms.Button viewB;
        private System.Windows.Forms.Button viewAllB;
        private System.Windows.Forms.Button reduceB;
        private System.Windows.Forms.Button increaseB;
        private System.Windows.Forms.Button addB;
        private System.Windows.Forms.Button modifyB;
    }
}