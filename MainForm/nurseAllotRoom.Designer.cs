namespace MainForm
{
    partial class nurseAllotRoom
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
            this.availableRoomsDGV = new System.Windows.Forms.DataGridView();
            this.availableRoomsL = new System.Windows.Forms.Label();
            this.allotB = new System.Windows.Forms.Button();
            this.patientIDL = new System.Windows.Forms.Label();
            this.roomIDL = new System.Windows.Forms.Label();
            this.patientIDTB = new System.Windows.Forms.TextBox();
            this.roomIDTB = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.availableRoomsDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // availableRoomsDGV
            // 
            this.availableRoomsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.availableRoomsDGV.Location = new System.Drawing.Point(39, 65);
            this.availableRoomsDGV.Name = "availableRoomsDGV";
            this.availableRoomsDGV.RowHeadersWidth = 51;
            this.availableRoomsDGV.RowTemplate.Height = 24;
            this.availableRoomsDGV.Size = new System.Drawing.Size(400, 300);
            this.availableRoomsDGV.TabIndex = 0;
            // 
            // availableRoomsL
            // 
            this.availableRoomsL.AutoSize = true;
            this.availableRoomsL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.availableRoomsL.Location = new System.Drawing.Point(163, 42);
            this.availableRoomsL.Name = "availableRoomsL";
            this.availableRoomsL.Size = new System.Drawing.Size(139, 20);
            this.availableRoomsL.TabIndex = 1;
            this.availableRoomsL.Text = "Available Rooms:";
            // 
            // allotB
            // 
            this.allotB.Location = new System.Drawing.Point(579, 281);
            this.allotB.Name = "allotB";
            this.allotB.Size = new System.Drawing.Size(100, 30);
            this.allotB.TabIndex = 2;
            this.allotB.Text = "Allot";
            this.allotB.UseVisualStyleBackColor = true;
            this.allotB.Click += new System.EventHandler(this.allotB_Click);
            // 
            // patientIDL
            // 
            this.patientIDL.AutoSize = true;
            this.patientIDL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientIDL.Location = new System.Drawing.Point(474, 119);
            this.patientIDL.Name = "patientIDL";
            this.patientIDL.Size = new System.Drawing.Size(75, 18);
            this.patientIDL.TabIndex = 3;
            this.patientIDL.Text = "Patient ID:";
            // 
            // roomIDL
            // 
            this.roomIDL.AutoSize = true;
            this.roomIDL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomIDL.Location = new System.Drawing.Point(477, 191);
            this.roomIDL.Name = "roomIDL";
            this.roomIDL.Size = new System.Drawing.Size(72, 18);
            this.roomIDL.TabIndex = 4;
            this.roomIDL.Text = "Room ID:";
            // 
            // patientIDTB
            // 
            this.patientIDTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientIDTB.Location = new System.Drawing.Point(519, 149);
            this.patientIDTB.Name = "patientIDTB";
            this.patientIDTB.Size = new System.Drawing.Size(160, 24);
            this.patientIDTB.TabIndex = 5;
            // 
            // roomIDTB
            // 
            this.roomIDTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomIDTB.Location = new System.Drawing.Point(519, 232);
            this.roomIDTB.Name = "roomIDTB";
            this.roomIDTB.Size = new System.Drawing.Size(160, 24);
            this.roomIDTB.TabIndex = 6;
            // 
            // nurseAllotRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 394);
            this.Controls.Add(this.roomIDTB);
            this.Controls.Add(this.patientIDTB);
            this.Controls.Add(this.roomIDL);
            this.Controls.Add(this.patientIDL);
            this.Controls.Add(this.allotB);
            this.Controls.Add(this.availableRoomsL);
            this.Controls.Add(this.availableRoomsDGV);
            this.Name = "nurseAllotRoom";
            this.Text = "Allot Rooms";
            ((System.ComponentModel.ISupportInitialize)(this.availableRoomsDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView availableRoomsDGV;
        private System.Windows.Forms.Label availableRoomsL;
        private System.Windows.Forms.Button allotB;
        private System.Windows.Forms.Label patientIDL;
        private System.Windows.Forms.Label roomIDL;
        private System.Windows.Forms.TextBox patientIDTB;
        private System.Windows.Forms.TextBox roomIDTB;
    }
}