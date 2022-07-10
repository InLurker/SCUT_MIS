namespace SCUT_MIS
{
    partial class Query_AverageScore
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
            this.textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rbtn_aStu = new System.Windows.Forms.RadioButton();
            this.rbtn_allStu = new System.Windows.Forms.RadioButton();
            this.rbtn_classStu = new System.Windows.Forms.RadioButton();
            this.rbtn_courseStu = new System.Windows.Forms.RadioButton();
            this.label_warning = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbtn_Name = new System.Windows.Forms.RadioButton();
            this.rbtn_ID = new System.Windows.Forms.RadioButton();
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Average Score";
            // 
            // textBox
            // 
            this.textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox.Location = new System.Drawing.Point(32, 90);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(361, 29);
            this.textBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label2.Location = new System.Drawing.Point(29, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Show results for:";
            // 
            // rbtn_aStu
            // 
            this.rbtn_aStu.AutoSize = true;
            this.rbtn_aStu.Checked = true;
            this.rbtn_aStu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rbtn_aStu.Location = new System.Drawing.Point(32, 168);
            this.rbtn_aStu.Name = "rbtn_aStu";
            this.rbtn_aStu.Size = new System.Drawing.Size(86, 21);
            this.rbtn_aStu.TabIndex = 3;
            this.rbtn_aStu.TabStop = true;
            this.rbtn_aStu.Text = "A student";
            this.rbtn_aStu.UseVisualStyleBackColor = true;
            this.rbtn_aStu.CheckedChanged += new System.EventHandler(this.rbtn_aStu_CheckedChanged);
            // 
            // rbtn_allStu
            // 
            this.rbtn_allStu.AutoSize = true;
            this.rbtn_allStu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rbtn_allStu.Location = new System.Drawing.Point(32, 186);
            this.rbtn_allStu.Name = "rbtn_allStu";
            this.rbtn_allStu.Size = new System.Drawing.Size(99, 21);
            this.rbtn_allStu.TabIndex = 4;
            this.rbtn_allStu.Text = "All students";
            this.rbtn_allStu.UseVisualStyleBackColor = true;
            this.rbtn_allStu.CheckedChanged += new System.EventHandler(this.rbtn_allStu_CheckedChanged);
            // 
            // rbtn_classStu
            // 
            this.rbtn_classStu.AutoSize = true;
            this.rbtn_classStu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rbtn_classStu.Location = new System.Drawing.Point(32, 204);
            this.rbtn_classStu.Name = "rbtn_classStu";
            this.rbtn_classStu.Size = new System.Drawing.Size(109, 21);
            this.rbtn_classStu.TabIndex = 5;
            this.rbtn_classStu.Text = "Each classes";
            this.rbtn_classStu.UseVisualStyleBackColor = true;
            this.rbtn_classStu.CheckedChanged += new System.EventHandler(this.rbtn_classStu_CheckedChanged);
            // 
            // rbtn_courseStu
            // 
            this.rbtn_courseStu.AutoSize = true;
            this.rbtn_courseStu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rbtn_courseStu.Location = new System.Drawing.Point(32, 222);
            this.rbtn_courseStu.Name = "rbtn_courseStu";
            this.rbtn_courseStu.Size = new System.Drawing.Size(112, 21);
            this.rbtn_courseStu.TabIndex = 6;
            this.rbtn_courseStu.Text = "Each courses";
            this.rbtn_courseStu.UseVisualStyleBackColor = true;
            this.rbtn_courseStu.CheckedChanged += new System.EventHandler(this.rbtn_courseStu_CheckedChanged);
            // 
            // label_warning
            // 
            this.label_warning.AutoSize = true;
            this.label_warning.Location = new System.Drawing.Point(29, 122);
            this.label_warning.Name = "label_warning";
            this.label_warning.Size = new System.Drawing.Size(295, 13);
            this.label_warning.TabIndex = 7;
            this.label_warning.Text = "Leaving this box empty will display information for all students.";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbtn_Name);
            this.panel1.Controls.Add(this.rbtn_ID);
            this.panel1.Location = new System.Drawing.Point(32, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(206, 19);
            this.panel1.TabIndex = 8;
            // 
            // rbtn_Name
            // 
            this.rbtn_Name.AutoSize = true;
            this.rbtn_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_Name.Location = new System.Drawing.Point(85, -1);
            this.rbtn_Name.Name = "rbtn_Name";
            this.rbtn_Name.Size = new System.Drawing.Size(110, 20);
            this.rbtn_Name.TabIndex = 1;
            this.rbtn_Name.Text = "Student Name";
            this.rbtn_Name.UseVisualStyleBackColor = true;
            // 
            // rbtn_ID
            // 
            this.rbtn_ID.AutoSize = true;
            this.rbtn_ID.Checked = true;
            this.rbtn_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_ID.Location = new System.Drawing.Point(0, -1);
            this.rbtn_ID.Name = "rbtn_ID";
            this.rbtn_ID.Size = new System.Drawing.Size(86, 20);
            this.rbtn_ID.TabIndex = 0;
            this.rbtn_ID.TabStop = true;
            this.rbtn_ID.Text = "Student ID";
            this.rbtn_ID.UseVisualStyleBackColor = true;
            // 
            // btn_Search
            // 
            this.btn_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_Search.Location = new System.Drawing.Point(400, 90);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(75, 29);
            this.btn_Search.TabIndex = 9;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_Cancel.Location = new System.Drawing.Point(483, 222);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(70, 29);
            this.btn_Cancel.TabIndex = 10;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = false;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // Query_AverageScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 273);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.label_warning);
            this.Controls.Add(this.rbtn_courseStu);
            this.Controls.Add(this.rbtn_allStu);
            this.Controls.Add(this.rbtn_aStu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbtn_classStu);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "Query_AverageScore";
            this.Text = "SCUT MIS - Query Average Score";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbtn_aStu;
        private System.Windows.Forms.RadioButton rbtn_allStu;
        private System.Windows.Forms.RadioButton rbtn_classStu;
        private System.Windows.Forms.RadioButton rbtn_courseStu;
        private System.Windows.Forms.Label label_warning;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbtn_Name;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.RadioButton rbtn_ID;
    }
}