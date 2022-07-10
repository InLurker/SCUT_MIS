namespace SCUT_MIS
{
    partial class Delete_Course
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
            this.label_instruction = new System.Windows.Forms.Label();
            this.comboBox_ID = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label_Name = new System.Windows.Forms.Label();
            this.label_TID = new System.Windows.Forms.Label();
            this.label_Credit = new System.Windows.Forms.Label();
            this.label_Grade = new System.Windows.Forms.Label();
            this.label_CancelYear = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Delete Course Info";
            // 
            // label_instruction
            // 
            this.label_instruction.AutoSize = true;
            this.label_instruction.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label_instruction.Location = new System.Drawing.Point(15, 57);
            this.label_instruction.Name = "label_instruction";
            this.label_instruction.Size = new System.Drawing.Size(257, 18);
            this.label_instruction.TabIndex = 1;
            this.label_instruction.Text = "Select an existing Course ID to delete.";
            // 
            // comboBox_ID
            // 
            this.comboBox_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comboBox_ID.FormattingEnabled = true;
            this.comboBox_ID.Location = new System.Drawing.Point(21, 124);
            this.comboBox_ID.Name = "comboBox_ID";
            this.comboBox_ID.Size = new System.Drawing.Size(187, 28);
            this.comboBox_ID.TabIndex = 2;
            this.comboBox_ID.TextChanged += new System.EventHandler(this.comboBox_ID_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Course ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Details:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label6.Location = new System.Drawing.Point(18, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 18);
            this.label6.TabIndex = 7;
            this.label6.Text = "Course Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label8.Location = new System.Drawing.Point(18, 256);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 18);
            this.label8.TabIndex = 12;
            this.label8.Text = "Credit";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label9.Location = new System.Drawing.Point(18, 311);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 18);
            this.label9.TabIndex = 14;
            this.label9.Text = "Grade";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label10.Location = new System.Drawing.Point(18, 364);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(154, 18);
            this.label10.TabIndex = 16;
            this.label10.Text = "Cancel Year (Nullable)";
            // 
            // btn_Delete
            // 
            this.btn_Delete.Enabled = false;
            this.btn_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_Delete.Location = new System.Drawing.Point(18, 433);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(93, 26);
            this.btn_Delete.TabIndex = 18;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_Exit.Location = new System.Drawing.Point(334, 468);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(68, 26);
            this.btn_Exit.TabIndex = 19;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label2.Location = new System.Drawing.Point(244, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 18);
            this.label2.TabIndex = 20;
            this.label2.Text = "Teacher ID";
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label_Name.Location = new System.Drawing.Point(17, 220);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(61, 24);
            this.label_Name.TabIndex = 21;
            this.label_Name.Text = "Name";
            // 
            // label_TID
            // 
            this.label_TID.AutoSize = true;
            this.label_TID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label_TID.Location = new System.Drawing.Point(243, 220);
            this.label_TID.Name = "label_TID";
            this.label_TID.Size = new System.Drawing.Size(81, 24);
            this.label_TID.TabIndex = 22;
            this.label_TID.Text = "Teacher";
            // 
            // label_Credit
            // 
            this.label_Credit.AutoSize = true;
            this.label_Credit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label_Credit.Location = new System.Drawing.Point(17, 274);
            this.label_Credit.Name = "label_Credit";
            this.label_Credit.Size = new System.Drawing.Size(59, 24);
            this.label_Credit.TabIndex = 23;
            this.label_Credit.Text = "Credit";
            // 
            // label_Grade
            // 
            this.label_Grade.AutoSize = true;
            this.label_Grade.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label_Grade.Location = new System.Drawing.Point(17, 329);
            this.label_Grade.Name = "label_Grade";
            this.label_Grade.Size = new System.Drawing.Size(62, 24);
            this.label_Grade.TabIndex = 24;
            this.label_Grade.Text = "Grade";
            // 
            // label_CancelYear
            // 
            this.label_CancelYear.AutoSize = true;
            this.label_CancelYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label_CancelYear.Location = new System.Drawing.Point(17, 382);
            this.label_CancelYear.Name = "label_CancelYear";
            this.label_CancelYear.Size = new System.Drawing.Size(113, 24);
            this.label_CancelYear.TabIndex = 25;
            this.label_CancelYear.Text = "Cancel Year";
            // 
            // Delete_Course
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 506);
            this.Controls.Add(this.label_CancelYear);
            this.Controls.Add(this.label_Grade);
            this.Controls.Add(this.label_Credit);
            this.Controls.Add(this.label_TID);
            this.Controls.Add(this.label_Name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox_ID);
            this.Controls.Add(this.label_instruction);
            this.Controls.Add(this.label1);
            this.Name = "Delete_Course";
            this.Text = "SCUT MIS - Delete Course Info";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_instruction;
        private System.Windows.Forms.ComboBox comboBox_ID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.Label label_TID;
        private System.Windows.Forms.Label label_Credit;
        private System.Windows.Forms.Label label_Grade;
        private System.Windows.Forms.Label label_CancelYear;
    }
}