namespace MainForm
{
    partial class adminLogin
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
            this.label1 = new System.Windows.Forms.Label();
            this.verifyB = new System.Windows.Forms.Button();
            this.keyTB = new System.Windows.Forms.TextBox();
            this.keyL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please enter the software provided key.";
            // 
            // verifyB
            // 
            this.verifyB.Location = new System.Drawing.Point(192, 69);
            this.verifyB.Name = "verifyB";
            this.verifyB.Size = new System.Drawing.Size(100, 30);
            this.verifyB.TabIndex = 1;
            this.verifyB.Text = "Verify";
            this.verifyB.UseVisualStyleBackColor = true;
            this.verifyB.Click += new System.EventHandler(this.button1_Click);
            // 
            // keyTB
            // 
            this.keyTB.Location = new System.Drawing.Point(86, 41);
            this.keyTB.Name = "keyTB";
            this.keyTB.Size = new System.Drawing.Size(205, 22);
            this.keyTB.TabIndex = 2;
            this.keyTB.UseSystemPasswordChar = true;
            // 
            // keyL
            // 
            this.keyL.AutoSize = true;
            this.keyL.Location = new System.Drawing.Point(34, 41);
            this.keyL.Name = "keyL";
            this.keyL.Size = new System.Drawing.Size(36, 17);
            this.keyL.TabIndex = 3;
            this.keyL.Text = "Key:";
            // 
            // adminLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 163);
            this.Controls.Add(this.keyL);
            this.Controls.Add(this.keyTB);
            this.Controls.Add(this.verifyB);
            this.Controls.Add(this.label1);
            this.Name = "adminLogin";
            this.Text = "Administrator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button verifyB;
        private System.Windows.Forms.TextBox keyTB;
        private System.Windows.Forms.Label keyL;
    }
}