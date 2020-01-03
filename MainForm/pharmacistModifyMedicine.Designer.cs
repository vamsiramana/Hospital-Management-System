namespace MainForm
{
    partial class pharmacistModifyMedicine
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
            this.fillB = new System.Windows.Forms.Button();
            this.updateB = new System.Windows.Forms.Button();
            this.nameL = new System.Windows.Forms.Label();
            this.medicineNameTB = new System.Windows.Forms.TextBox();
            this.medicinePriceL = new System.Windows.Forms.Label();
            this.medicinePriceTB = new System.Windows.Forms.TextBox();
            this.quantityL = new System.Windows.Forms.Label();
            this.manufacturerL = new System.Windows.Forms.Label();
            this.medicineQuantityTB = new System.Windows.Forms.TextBox();
            this.medicineManufacturerTB = new System.Windows.Forms.TextBox();
            this.clearB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // medicineIDL
            // 
            this.medicineIDL.AutoSize = true;
            this.medicineIDL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medicineIDL.Location = new System.Drawing.Point(25, 24);
            this.medicineIDL.Name = "medicineIDL";
            this.medicineIDL.Size = new System.Drawing.Size(103, 20);
            this.medicineIDL.TabIndex = 0;
            this.medicineIDL.Text = "Medicine ID:";
            // 
            // medicineIDTB
            // 
            this.medicineIDTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medicineIDTB.Location = new System.Drawing.Point(134, 22);
            this.medicineIDTB.Name = "medicineIDTB";
            this.medicineIDTB.Size = new System.Drawing.Size(180, 24);
            this.medicineIDTB.TabIndex = 1;
            // 
            // fillB
            // 
            this.fillB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fillB.Location = new System.Drawing.Point(320, 19);
            this.fillB.Name = "fillB";
            this.fillB.Size = new System.Drawing.Size(80, 30);
            this.fillB.TabIndex = 2;
            this.fillB.Text = "Fill";
            this.fillB.UseVisualStyleBackColor = true;
            this.fillB.Click += new System.EventHandler(this.fillB_Click);
            // 
            // updateB
            // 
            this.updateB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateB.Location = new System.Drawing.Point(330, 182);
            this.updateB.Name = "updateB";
            this.updateB.Size = new System.Drawing.Size(80, 30);
            this.updateB.TabIndex = 3;
            this.updateB.Text = "Update";
            this.updateB.UseVisualStyleBackColor = true;
            this.updateB.Click += new System.EventHandler(this.updateB_Click);
            // 
            // nameL
            // 
            this.nameL.AutoSize = true;
            this.nameL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameL.Location = new System.Drawing.Point(25, 68);
            this.nameL.Name = "nameL";
            this.nameL.Size = new System.Drawing.Size(58, 20);
            this.nameL.TabIndex = 4;
            this.nameL.Text = "Name:";
            // 
            // medicineNameTB
            // 
            this.medicineNameTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medicineNameTB.Location = new System.Drawing.Point(89, 66);
            this.medicineNameTB.Name = "medicineNameTB";
            this.medicineNameTB.Size = new System.Drawing.Size(180, 24);
            this.medicineNameTB.TabIndex = 5;
            // 
            // medicinePriceL
            // 
            this.medicinePriceL.AutoSize = true;
            this.medicinePriceL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medicinePriceL.Location = new System.Drawing.Point(25, 111);
            this.medicinePriceL.Name = "medicinePriceL";
            this.medicinePriceL.Size = new System.Drawing.Size(53, 20);
            this.medicinePriceL.TabIndex = 6;
            this.medicinePriceL.Text = "Price:";
            // 
            // medicinePriceTB
            // 
            this.medicinePriceTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medicinePriceTB.Location = new System.Drawing.Point(89, 109);
            this.medicinePriceTB.Name = "medicinePriceTB";
            this.medicinePriceTB.Size = new System.Drawing.Size(180, 24);
            this.medicinePriceTB.TabIndex = 7;
            // 
            // quantityL
            // 
            this.quantityL.AutoSize = true;
            this.quantityL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityL.Location = new System.Drawing.Point(25, 150);
            this.quantityL.Name = "quantityL";
            this.quantityL.Size = new System.Drawing.Size(76, 20);
            this.quantityL.TabIndex = 8;
            this.quantityL.Text = "Quantity:";
            // 
            // manufacturerL
            // 
            this.manufacturerL.AutoSize = true;
            this.manufacturerL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manufacturerL.Location = new System.Drawing.Point(25, 187);
            this.manufacturerL.Name = "manufacturerL";
            this.manufacturerL.Size = new System.Drawing.Size(113, 20);
            this.manufacturerL.TabIndex = 9;
            this.manufacturerL.Text = "Manufacturer:";
            // 
            // medicineQuantityTB
            // 
            this.medicineQuantityTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medicineQuantityTB.Location = new System.Drawing.Point(107, 148);
            this.medicineQuantityTB.Name = "medicineQuantityTB";
            this.medicineQuantityTB.Size = new System.Drawing.Size(180, 24);
            this.medicineQuantityTB.TabIndex = 10;
            // 
            // medicineManufacturerTB
            // 
            this.medicineManufacturerTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medicineManufacturerTB.Location = new System.Drawing.Point(144, 185);
            this.medicineManufacturerTB.Name = "medicineManufacturerTB";
            this.medicineManufacturerTB.Size = new System.Drawing.Size(180, 24);
            this.medicineManufacturerTB.TabIndex = 11;
            // 
            // clearB
            // 
            this.clearB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearB.Location = new System.Drawing.Point(320, 66);
            this.clearB.Name = "clearB";
            this.clearB.Size = new System.Drawing.Size(80, 30);
            this.clearB.TabIndex = 12;
            this.clearB.Text = "Clear";
            this.clearB.UseVisualStyleBackColor = true;
            this.clearB.Click += new System.EventHandler(this.clearB_Click);
            // 
            // pharmacistModifyMedicine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 240);
            this.Controls.Add(this.clearB);
            this.Controls.Add(this.medicineManufacturerTB);
            this.Controls.Add(this.medicineQuantityTB);
            this.Controls.Add(this.manufacturerL);
            this.Controls.Add(this.quantityL);
            this.Controls.Add(this.medicinePriceTB);
            this.Controls.Add(this.medicinePriceL);
            this.Controls.Add(this.medicineNameTB);
            this.Controls.Add(this.nameL);
            this.Controls.Add(this.updateB);
            this.Controls.Add(this.fillB);
            this.Controls.Add(this.medicineIDTB);
            this.Controls.Add(this.medicineIDL);
            this.Name = "pharmacistModifyMedicine";
            this.Text = "Modify Medicine";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label medicineIDL;
        private System.Windows.Forms.TextBox medicineIDTB;
        private System.Windows.Forms.Button fillB;
        private System.Windows.Forms.Button updateB;
        private System.Windows.Forms.Label nameL;
        private System.Windows.Forms.TextBox medicineNameTB;
        private System.Windows.Forms.Label medicinePriceL;
        private System.Windows.Forms.TextBox medicinePriceTB;
        private System.Windows.Forms.Label quantityL;
        private System.Windows.Forms.Label manufacturerL;
        private System.Windows.Forms.TextBox medicineQuantityTB;
        private System.Windows.Forms.TextBox medicineManufacturerTB;
        private System.Windows.Forms.Button clearB;
    }
}