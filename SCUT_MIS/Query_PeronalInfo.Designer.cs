namespace SCUT_MIS
{
    partial class Query_PersonalInfo
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
            this.rbtn_ID = new System.Windows.Forms.RadioButton();
            this.rbtn_Name = new System.Windows.Forms.RadioButton();
            this.textBox_info = new System.Windows.Forms.TextBox();
            this.btn_SearchInfo = new System.Windows.Forms.Button();
            this.label_warning = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(23, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Student Information";
            // 
            // rbtn_ID
            // 
            this.rbtn_ID.AutoSize = true;
            this.rbtn_ID.Checked = true;
            this.rbtn_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rbtn_ID.Location = new System.Drawing.Point(28, 104);
            this.rbtn_ID.Name = "rbtn_ID";
            this.rbtn_ID.Size = new System.Drawing.Size(39, 21);
            this.rbtn_ID.TabIndex = 1;
            this.rbtn_ID.TabStop = true;
            this.rbtn_ID.Text = "ID";
            this.rbtn_ID.UseVisualStyleBackColor = true;
            // 
            // rbtn_Name
            // 
            this.rbtn_Name.AutoSize = true;
            this.rbtn_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rbtn_Name.Location = new System.Drawing.Point(73, 104);
            this.rbtn_Name.Name = "rbtn_Name";
            this.rbtn_Name.Size = new System.Drawing.Size(63, 21);
            this.rbtn_Name.TabIndex = 1;
            this.rbtn_Name.Text = "Name";
            this.rbtn_Name.UseVisualStyleBackColor = true;
            // 
            // textBox_info
            // 
            this.textBox_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBox_info.Location = new System.Drawing.Point(25, 52);
            this.textBox_info.Name = "textBox_info";
            this.textBox_info.Size = new System.Drawing.Size(295, 29);
            this.textBox_info.TabIndex = 2;
            // 
            // btn_SearchInfo
            // 
            this.btn_SearchInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_SearchInfo.Location = new System.Drawing.Point(326, 50);
            this.btn_SearchInfo.Name = "btn_SearchInfo";
            this.btn_SearchInfo.Size = new System.Drawing.Size(68, 28);
            this.btn_SearchInfo.TabIndex = 3;
            this.btn_SearchInfo.Text = "Search";
            this.btn_SearchInfo.UseVisualStyleBackColor = true;
            this.btn_SearchInfo.Click += new System.EventHandler(this.btn_SearchInfo_Click);
            // 
            // label_warning
            // 
            this.label_warning.AutoSize = true;
            this.label_warning.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_warning.Location = new System.Drawing.Point(22, 81);
            this.label_warning.Name = "label_warning";
            this.label_warning.Size = new System.Drawing.Size(343, 15);
            this.label_warning.TabIndex = 13;
            this.label_warning.Text = "Leaving this box empty will display information for all students.";
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.SystemColors.Control;
            this.btn_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_cancel.Location = new System.Drawing.Point(358, 111);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(68, 28);
            this.btn_cancel.TabIndex = 3;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // Query_PersonalInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 151);
            this.Controls.Add(this.label_warning);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_SearchInfo);
            this.Controls.Add(this.textBox_info);
            this.Controls.Add(this.rbtn_Name);
            this.Controls.Add(this.rbtn_ID);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Query_PersonalInfo";
            this.Text = "SCUT MIS - Query Student Information";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbtn_ID;
        private System.Windows.Forms.RadioButton rbtn_Name;
        private System.Windows.Forms.TextBox textBox_info;
        private System.Windows.Forms.Button btn_SearchInfo;
        private System.Windows.Forms.Label label_warning;
        private System.Windows.Forms.Button btn_cancel;
    }
}