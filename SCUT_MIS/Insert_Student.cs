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
    public partial class Insert_Student : Form
    {
        public Insert_Student()
        {
            InitializeComponent();
        }

        private void btn_Confirm_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBox_ID.Text)) { errorMsg("Student ID cannot be empty."); return; }
            if (textBox_ID.Text.Length > 10) { errorMsg("Student ID exceeded character limit. (max.10)"); return; }

            if (String.IsNullOrWhiteSpace(textBox_Name.Text)) { errorMsg("Student name cannot be empty."); return; }
            if (textBox_Name.Text.Length > 20) { errorMsg("Student name exceeded character limit. (max.20)"); return; }

            if (String.IsNullOrWhiteSpace(textBox_Sex.Text)) { errorMsg("Student sex cannot be empty."); return; }
            if (textBox_Sex.Text != "male" && textBox_Sex.Text != "female") { errorMsg("Invalid sex. Only 'male' or 'female' allowed."); return; }

            if (String.IsNullOrWhiteSpace(textBox_EntAge.Text)) { errorMsg("Student entrance age cannot be empty."); return; }
            if (int.TryParse(textBox_EntAge.Text, out int EntAge))
            {
                if (EntAge < 10 || EntAge > 50) { errorMsg("Entrance age can only be between 10 and 50."); return; }
            }
            else { errorMsg("Invalid student entrance age."); return; }

            if (String.IsNullOrWhiteSpace(textBox_EntYear.Text)) { errorMsg("Student entrance year cannot be empty."); return; }
            if (int.TryParse(textBox_EntYear.Text, out int EntYear)) 
            {
                if (EntYear < 0) { errorMsg("Entrance year cannot be negative."); return; }
            }
            else { errorMsg("Invalid student entrance year."); return; }

            if (String.IsNullOrWhiteSpace(textBox_Class.Text)) { errorMsg("Student class cannot be empty."); return; }
            if (textBox_Class.Text.Length > 20) { errorMsg("Student class exceeded character limit. (max.20)"); return; }


            using (SqlConnection sqlConnection = new System.Data.SqlClient.SqlConnection(SqlHelper.CnnVal("database")))
            {
                string Query = $"SELECT COUNT(sid) FROM students WHERE sid='{ textBox_ID.Text }'";
                using (SqlCommand command = new SqlCommand(Query, sqlConnection))
                {
                    sqlConnection.Open();
                    int count = (int)command.ExecuteScalar();
                    if (count > 0)
                    {
                        errorMsg($"A student with ID \"{ textBox_ID.Text }\" already exists.");
                        return;
                    }
                }

                Query = "INSERT INTO students" +
                    " (sid, sname, sex, entrance_age, entrance_year, class)" +
                    $" VALUES ('{textBox_ID.Text}', N'{textBox_Name.Text}', '{textBox_Sex.Text}', {textBox_EntAge.Text}, {textBox_EntYear.Text}, '{textBox_Class.Text}')";

                using (SqlCommand sqlCommand = new SqlCommand(Query, sqlConnection))
                {
                    int result = sqlCommand.ExecuteNonQuery();
                    if (result > 0)
                    {
                        label_instruction.Text = "Student entry added successfully.";
                        label_instruction.ForeColor = Color.Green;
                    }
                    else errorMsg("Error inserting student entry.");
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
