namespace SCUT_MIS
{
    partial class Query_ScoreLookup
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
            this.textBox_Student = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbtn_sname = new System.Windows.Forms.RadioButton();
            this.rbtn_sid = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rbtn_cname = new System.Windows.Forms.RadioButton();
            this.rbtn_cid = new System.Windows.Forms.RadioButton();
            this.textBox_Course = new System.Windows.Forms.TextBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.label_warning = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Score Lookup";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(24, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Student";
            // 
            // textBox_Student
            // 
            this.textBox_Student.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBox_Student.Location = new System.Drawing.Point(104, 93);
            this.textBox_Student.Name = "textBox_Student";
            this.textBox_Student.Size = new System.Drawing.Size(241, 29);
            this.textBox_Student.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbtn_sname);
            this.panel1.Controls.Add(this.rbtn_sid);
            this.panel1.Location = new System.Drawing.Point(104, 123);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(122, 26);
            this.panel1.TabIndex = 3;
            // 
            // rbtn_sname
            // 
            this.rbtn_sname.AutoSize = true;
            this.rbtn_sname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rbtn_sname.Location = new System.Drawing.Point(48, 0);
            this.rbtn_sname.Name = "rbtn_sname";
            this.rbtn_sname.Size = new System.Drawing.Size(63, 21);
            this.rbtn_sname.TabIndex = 1;
            this.rbtn_sname.Text = "Name";
            this.rbtn_sname.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.rbtn_sname.UseVisualStyleBackColor = true;
            // 
            // rbtn_sid
            // 
            this.rbtn_sid.AutoSize = true;
            this.rbtn_sid.Checked = true;
            this.rbtn_sid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rbtn_sid.Location = new System.Drawing.Point(3, 0);
            this.rbtn_sid.Name = "rbtn_sid";
            this.rbtn_sid.Size = new System.Drawing.Size(39, 21);
            this.rbtn_sid.TabIndex = 0;
            this.rbtn_sid.TabStop = true;
            this.rbtn_sid.Text = "ID";
            this.rbtn_sid.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.Location = new System.Drawing.Point(27, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "Course";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rbtn_cname);
            this.panel2.Controls.Add(this.rbtn_cid);
            this.panel2.Location = new System.Drawing.Point(104, 185);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(122, 26);
            this.panel2.TabIndex = 3;
            // 
            // rbtn_cname
            // 
            this.rbtn_cname.AutoSize = true;
            this.rbtn_cname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rbtn_cname.Location = new System.Drawing.Point(48, 0);
            this.rbtn_cname.Name = "rbtn_cname";
            this.rbtn_cname.Size = new System.Drawing.Size(63, 21);
            this.rbtn_cname.TabIndex = 1;
            this.rbtn_cname.Text = "Name";
            this.rbtn_cname.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.rbtn_cname.UseVisualStyleBackColor = true;
            // 
            // rbtn_cid
            // 
            this.rbtn_cid.AutoSize = true;
            this.rbtn_cid.Checked = true;
            this.rbtn_cid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rbtn_cid.Location = new System.Drawing.Point(3, 0);
            this.rbtn_cid.Name = "rbtn_cid";
            this.rbtn_cid.Size = new System.Drawing.Size(39, 21);
            this.rbtn_cid.TabIndex = 0;
            this.rbtn_cid.TabStop = true;
            this.rbtn_cid.Text = "ID";
            this.rbtn_cid.UseVisualStyleBackColor = true;
            // 
            // textBox_Course
            // 
            this.textBox_Course.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBox_Course.Location = new System.Drawing.Point(104, 155);
            this.textBox_Course.Name = "textBox_Course";
            this.textBox_Course.Size = new System.Drawing.Size(241, 29);
            this.textBox_Course.TabIndex = 2;
            // 
            // btn_Search
            // 
            this.btn_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.Location = new System.Drawing.Point(378, 123);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(81, 27);
            this.btn_Search.TabIndex = 4;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancel.Location = new System.Drawing.Point(419, 217);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(64, 27);
            this.btn_Cancel.TabIndex = 5;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = false;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // label_warning
            // 
            this.label_warning.AutoSize = true;
            this.label_warning.Location = new System.Drawing.Point(25, 60);
            this.label_warning.Name = "label_warning";
            this.label_warning.Size = new System.Drawing.Size(292, 13);
            this.label_warning.TabIndex = 6;
            this.label_warning.Text = "Leaving boxes empty will display all informations for that field.";
            // 
            // Query_ScoreLookup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 257);
            this.Controls.Add(this.label_warning);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.textBox_Course);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.textBox_Student);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Query_ScoreLookup";
            this.Text = "SCUT MIS - Query Score Lookup";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Student;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbtn_sname;
        private System.Windows.Forms.RadioButton rbtn_sid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rbtn_cname;
        private System.Windows.Forms.RadioButton rbtn_cid;
        private System.Windows.Forms.TextBox textBox_Course;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Label label_warning;
    }
}