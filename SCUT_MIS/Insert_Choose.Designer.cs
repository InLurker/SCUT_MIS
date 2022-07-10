namespace SCUT_MIS
{
    partial class Insert_Choose
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
            this.label2 = new System.Windows.Forms.Label();
            this.label_instruction = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_ChosenYear = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_Confirm = new System.Windows.Forms.Button();
            this.comboBox_TID = new System.Windows.Forms.ComboBox();
            this.comboBox_CID = new System.Windows.Forms.ComboBox();
            this.comboBox_SID = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(25, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(357, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "New Course Choosing Entry";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(26, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Student ID";
            // 
            // label_instruction
            // 
            this.label_instruction.AutoSize = true;
            this.label_instruction.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label_instruction.Location = new System.Drawing.Point(27, 99);
            this.label_instruction.Name = "label_instruction";
            this.label_instruction.Size = new System.Drawing.Size(347, 18);
            this.label_instruction.TabIndex = 3;
            this.label_instruction.Text = "Please enter course details. (cancel year is nullable)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label4.Location = new System.Drawing.Point(26, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "Course ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label5.Location = new System.Drawing.Point(26, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 24);
            this.label5.TabIndex = 6;
            this.label5.Text = "Teacher ID";
            // 
            // textBox_ChosenYear
            // 
            this.textBox_ChosenYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.textBox_ChosenYear.Location = new System.Drawing.Point(158, 228);
            this.textBox_ChosenYear.Name = "textBox_ChosenYear";
            this.textBox_ChosenYear.Size = new System.Drawing.Size(161, 27);
            this.textBox_ChosenYear.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label8.Location = new System.Drawing.Point(27, 231);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 24);
            this.label8.TabIndex = 12;
            this.label8.Text = "Chosen Year";
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_Exit.Location = new System.Drawing.Point(331, 295);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(68, 26);
            this.btn_Exit.TabIndex = 15;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_Confirm
            // 
            this.btn_Confirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_Confirm.Location = new System.Drawing.Point(152, 272);
            this.btn_Confirm.Name = "btn_Confirm";
            this.btn_Confirm.Size = new System.Drawing.Size(103, 26);
            this.btn_Confirm.TabIndex = 14;
            this.btn_Confirm.Text = "Confirm";
            this.btn_Confirm.UseVisualStyleBackColor = true;
            this.btn_Confirm.Click += new System.EventHandler(this.btn_Confirm_Click);
            // 
            // comboBox_TID
            // 
            this.comboBox_TID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.comboBox_TID.FormattingEnabled = true;
            this.comboBox_TID.Location = new System.Drawing.Point(158, 194);
            this.comboBox_TID.Name = "comboBox_TID";
            this.comboBox_TID.Size = new System.Drawing.Size(161, 28);
            this.comboBox_TID.TabIndex = 16;
            // 
            // comboBox_CID
            // 
            this.comboBox_CID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.comboBox_CID.FormattingEnabled = true;
            this.comboBox_CID.Location = new System.Drawing.Point(158, 161);
            this.comboBox_CID.Name = "comboBox_CID";
            this.comboBox_CID.Size = new System.Drawing.Size(161, 28);
            this.comboBox_CID.TabIndex = 16;
            // 
            // comboBox_SID
            // 
            this.comboBox_SID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.comboBox_SID.FormattingEnabled = true;
            this.comboBox_SID.Location = new System.Drawing.Point(158, 128);
            this.comboBox_SID.Name = "comboBox_SID";
            this.comboBox_SID.Size = new System.Drawing.Size(216, 28);
            this.comboBox_SID.TabIndex = 16;
            // 
            // Insert_Choose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 333);
            this.Controls.Add(this.comboBox_SID);
            this.Controls.Add(this.comboBox_CID);
            this.Controls.Add(this.comboBox_TID);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Confirm);
            this.Controls.Add(this.textBox_ChosenYear);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label_instruction);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Insert_Choose";
            this.Text = "SCUT MIS - Insert New Course";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_instruction;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_ChosenYear;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_Confirm;
        private System.Windows.Forms.ComboBox comboBox_TID;
        private System.Windows.Forms.ComboBox comboBox_CID;
        private System.Windows.Forms.ComboBox comboBox_SID;
    }
}