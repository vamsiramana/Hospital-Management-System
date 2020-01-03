namespace MainForm
{
    partial class pharmacistAddMedicine
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
            this.addB = new System.Windows.Forms.Button();
            this.nameL = new System.Windows.Forms.Label();
            this.nameTB = new System.Windows.Forms.TextBox();
            this.manufacturerTB = new System.Windows.Forms.TextBox();
            this.manufacturerL = new System.Windows.Forms.Label();
            this.priceL = new System.Windows.Forms.Label();
            this.priceTB = new System.Windows.Forms.TextBox();
            this.quantityL = new System.Windows.Forms.Label();
            this.quantityTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // addB
            // 
            this.addB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addB.Location = new System.Drawing.Point(276, 198);
            this.addB.Name = "addB";
            this.addB.Size = new System.Drawing.Size(100, 30);
            this.addB.TabIndex = 0;
            this.addB.Text = "Add";
            this.addB.UseVisualStyleBackColor = true;
            this.addB.Click += new System.EventHandler(this.addB_Click);
            // 
            // nameL
            // 
            this.nameL.AutoSize = true;
            this.nameL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameL.Location = new System.Drawing.Point(37, 38);
            this.nameL.Name = "nameL";
            this.nameL.Size = new System.Drawing.Size(58, 20);
            this.nameL.TabIndex = 1;
            this.nameL.Text = "Name:";
            // 
            // nameTB
            // 
            this.nameTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTB.Location = new System.Drawing.Point(101, 36);
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(180, 24);
            this.nameTB.TabIndex = 2;
            // 
            // manufacturerTB
            // 
            this.manufacturerTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manufacturerTB.Location = new System.Drawing.Point(171, 79);
            this.manufacturerTB.Name = "manufacturerTB";
            this.manufacturerTB.Size = new System.Drawing.Size(180, 24);
            this.manufacturerTB.TabIndex = 3;
            // 
            // manufacturerL
            // 
            this.manufacturerL.AutoSize = true;
            this.manufacturerL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manufacturerL.Location = new System.Drawing.Point(37, 81);
            this.manufacturerL.Name = "manufacturerL";
            this.manufacturerL.Size = new System.Drawing.Size(118, 20);
            this.manufacturerL.TabIndex = 4;
            this.manufacturerL.Text = "Manufacturer: ";
            // 
            // priceL
            // 
            this.priceL.AutoSize = true;
            this.priceL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceL.Location = new System.Drawing.Point(37, 121);
            this.priceL.Name = "priceL";
            this.priceL.Size = new System.Drawing.Size(58, 20);
            this.priceL.TabIndex = 5;
            this.priceL.Text = "Price: ";
            // 
            // priceTB
            // 
            this.priceTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceTB.Location = new System.Drawing.Point(102, 121);
            this.priceTB.Name = "priceTB";
            this.priceTB.Size = new System.Drawing.Size(180, 24);
            this.priceTB.TabIndex = 6;
            // 
            // quantityL
            // 
            this.quantityL.AutoSize = true;
            this.quantityL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityL.Location = new System.Drawing.Point(37, 160);
            this.quantityL.Name = "quantityL";
            this.quantityL.Size = new System.Drawing.Size(76, 20);
            this.quantityL.TabIndex = 7;
            this.quantityL.Text = "Quantity:";
            // 
            // quantityTB
            // 
            this.quantityTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityTB.Location = new System.Drawing.Point(119, 158);
            this.quantityTB.Name = "quantityTB";
            this.quantityTB.Size = new System.Drawing.Size(180, 24);
            this.quantityTB.TabIndex = 8;
            // 
            // pharmacistAddMedicine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 251);
            this.Controls.Add(this.quantityTB);
            this.Controls.Add(this.quantityL);
            this.Controls.Add(this.priceTB);
            this.Controls.Add(this.priceL);
            this.Controls.Add(this.manufacturerL);
            this.Controls.Add(this.manufacturerTB);
            this.Controls.Add(this.nameTB);
            this.Controls.Add(this.nameL);
            this.Controls.Add(this.addB);
            this.Name = "pharmacistAddMedicine";
            this.Text = "Add Medicine";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addB;
        private System.Windows.Forms.Label nameL;
        private System.Windows.Forms.TextBox nameTB;
        private System.Windows.Forms.TextBox manufacturerTB;
        private System.Windows.Forms.Label manufacturerL;
        private System.Windows.Forms.Label priceL;
        private System.Windows.Forms.TextBox priceTB;
        private System.Windows.Forms.Label quantityL;
        private System.Windows.Forms.TextBox quantityTB;
    }
}