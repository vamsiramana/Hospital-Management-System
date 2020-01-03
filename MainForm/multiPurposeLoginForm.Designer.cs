namespace MainForm
{
    partial class multiPurposeLoginForm
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
            this.usernameL = new System.Windows.Forms.Label();
            this.passwordL = new System.Windows.Forms.Label();
            this.nameTB = new System.Windows.Forms.TextBox();
            this.passwordTB = new System.Windows.Forms.TextBox();
            this.proceedB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // usernameL
            // 
            this.usernameL.AutoSize = true;
            this.usernameL.Location = new System.Drawing.Point(58, 33);
            this.usernameL.Name = "usernameL";
            this.usernameL.Size = new System.Drawing.Size(49, 17);
            this.usernameL.TabIndex = 0;
            this.usernameL.Text = "Name:";
            // 
            // passwordL
            // 
            this.passwordL.AutoSize = true;
            this.passwordL.Location = new System.Drawing.Point(58, 76);
            this.passwordL.Name = "passwordL";
            this.passwordL.Size = new System.Drawing.Size(73, 17);
            this.passwordL.TabIndex = 1;
            this.passwordL.Text = "Password:";
            // 
            // nameTB
            // 
            this.nameTB.Location = new System.Drawing.Point(140, 33);
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(200, 22);
            this.nameTB.TabIndex = 2;
            // 
            // passwordTB
            // 
            this.passwordTB.Location = new System.Drawing.Point(140, 76);
            this.passwordTB.Name = "passwordTB";
            this.passwordTB.Size = new System.Drawing.Size(200, 22);
            this.passwordTB.TabIndex = 3;
            this.passwordTB.UseSystemPasswordChar = true;
            // 
            // proceedB
            // 
            this.proceedB.Location = new System.Drawing.Point(272, 110);
            this.proceedB.Name = "proceedB";
            this.proceedB.Size = new System.Drawing.Size(100, 30);
            this.proceedB.TabIndex = 4;
            this.proceedB.Text = "Proceed";
            this.proceedB.UseVisualStyleBackColor = true;
            this.proceedB.Click += new System.EventHandler(this.button1_Click);
            // 
            // multiPurposeLoginForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(394, 152);
            this.Controls.Add(this.proceedB);
            this.Controls.Add(this.passwordTB);
            this.Controls.Add(this.nameTB);
            this.Controls.Add(this.passwordL);
            this.Controls.Add(this.usernameL);
            this.Name = "multiPurposeLoginForm";
            this.Text = "Login Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label usernameL;
        private System.Windows.Forms.Label passwordL;
        private System.Windows.Forms.TextBox nameTB;
        private System.Windows.Forms.TextBox passwordTB;
        private System.Windows.Forms.Button proceedB;
    }
}