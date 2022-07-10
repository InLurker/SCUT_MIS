namespace SCUT_MIS
{
    partial class LoginPage
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
            this.label_username = new System.Windows.Forms.Label();
            this.label_pass = new System.Windows.Forms.Label();
            this.textBox_username = new System.Windows.Forms.TextBox();
            this.textBox_pass = new System.Windows.Forms.TextBox();
            this.rbtn_student = new System.Windows.Forms.RadioButton();
            this.rbtn_teacher = new System.Windows.Forms.RadioButton();
            this.rbtn_admin = new System.Windows.Forms.RadioButton();
            this.btn_register = new System.Windows.Forms.Button();
            this.btn_login = new System.Windows.Forms.Button();
            this.label_instruction = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(145, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.label2.Location = new System.Drawing.Point(81, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(284, 63);
            this.label2.TabIndex = 1;
            this.label2.Text = "SCUT MIS";
            // 
            // label_username
            // 
            this.label_username.AutoSize = true;
            this.label_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label_username.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label_username.Location = new System.Drawing.Point(53, 213);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(102, 25);
            this.label_username.TabIndex = 2;
            this.label_username.Text = "Username";
            // 
            // label_pass
            // 
            this.label_pass.AutoSize = true;
            this.label_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label_pass.Location = new System.Drawing.Point(54, 249);
            this.label_pass.Name = "label_pass";
            this.label_pass.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label_pass.Size = new System.Drawing.Size(98, 25);
            this.label_pass.TabIndex = 3;
            this.label_pass.Text = "Password";
            // 
            // textBox_username
            // 
            this.textBox_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.textBox_username.Location = new System.Drawing.Point(177, 210);
            this.textBox_username.Name = "textBox_username";
            this.textBox_username.Size = new System.Drawing.Size(199, 30);
            this.textBox_username.TabIndex = 4;
            // 
            // textBox_pass
            // 
            this.textBox_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.textBox_pass.Location = new System.Drawing.Point(177, 246);
            this.textBox_pass.Name = "textBox_pass";
            this.textBox_pass.Size = new System.Drawing.Size(199, 30);
            this.textBox_pass.TabIndex = 5;
            this.textBox_pass.UseSystemPasswordChar = true;
            // 
            // rbtn_student
            // 
            this.rbtn_student.AutoSize = true;
            this.rbtn_student.Checked = true;
            this.rbtn_student.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rbtn_student.Location = new System.Drawing.Point(85, 314);
            this.rbtn_student.Name = "rbtn_student";
            this.rbtn_student.Size = new System.Drawing.Size(75, 21);
            this.rbtn_student.TabIndex = 6;
            this.rbtn_student.TabStop = true;
            this.rbtn_student.Text = "Student";
            this.rbtn_student.UseVisualStyleBackColor = true;
            // 
            // rbtn_teacher
            // 
            this.rbtn_teacher.AutoSize = true;
            this.rbtn_teacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rbtn_teacher.Location = new System.Drawing.Point(198, 314);
            this.rbtn_teacher.Name = "rbtn_teacher";
            this.rbtn_teacher.Size = new System.Drawing.Size(79, 21);
            this.rbtn_teacher.TabIndex = 7;
            this.rbtn_teacher.Text = "Teacher";
            this.rbtn_teacher.UseVisualStyleBackColor = true;
            // 
            // rbtn_admin
            // 
            this.rbtn_admin.AutoSize = true;
            this.rbtn_admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rbtn_admin.Location = new System.Drawing.Point(313, 314);
            this.rbtn_admin.Name = "rbtn_admin";
            this.rbtn_admin.Size = new System.Drawing.Size(65, 21);
            this.rbtn_admin.TabIndex = 8;
            this.rbtn_admin.Text = "Admin";
            this.rbtn_admin.UseVisualStyleBackColor = true;
            // 
            // btn_register
            // 
            this.btn_register.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btn_register.Location = new System.Drawing.Point(83, 380);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(121, 37);
            this.btn_register.TabIndex = 9;
            this.btn_register.Text = "Register";
            this.btn_register.UseVisualStyleBackColor = true;
            this.btn_register.Click += new System.EventHandler(this.btn_register_Click);
            // 
            // btn_login
            // 
            this.btn_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btn_login.Location = new System.Drawing.Point(244, 380);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(121, 37);
            this.btn_login.TabIndex = 10;
            this.btn_login.Text = "Log in";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // label_instruction
            // 
            this.label_instruction.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label_instruction.Location = new System.Drawing.Point(31, 167);
            this.label_instruction.Name = "label_instruction";
            this.label_instruction.Size = new System.Drawing.Size(384, 23);
            this.label_instruction.TabIndex = 11;
            this.label_instruction.Text = "Please enter your username and password";
            this.label_instruction.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 476);
            this.Controls.Add(this.label_instruction);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.btn_register);
            this.Controls.Add(this.rbtn_teacher);
            this.Controls.Add(this.rbtn_admin);
            this.Controls.Add(this.rbtn_student);
            this.Controls.Add(this.textBox_pass);
            this.Controls.Add(this.textBox_username);
            this.Controls.Add(this.label_pass);
            this.Controls.Add(this.label_username);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "LoginPage";
            this.Text = "SCUT MIS - Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_username;
        private System.Windows.Forms.Label label_pass;
        private System.Windows.Forms.TextBox textBox_username;
        private System.Windows.Forms.TextBox textBox_pass;
        private System.Windows.Forms.RadioButton rbtn_student;
        private System.Windows.Forms.RadioButton rbtn_teacher;
        private System.Windows.Forms.RadioButton rbtn_admin;
        private System.Windows.Forms.Button btn_register;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Label label_instruction;
    }
}

