namespace SCUT_MIS
{
    partial class Portal_Admin
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
            this.label_Username = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.label_Instruction = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.rbtn_Students = new System.Windows.Forms.RadioButton();
            this.rbtn_Teachers = new System.Windows.Forms.RadioButton();
            this.rbtn_Courses = new System.Windows.Forms.RadioButton();
            this.rbtn_Choose = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Stu_Insert = new System.Windows.Forms.Button();
            this.btn_Stu_Modify = new System.Windows.Forms.Button();
            this.btn_Stu_Delete = new System.Windows.Forms.Button();
            this.btn_Courses_Delete = new System.Windows.Forms.Button();
            this.btn_Courses_Modify = new System.Windows.Forms.Button();
            this.btn_Courses_Insert = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_Choose_Delete = new System.Windows.Forms.Button();
            this.btn_Choose_Modify = new System.Windows.Forms.Button();
            this.btn_Choose_Insert = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_Teacher_Delete = new System.Windows.Forms.Button();
            this.btn_Teacher_Modify = new System.Windows.Forms.Button();
            this.btn_Teacher_Insert = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(825, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "You\'re logged in as";
            // 
            // label_Username
            // 
            this.label_Username.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label_Username.Location = new System.Drawing.Point(680, 40);
            this.label_Username.Name = "label_Username";
            this.label_Username.Size = new System.Drawing.Size(289, 31);
            this.label_Username.TabIndex = 1;
            this.label_Username.Text = "Username";
            this.label_Username.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.label3.Location = new System.Drawing.Point(21, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(249, 46);
            this.label3.TabIndex = 2;
            this.label3.Text = "Admin Portal";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label4.Location = new System.Drawing.Point(29, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "SCUT MIS";
            // 
            // btn_Exit
            // 
            this.btn_Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Exit.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_Exit.Location = new System.Drawing.Point(874, 502);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(95, 29);
            this.btn_Exit.TabIndex = 11;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // label_Instruction
            // 
            this.label_Instruction.AutoSize = true;
            this.label_Instruction.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label_Instruction.Location = new System.Drawing.Point(25, 118);
            this.label_Instruction.Name = "label_Instruction";
            this.label_Instruction.Size = new System.Drawing.Size(124, 22);
            this.label_Instruction.TabIndex = 6;
            this.label_Instruction.Text = "Select a table.";
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToOrderColumns = true;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(29, 176);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(520, 318);
            this.dataGridView.TabIndex = 5;
            // 
            // rbtn_Students
            // 
            this.rbtn_Students.AutoSize = true;
            this.rbtn_Students.Checked = true;
            this.rbtn_Students.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rbtn_Students.Location = new System.Drawing.Point(29, 144);
            this.rbtn_Students.Name = "rbtn_Students";
            this.rbtn_Students.Size = new System.Drawing.Size(82, 21);
            this.rbtn_Students.TabIndex = 12;
            this.rbtn_Students.TabStop = true;
            this.rbtn_Students.Text = "Students";
            this.rbtn_Students.UseVisualStyleBackColor = true;
            this.rbtn_Students.Click += new System.EventHandler(this.rbtn_OnClick);
            // 
            // rbtn_Teachers
            // 
            this.rbtn_Teachers.AutoSize = true;
            this.rbtn_Teachers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rbtn_Teachers.Location = new System.Drawing.Point(117, 144);
            this.rbtn_Teachers.Name = "rbtn_Teachers";
            this.rbtn_Teachers.Size = new System.Drawing.Size(86, 21);
            this.rbtn_Teachers.TabIndex = 13;
            this.rbtn_Teachers.Text = "Teachers";
            this.rbtn_Teachers.UseVisualStyleBackColor = true;
            this.rbtn_Teachers.Click += new System.EventHandler(this.rbtn_OnClick);
            // 
            // rbtn_Courses
            // 
            this.rbtn_Courses.AutoSize = true;
            this.rbtn_Courses.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rbtn_Courses.Location = new System.Drawing.Point(209, 144);
            this.rbtn_Courses.Name = "rbtn_Courses";
            this.rbtn_Courses.Size = new System.Drawing.Size(78, 21);
            this.rbtn_Courses.TabIndex = 14;
            this.rbtn_Courses.Text = "Courses";
            this.rbtn_Courses.UseVisualStyleBackColor = true;
            this.rbtn_Courses.Click += new System.EventHandler(this.rbtn_OnClick);
            // 
            // rbtn_Choose
            // 
            this.rbtn_Choose.AutoSize = true;
            this.rbtn_Choose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rbtn_Choose.Location = new System.Drawing.Point(293, 144);
            this.rbtn_Choose.Name = "rbtn_Choose";
            this.rbtn_Choose.Size = new System.Drawing.Size(134, 21);
            this.rbtn_Choose.TabIndex = 15;
            this.rbtn_Choose.Text = "Course Choosing";
            this.rbtn_Choose.UseVisualStyleBackColor = true;
            this.rbtn_Choose.Click += new System.EventHandler(this.rbtn_OnClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label2.Location = new System.Drawing.Point(635, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 18);
            this.label2.TabIndex = 16;
            this.label2.Text = "Students";
            // 
            // btn_Stu_Insert
            // 
            this.btn_Stu_Insert.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btn_Stu_Insert.Location = new System.Drawing.Point(572, 176);
            this.btn_Stu_Insert.Name = "btn_Stu_Insert";
            this.btn_Stu_Insert.Size = new System.Drawing.Size(193, 42);
            this.btn_Stu_Insert.TabIndex = 17;
            this.btn_Stu_Insert.Text = "Insert New Entry";
            this.btn_Stu_Insert.UseVisualStyleBackColor = true;
            this.btn_Stu_Insert.Click += new System.EventHandler(this.btn_Stu_Insert_Click);
            // 
            // btn_Stu_Modify
            // 
            this.btn_Stu_Modify.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btn_Stu_Modify.Location = new System.Drawing.Point(572, 224);
            this.btn_Stu_Modify.Name = "btn_Stu_Modify";
            this.btn_Stu_Modify.Size = new System.Drawing.Size(193, 42);
            this.btn_Stu_Modify.TabIndex = 18;
            this.btn_Stu_Modify.Text = "Modify Existing Entry";
            this.btn_Stu_Modify.UseVisualStyleBackColor = true;
            this.btn_Stu_Modify.Click += new System.EventHandler(this.btn_Stu_Modify_Click);
            // 
            // btn_Stu_Delete
            // 
            this.btn_Stu_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btn_Stu_Delete.Location = new System.Drawing.Point(572, 272);
            this.btn_Stu_Delete.Name = "btn_Stu_Delete";
            this.btn_Stu_Delete.Size = new System.Drawing.Size(193, 42);
            this.btn_Stu_Delete.TabIndex = 19;
            this.btn_Stu_Delete.Text = "Delete Existing Entry";
            this.btn_Stu_Delete.UseVisualStyleBackColor = true;
            this.btn_Stu_Delete.Click += new System.EventHandler(this.btn_Stu_Delete_Click);
            // 
            // btn_Courses_Delete
            // 
            this.btn_Courses_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btn_Courses_Delete.Location = new System.Drawing.Point(572, 450);
            this.btn_Courses_Delete.Name = "btn_Courses_Delete";
            this.btn_Courses_Delete.Size = new System.Drawing.Size(193, 42);
            this.btn_Courses_Delete.TabIndex = 23;
            this.btn_Courses_Delete.Text = "Delete Existing Entry";
            this.btn_Courses_Delete.UseVisualStyleBackColor = true;
            this.btn_Courses_Delete.Click += new System.EventHandler(this.btn_Courses_Delete_Click);
            // 
            // btn_Courses_Modify
            // 
            this.btn_Courses_Modify.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btn_Courses_Modify.Location = new System.Drawing.Point(572, 402);
            this.btn_Courses_Modify.Name = "btn_Courses_Modify";
            this.btn_Courses_Modify.Size = new System.Drawing.Size(193, 42);
            this.btn_Courses_Modify.TabIndex = 22;
            this.btn_Courses_Modify.Text = "Modify Existing Entry";
            this.btn_Courses_Modify.UseVisualStyleBackColor = true;
            this.btn_Courses_Modify.Click += new System.EventHandler(this.btn_Courses_Modify_Click);
            // 
            // btn_Courses_Insert
            // 
            this.btn_Courses_Insert.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btn_Courses_Insert.Location = new System.Drawing.Point(572, 354);
            this.btn_Courses_Insert.Name = "btn_Courses_Insert";
            this.btn_Courses_Insert.Size = new System.Drawing.Size(193, 42);
            this.btn_Courses_Insert.TabIndex = 21;
            this.btn_Courses_Insert.Text = "Insert New Entry";
            this.btn_Courses_Insert.UseVisualStyleBackColor = true;
            this.btn_Courses_Insert.Click += new System.EventHandler(this.btn_Courses_Insert_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label5.Location = new System.Drawing.Point(636, 331);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 18);
            this.label5.TabIndex = 20;
            this.label5.Text = "Courses";
            // 
            // btn_Choose_Delete
            // 
            this.btn_Choose_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btn_Choose_Delete.Location = new System.Drawing.Point(771, 450);
            this.btn_Choose_Delete.Name = "btn_Choose_Delete";
            this.btn_Choose_Delete.Size = new System.Drawing.Size(193, 42);
            this.btn_Choose_Delete.TabIndex = 31;
            this.btn_Choose_Delete.Text = "Delete Existing Entry";
            this.btn_Choose_Delete.UseVisualStyleBackColor = true;
            this.btn_Choose_Delete.Click += new System.EventHandler(this.btn_Choose_Delete_Click);
            // 
            // btn_Choose_Modify
            // 
            this.btn_Choose_Modify.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btn_Choose_Modify.Location = new System.Drawing.Point(771, 402);
            this.btn_Choose_Modify.Name = "btn_Choose_Modify";
            this.btn_Choose_Modify.Size = new System.Drawing.Size(193, 42);
            this.btn_Choose_Modify.TabIndex = 30;
            this.btn_Choose_Modify.Text = "Modify Existing Entry";
            this.btn_Choose_Modify.UseVisualStyleBackColor = true;
            this.btn_Choose_Modify.Click += new System.EventHandler(this.btn_Choose_Modify_Click);
            // 
            // btn_Choose_Insert
            // 
            this.btn_Choose_Insert.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btn_Choose_Insert.Location = new System.Drawing.Point(771, 354);
            this.btn_Choose_Insert.Name = "btn_Choose_Insert";
            this.btn_Choose_Insert.Size = new System.Drawing.Size(193, 42);
            this.btn_Choose_Insert.TabIndex = 29;
            this.btn_Choose_Insert.Text = "Insert New Entry";
            this.btn_Choose_Insert.UseVisualStyleBackColor = true;
            this.btn_Choose_Insert.Click += new System.EventHandler(this.btn_Choose_Insert_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label6.Location = new System.Drawing.Point(805, 331);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 18);
            this.label6.TabIndex = 28;
            this.label6.Text = "Course Choosing";
            // 
            // btn_Teacher_Delete
            // 
            this.btn_Teacher_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btn_Teacher_Delete.Location = new System.Drawing.Point(771, 272);
            this.btn_Teacher_Delete.Name = "btn_Teacher_Delete";
            this.btn_Teacher_Delete.Size = new System.Drawing.Size(193, 42);
            this.btn_Teacher_Delete.TabIndex = 27;
            this.btn_Teacher_Delete.Text = "Delete Existing Entry";
            this.btn_Teacher_Delete.UseVisualStyleBackColor = true;
            this.btn_Teacher_Delete.Click += new System.EventHandler(this.btn_Teacher_Delete_Click);
            // 
            // btn_Teacher_Modify
            // 
            this.btn_Teacher_Modify.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btn_Teacher_Modify.Location = new System.Drawing.Point(771, 224);
            this.btn_Teacher_Modify.Name = "btn_Teacher_Modify";
            this.btn_Teacher_Modify.Size = new System.Drawing.Size(193, 42);
            this.btn_Teacher_Modify.TabIndex = 26;
            this.btn_Teacher_Modify.Text = "Modify Existing Entry";
            this.btn_Teacher_Modify.UseVisualStyleBackColor = true;
            this.btn_Teacher_Modify.Click += new System.EventHandler(this.btn_Teacher_Modify_Click);
            // 
            // btn_Teacher_Insert
            // 
            this.btn_Teacher_Insert.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btn_Teacher_Insert.Location = new System.Drawing.Point(771, 176);
            this.btn_Teacher_Insert.Name = "btn_Teacher_Insert";
            this.btn_Teacher_Insert.Size = new System.Drawing.Size(193, 42);
            this.btn_Teacher_Insert.TabIndex = 25;
            this.btn_Teacher_Insert.Text = "Insert New Entry";
            this.btn_Teacher_Insert.UseVisualStyleBackColor = true;
            this.btn_Teacher_Insert.Click += new System.EventHandler(this.btn_Teacher_Insert_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label7.Location = new System.Drawing.Point(832, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 18);
            this.label7.TabIndex = 24;
            this.label7.Text = "Teachers";
            // 
            // Portal_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 543);
            this.Controls.Add(this.btn_Choose_Delete);
            this.Controls.Add(this.btn_Choose_Modify);
            this.Controls.Add(this.btn_Choose_Insert);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_Teacher_Delete);
            this.Controls.Add(this.btn_Teacher_Modify);
            this.Controls.Add(this.btn_Teacher_Insert);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_Courses_Delete);
            this.Controls.Add(this.btn_Courses_Modify);
            this.Controls.Add(this.btn_Courses_Insert);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_Stu_Delete);
            this.Controls.Add(this.btn_Stu_Modify);
            this.Controls.Add(this.btn_Stu_Insert);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rbtn_Choose);
            this.Controls.Add(this.rbtn_Courses);
            this.Controls.Add(this.rbtn_Teachers);
            this.Controls.Add(this.rbtn_Students);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.label_Instruction);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label_Username);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Portal_Admin";
            this.Text = "SCUT MIS - Admin Portal";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_Username;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Label label_Instruction;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.RadioButton rbtn_Students;
        private System.Windows.Forms.RadioButton rbtn_Teachers;
        private System.Windows.Forms.RadioButton rbtn_Courses;
        private System.Windows.Forms.RadioButton rbtn_Choose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Stu_Insert;
        private System.Windows.Forms.Button btn_Stu_Modify;
        private System.Windows.Forms.Button btn_Stu_Delete;
        private System.Windows.Forms.Button btn_Courses_Delete;
        private System.Windows.Forms.Button btn_Courses_Modify;
        private System.Windows.Forms.Button btn_Courses_Insert;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_Choose_Delete;
        private System.Windows.Forms.Button btn_Choose_Modify;
        private System.Windows.Forms.Button btn_Choose_Insert;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_Teacher_Delete;
        private System.Windows.Forms.Button btn_Teacher_Modify;
        private System.Windows.Forms.Button btn_Teacher_Insert;
        private System.Windows.Forms.Label label7;
    }
}