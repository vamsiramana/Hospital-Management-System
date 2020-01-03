namespace MainForm
{
    partial class patientLoginForm
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
            this.oldB = new System.Windows.Forms.Button();
            this.newB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // oldB
            // 
            this.oldB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oldB.Location = new System.Drawing.Point(73, 22);
            this.oldB.Name = "oldB";
            this.oldB.Size = new System.Drawing.Size(120, 30);
            this.oldB.TabIndex = 0;
            this.oldB.Text = "Old";
            this.oldB.UseVisualStyleBackColor = true;
            this.oldB.Click += new System.EventHandler(this.oldB_Click);
            // 
            // newB
            // 
            this.newB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newB.Location = new System.Drawing.Point(73, 71);
            this.newB.Name = "newB";
            this.newB.Size = new System.Drawing.Size(120, 30);
            this.newB.TabIndex = 1;
            this.newB.Text = "New";
            this.newB.UseVisualStyleBackColor = true;
            this.newB.Click += new System.EventHandler(this.newB_Click);
            // 
            // patientLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 139);
            this.Controls.Add(this.newB);
            this.Controls.Add(this.oldB);
            this.Name = "patientLoginForm";
            this.Text = "Patient";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button oldB;
        private System.Windows.Forms.Button newB;
    }
}