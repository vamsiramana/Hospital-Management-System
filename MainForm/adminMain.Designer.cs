namespace MainForm
{
    partial class adminMain
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
            this.tableNamesdB = new System.Windows.Forms.ComboBox();
            this.queryL = new System.Windows.Forms.Label();
            this.availableL = new System.Windows.Forms.Label();
            this.queryTB = new System.Windows.Forms.RichTextBox();
            this.notSelectRB = new System.Windows.Forms.RadioButton();
            this.selectRB = new System.Windows.Forms.RadioButton();
            this.typeL = new System.Windows.Forms.Label();
            this.runB = new System.Windows.Forms.Button();
            this.selectQueryDGV = new System.Windows.Forms.DataGridView();
            this.clearB = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.selectQueryDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // tableNamesdB
            // 
            this.tableNamesdB.FormattingEnabled = true;
            this.tableNamesdB.Location = new System.Drawing.Point(28, 266);
            this.tableNamesdB.Name = "tableNamesdB";
            this.tableNamesdB.Size = new System.Drawing.Size(150, 24);
            this.tableNamesdB.TabIndex = 4;
            // 
            // queryL
            // 
            this.queryL.AutoSize = true;
            this.queryL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.queryL.Location = new System.Drawing.Point(24, 31);
            this.queryL.Name = "queryL";
            this.queryL.Size = new System.Drawing.Size(99, 20);
            this.queryL.TabIndex = 5;
            this.queryL.Text = "Enter Query";
            // 
            // availableL
            // 
            this.availableL.AutoSize = true;
            this.availableL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.availableL.Location = new System.Drawing.Point(24, 234);
            this.availableL.Name = "availableL";
            this.availableL.Size = new System.Drawing.Size(136, 20);
            this.availableL.TabIndex = 6;
            this.availableL.Text = "Available Tables:";
            // 
            // queryTB
            // 
            this.queryTB.Location = new System.Drawing.Point(28, 64);
            this.queryTB.Name = "queryTB";
            this.queryTB.Size = new System.Drawing.Size(440, 110);
            this.queryTB.TabIndex = 7;
            this.queryTB.Text = "";
            this.queryTB.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // notSelectRB
            // 
            this.notSelectRB.AutoSize = true;
            this.notSelectRB.Location = new System.Drawing.Point(214, 269);
            this.notSelectRB.Name = "notSelectRB";
            this.notSelectRB.Size = new System.Drawing.Size(94, 21);
            this.notSelectRB.TabIndex = 8;
            this.notSelectRB.Text = "Not Select";
            this.notSelectRB.UseVisualStyleBackColor = true;
            this.notSelectRB.CheckedChanged += new System.EventHandler(this.notSelectRB_CheckedChanged);
            // 
            // selectRB
            // 
            this.selectRB.AutoSize = true;
            this.selectRB.Checked = true;
            this.selectRB.Location = new System.Drawing.Point(355, 269);
            this.selectRB.Name = "selectRB";
            this.selectRB.Size = new System.Drawing.Size(68, 21);
            this.selectRB.TabIndex = 9;
            this.selectRB.TabStop = true;
            this.selectRB.Text = "Select";
            this.selectRB.UseVisualStyleBackColor = true;
            this.selectRB.CheckedChanged += new System.EventHandler(this.selectRB_CheckedChanged);
            // 
            // typeL
            // 
            this.typeL.AutoSize = true;
            this.typeL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeL.Location = new System.Drawing.Point(214, 234);
            this.typeL.Name = "typeL";
            this.typeL.Size = new System.Drawing.Size(119, 20);
            this.typeL.TabIndex = 10;
            this.typeL.Text = "Type of Query:";
            // 
            // runB
            // 
            this.runB.Location = new System.Drawing.Point(384, 190);
            this.runB.Name = "runB";
            this.runB.Size = new System.Drawing.Size(80, 30);
            this.runB.TabIndex = 11;
            this.runB.Text = "Run";
            this.runB.UseVisualStyleBackColor = true;
            this.runB.Click += new System.EventHandler(this.runB_Click);
            // 
            // selectQueryDGV
            // 
            this.selectQueryDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.selectQueryDGV.Location = new System.Drawing.Point(28, 312);
            this.selectQueryDGV.Name = "selectQueryDGV";
            this.selectQueryDGV.RowHeadersWidth = 51;
            this.selectQueryDGV.RowTemplate.Height = 24;
            this.selectQueryDGV.Size = new System.Drawing.Size(440, 240);
            this.selectQueryDGV.TabIndex = 12;
            // 
            // clearB
            // 
            this.clearB.Location = new System.Drawing.Point(298, 190);
            this.clearB.Name = "clearB";
            this.clearB.Size = new System.Drawing.Size(80, 30);
            this.clearB.TabIndex = 13;
            this.clearB.Text = "Clear";
            this.clearB.UseVisualStyleBackColor = true;
            this.clearB.Click += new System.EventHandler(this.button1_Click);
            // 
            // adminMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 598);
            this.Controls.Add(this.clearB);
            this.Controls.Add(this.selectQueryDGV);
            this.Controls.Add(this.runB);
            this.Controls.Add(this.typeL);
            this.Controls.Add(this.selectRB);
            this.Controls.Add(this.notSelectRB);
            this.Controls.Add(this.queryTB);
            this.Controls.Add(this.availableL);
            this.Controls.Add(this.queryL);
            this.Controls.Add(this.tableNamesdB);
            this.Name = "adminMain";
            this.Text = "Admin";
            ((System.ComponentModel.ISupportInitialize)(this.selectQueryDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox tableNamesdB;
        private System.Windows.Forms.Label queryL;
        private System.Windows.Forms.Label availableL;
        private System.Windows.Forms.RichTextBox queryTB;
        private System.Windows.Forms.RadioButton notSelectRB;
        private System.Windows.Forms.RadioButton selectRB;
        private System.Windows.Forms.Label typeL;
        private System.Windows.Forms.Button runB;
        private System.Windows.Forms.DataGridView selectQueryDGV;
        private System.Windows.Forms.Button clearB;
    }
}