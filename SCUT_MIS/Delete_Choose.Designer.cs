namespace SCUT_MIS
{
    partial class Delete_Choose
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
            this.comboBox_CID = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_TID = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox_SID = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_Search = new System.Windows.Forms.Button();
            this.label_SID = new System.Windows.Forms.Label();
            this.label_CID = new System.Windows.Forms.Label();
            this.label_TID = new System.Windows.Forms.Label();
            this.label_ChosenYear = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Delete Course Choosing";
            // 
            // label_instruction
            // 
            this.label_instruction.AutoSize = true;
            this.label_instruction.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label_instruction.Location = new System.Drawing.Point(15, 57);
            this.label_instruction.Name = "label_instruction";
            this.label_instruction.Size = new System.Drawing.Size(222, 18);
            this.label_instruction.TabIndex = 1;
            this.label_instruction.Text = "Select an existing entry to delete.";
            // 
            // comboBox_CID
            // 
            this.comboBox_CID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comboBox_CID.FormattingEnabled = true;
            this.comboBox_CID.Location = new System.Drawing.Point(205, 124);
            this.comboBox_CID.Name = "comboBox_CID";
            this.comboBox_CID.Size = new System.Drawing.Size(149, 28);
            this.comboBox_CID.TabIndex = 2;
            this.comboBox_CID.TextChanged += new System.EventHandler(this.comboBox_ID_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(202, 103);
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
            // btn_Delete
            // 
            this.btn_Delete.Enabled = false;
            this.btn_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_Delete.Location = new System.Drawing.Point(21, 430);
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
            this.btn_Exit.Location = new System.Drawing.Point(505, 468);
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
            this.label2.Location = new System.Drawing.Point(357, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 18);
            this.label2.TabIndex = 20;
            this.label2.Text = "Teacher ID";
            // 
            // comboBox_TID
            // 
            this.comboBox_TID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.comboBox_TID.FormattingEnabled = true;
            this.comboBox_TID.Location = new System.Drawing.Point(360, 124);
            this.comboBox_TID.Name = "comboBox_TID";
            this.comboBox_TID.Size = new System.Drawing.Size(121, 28);
            this.comboBox_TID.TabIndex = 21;
            this.comboBox_TID.TextChanged += new System.EventHandler(this.comboBox_ID_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 18);
            this.label4.TabIndex = 23;
            this.label4.Text = "Student ID";
            // 
            // comboBox_SID
            // 
            this.comboBox_SID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comboBox_SID.FormattingEnabled = true;
            this.comboBox_SID.Location = new System.Drawing.Point(22, 124);
            this.comboBox_SID.Name = "comboBox_SID";
            this.comboBox_SID.Size = new System.Drawing.Size(177, 28);
            this.comboBox_SID.TabIndex = 22;
            this.comboBox_SID.TextChanged += new System.EventHandler(this.comboBox_ID_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 18);
            this.label6.TabIndex = 29;
            this.label6.Text = "Student ID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label7.Location = new System.Drawing.Point(19, 310);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 18);
            this.label7.TabIndex = 26;
            this.label7.Text = "Teacher ID";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(19, 256);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 18);
            this.label8.TabIndex = 25;
            this.label8.Text = "Course ID";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label9.Location = new System.Drawing.Point(20, 363);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 18);
            this.label9.TabIndex = 31;
            this.label9.Text = "Chosen Year";
            // 
            // btn_Search
            // 
            this.btn_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_Search.Location = new System.Drawing.Point(487, 124);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(75, 28);
            this.btn_Search.TabIndex = 32;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // label_SID
            // 
            this.label_SID.AutoSize = true;
            this.label_SID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label_SID.Location = new System.Drawing.Point(17, 221);
            this.label_SID.Name = "label_SID";
            this.label_SID.Size = new System.Drawing.Size(74, 24);
            this.label_SID.TabIndex = 33;
            this.label_SID.Text = "Student";
            // 
            // label_CID
            // 
            this.label_CID.AutoSize = true;
            this.label_CID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label_CID.Location = new System.Drawing.Point(17, 274);
            this.label_CID.Name = "label_CID";
            this.label_CID.Size = new System.Drawing.Size(71, 24);
            this.label_CID.TabIndex = 34;
            this.label_CID.Text = "Course";
            // 
            // label_TID
            // 
            this.label_TID.AutoSize = true;
            this.label_TID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label_TID.Location = new System.Drawing.Point(17, 328);
            this.label_TID.Name = "label_TID";
            this.label_TID.Size = new System.Drawing.Size(81, 24);
            this.label_TID.TabIndex = 35;
            this.label_TID.Text = "Teacher";
            // 
            // label_ChosenYear
            // 
            this.label_ChosenYear.AutoSize = true;
            this.label_ChosenYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label_ChosenYear.Location = new System.Drawing.Point(17, 381);
            this.label_ChosenYear.Name = "label_ChosenYear";
            this.label_ChosenYear.Size = new System.Drawing.Size(120, 24);
            this.label_ChosenYear.TabIndex = 36;
            this.label_ChosenYear.Text = "Chosen Year";
            // 
            // Delete_Choose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 506);
            this.Controls.Add(this.label_ChosenYear);
            this.Controls.Add(this.label_TID);
            this.Controls.Add(this.label_CID);
            this.Controls.Add(this.label_SID);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox_SID);
            this.Controls.Add(this.comboBox_TID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox_CID);
            this.Controls.Add(this.label_instruction);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Delete_Choose";
            this.Text = "SCUT MIS - Delete Course Choosing";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_instruction;
        private System.Windows.Forms.ComboBox comboBox_CID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_TID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox_SID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Label label_SID;
        private System.Windows.Forms.Label label_CID;
        private System.Windows.Forms.Label label_TID;
        private System.Windows.Forms.Label label_ChosenYear;
    }
}