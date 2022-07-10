using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SCUT_MIS
{
    public partial class Insert_Teacher : Form
    {
        public Insert_Teacher()
        {
            InitializeComponent();
        }

        private void btn_Confirm_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBox_ID.Text)) { errorMsg("Student ID cannot be empty."); return; }
            if (textBox_ID.Text.Length > 5) { errorMsg("Teacher ID exceeded character limit. (max.5"); return; }

            if (String.IsNullOrWhiteSpace(textBox_Name.Text)) { errorMsg("Student name cannot be empty."); return; }
            if (textBox_Name.Text.Length > 20) { errorMsg("Teacher name exceeded character limit. (max.20)"); return; }

            if (String.IsNullOrWhiteSpace(textBox_Course.Text)) { errorMsg("Student sex cannot be empty."); return; }
            if (textBox_Course.Text.Length > 20) { errorMsg("Course exceeded character limit. (max.20)"); return; }

            using (SqlConnection sqlConnection = new System.Data.SqlClient.SqlConnection(SqlHelper.CnnVal("database")))
            {
                string Query = $"SELECT COUNT(tid) FROM teachers WHERE tid='{ textBox_ID.Text }'";
                using (SqlCommand command = new SqlCommand(Query, sqlConnection))
                {
                    sqlConnection.Open();
                    int count = (int)command.ExecuteScalar();
                    if (count > 0)
                    {
                        errorMsg($"A teacher with ID \"{ textBox_ID.Text }\" already exists.");
                        return;
                    }
                }

                Query = "INSERT INTO teachers" +
                    " (tid, tname, course)" +
                    $" VALUES ('{textBox_ID.Text}', N'{textBox_Name.Text}', N'{textBox_Course.Text}')";

                using (SqlCommand sqlCommand = new SqlCommand(Query, sqlConnection))
                {
                    int result = sqlCommand.ExecuteNonQuery();
                    if (result > 0)
                    {
                        label_instruction.Text = "Teacher entry added successfully.";
                        label_instruction.ForeColor = Color.Green;
                    }
                    else errorMsg("Error inserting teacher entry.");
                }

            }
        }

        private void errorMsg(string errorMsg)
        {
            label_instruction.Text = errorMsg;
            label_instruction.ForeColor = Color.Red;
        }

        private void btn_Exit_Click(object sender, EventArgs e) => Close();
    }
}
