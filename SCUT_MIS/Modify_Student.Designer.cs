namespace SCUT_MIS
{
    partial class Modify_Student
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
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.rbtn_Male = new System.Windows.Forms.RadioButton();
            this.rbtn_Female = new System.Windows.Forms.RadioButton();
            this.textBox_EntAge = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_EntYear = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_Class = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Modify Student Info";
            // 
            // label_instruction
            // 
            this.label_instruction.AutoSize = true;
            this.label_instruction.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label_instruction.Location = new System.Drawing.Point(15, 57);
            this.label_instruction.Name = "label_instruction";
            this.label_instruction.Size = new System.Drawing.Size(261, 18);
            this.label_instruction.TabIndex = 1;
            this.label_instruction.Text = "Select an existing student ID to modify.";
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
            this.label3.Size = new System.Drawing.Size(76, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Student ID";
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
            // textBox_Name
            // 
            this.textBox_Name.Enabled = false;
            this.textBox_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.textBox_Name.Location = new System.Drawing.Point(21, 223);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(220, 27);
            this.textBox_Name.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label6.Location = new System.Drawing.Point(18, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 18);
            this.label6.TabIndex = 7;
            this.label6.Text = "Student Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label7.Location = new System.Drawing.Point(260, 207);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 18);
            this.label7.TabIndex = 9;
            this.label7.Text = "Sex";
            // 
            // rbtn_Male
            // 
            this.rbtn_Male.AutoSize = true;
            this.rbtn_Male.Enabled = false;
            this.rbtn_Male.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rbtn_Male.Location = new System.Drawing.Point(263, 229);
            this.rbtn_Male.Name = "rbtn_Male";
            this.rbtn_Male.Size = new System.Drawing.Size(56, 21);
            this.rbtn_Male.TabIndex = 10;
            this.rbtn_Male.TabStop = true;
            this.rbtn_Male.Text = "Male";
            this.rbtn_Male.UseVisualStyleBackColor = true;
            // 
            // rbtn_Female
            // 
            this.rbtn_Female.AutoSize = true;
            this.rbtn_Female.Enabled = false;
            this.rbtn_Female.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rbtn_Female.Location = new System.Drawing.Point(325, 229);
            this.rbtn_Female.Name = "rbtn_Female";
            this.rbtn_Female.Size = new System.Drawing.Size(61, 21);
            this.rbtn_Female.TabIndex = 11;
            this.rbtn_Female.TabStop = true;
            this.rbtn_Female.Text = "Feale";
            this.rbtn_Female.UseVisualStyleBackColor = true;
            // 
            // textBox_EntAge
            // 
            this.textBox_EntAge.Enabled = false;
            this.textBox_EntAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.textBox_EntAge.Location = new System.Drawing.Point(22, 279);
            this.textBox_EntAge.Name = "textBox_EntAge";
            this.textBox_EntAge.Size = new System.Drawing.Size(123, 27);
            this.textBox_EntAge.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label8.Location = new System.Drawing.Point(18, 258);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 18);
            this.label8.TabIndex = 12;
            this.label8.Text = "Entrance Age";
            // 
            // textBox_EntYear
            // 
            this.textBox_EntYear.Enabled = false;
            this.textBox_EntYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.textBox_EntYear.Location = new System.Drawing.Point(154, 279);
            this.textBox_EntYear.Name = "textBox_EntYear";
            this.textBox_EntYear.Size = new System.Drawing.Size(122, 27);
            this.textBox_EntYear.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label9.Location = new System.Drawing.Point(151, 258);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 18);
            this.label9.TabIndex = 14;
            this.label9.Text = "Entrance Year";
            // 
            // textBox_Class
            // 
            this.textBox_Class.Enabled = false;
            this.textBox_Class.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.textBox_Class.Location = new System.Drawing.Point(21, 336);
            this.textBox_Class.Name = "textBox_Class";
            this.textBox_Class.Size = new System.Drawing.Size(140, 27);
            this.textBox_Class.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label10.Location = new System.Drawing.Point(18, 315);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 18);
            this.label10.TabIndex = 16;
            this.label10.Text = "Class";
            // 
            // btn_Save
            // 
            this.btn_Save.Enabled = false;
            this.btn_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_Save.Location = new System.Drawing.Point(18, 391);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(93, 26);
            this.btn_Save.TabIndex = 18;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_Exit.Location = new System.Drawing.Point(368, 420);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(68, 26);
            this.btn_Exit.TabIndex = 19;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // Modify_Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 460);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.textBox_Class);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox_EntYear);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox_EntAge);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.rbtn_Female);
            this.Controls.Add(this.rbtn_Male);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox_Name);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox_ID);
            this.Controls.Add(this.label_instruction);
            this.Controls.Add(this.label1);
            this.Name = "Modify_Student";
            this.Text = "SCUT MIS - Modify Student Info";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_instruction;
        private System.Windows.Forms.ComboBox comboBox_ID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rbtn_Male;
        private System.Windows.Forms.RadioButton rbtn_Female;
        private System.Windows.Forms.TextBox textBox_EntAge;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_EntYear;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_Class;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Exit;
    }
}