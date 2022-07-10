namespace SCUT_MIS
{
    partial class Portal_Student
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label_Instruction = new System.Windows.Forms.Label();
            this.btn_PersonalInfo = new System.Windows.Forms.Button();
            this.btn_CourseInfo = new System.Windows.Forms.Button();
            this.btn_ScoreLookup = new System.Windows.Forms.Button();
            this.btn_AverageScore = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(653, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "You\'re logged in as";
            // 
            // label_Username
            // 
            this.label_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label_Username.Location = new System.Drawing.Point(508, 40);
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
            this.label3.Size = new System.Drawing.Size(273, 46);
            this.label3.TabIndex = 2;
            this.label3.Text = "Student Portal";
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
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(29, 169);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(523, 318);
            this.dataGridView1.TabIndex = 5;
            // 
            // label_Instruction
            // 
            this.label_Instruction.AutoSize = true;
            this.label_Instruction.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label_Instruction.Location = new System.Drawing.Point(25, 135);
            this.label_Instruction.Name = "label_Instruction";
            this.label_Instruction.Size = new System.Drawing.Size(144, 22);
            this.label_Instruction.TabIndex = 6;
            this.label_Instruction.Text = "Select an option.";
            // 
            // btn_PersonalInfo
            // 
            this.btn_PersonalInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_PersonalInfo.Location = new System.Drawing.Point(597, 169);
            this.btn_PersonalInfo.Name = "btn_PersonalInfo";
            this.btn_PersonalInfo.Size = new System.Drawing.Size(172, 44);
            this.btn_PersonalInfo.TabIndex = 7;
            this.btn_PersonalInfo.Text = "Personal Info";
            this.btn_PersonalInfo.UseVisualStyleBackColor = true;
            this.btn_PersonalInfo.Click += new System.EventHandler(this.btn_PersonalInfo_Click);
            // 
            // btn_CourseInfo
            // 
            this.btn_CourseInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_CourseInfo.Location = new System.Drawing.Point(597, 242);
            this.btn_CourseInfo.Name = "btn_CourseInfo";
            this.btn_CourseInfo.Size = new System.Drawing.Size(172, 44);
            this.btn_CourseInfo.TabIndex = 8;
            this.btn_CourseInfo.Text = "Course Info";
            this.btn_CourseInfo.UseVisualStyleBackColor = true;
            this.btn_CourseInfo.Click += new System.EventHandler(this.btn_CourseInfo_Click);
            // 
            // btn_ScoreLookup
            // 
            this.btn_ScoreLookup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_ScoreLookup.Location = new System.Drawing.Point(597, 318);
            this.btn_ScoreLookup.Name = "btn_ScoreLookup";
            this.btn_ScoreLookup.Size = new System.Drawing.Size(172, 44);
            this.btn_ScoreLookup.TabIndex = 9;
            this.btn_ScoreLookup.Text = "Score Lookup";
            this.btn_ScoreLookup.UseVisualStyleBackColor = true;
            this.btn_ScoreLookup.Click += new System.EventHandler(this.btn_ScoreLookup_Click);
            // 
            // btn_AverageScore
            // 
            this.btn_AverageScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_AverageScore.Location = new System.Drawing.Point(597, 390);
            this.btn_AverageScore.Name = "btn_AverageScore";
            this.btn_AverageScore.Size = new System.Drawing.Size(172, 44);
            this.btn_AverageScore.TabIndex = 10;
            this.btn_AverageScore.Text = "Average Score";
            this.btn_AverageScore.UseVisualStyleBackColor = true;
            this.btn_AverageScore.Click += new System.EventHandler(this.btn_AverageScore_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_Exit.Location = new System.Drawing.Point(674, 490);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(95, 29);
            this.btn_Exit.TabIndex = 11;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // Portal_Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 543);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_AverageScore);
            this.Controls.Add(this.btn_ScoreLookup);
            this.Controls.Add(this.btn_CourseInfo);
            this.Controls.Add(this.btn_PersonalInfo);
            this.Controls.Add(this.label_Instruction);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label_Username);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Portal_Student";
            this.Text = "SCUT MIS - Student Portal";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_Username;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label_Instruction;
        private System.Windows.Forms.Button btn_PersonalInfo;
        private System.Windows.Forms.Button btn_CourseInfo;
        private System.Windows.Forms.Button btn_ScoreLookup;
        private System.Windows.Forms.Button btn_AverageScore;
        private System.Windows.Forms.Button btn_Exit;
    }
}