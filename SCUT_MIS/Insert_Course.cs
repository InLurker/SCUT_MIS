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
    public partial class Insert_Course : Form
    {
        public Insert_Course()
        {
            InitializeComponent();
            using (SqlConnection sqlConnection = new System.Data.SqlClient.SqlConnection(SqlHelper.CnnVal("database")))
            {
                using (SqlCommand sqlCommand = new SqlCommand("SELECT tid FROM teachers", sqlConnection))
                {
                    sqlConnection.Open();
                    using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                    {
                        while (sqlDataReader.Read())
                            comboBox_TID.Items.Add(sqlDataReader[0]);
                    }
                }
            }
        }

        private void btn_Confirm_Click(object sender, EventArgs e)
        {
            decimal CourseCredit;
            bool NullCancelYear = false;

            if (String.IsNullOrWhiteSpace(textBox_CID.Text)) { errorMsg("Course ID cannot be empty."); return; }
            if (textBox_CID.Text.Length > 7) { errorMsg("Course ID exceeded character limit. (max.7)"); return; }

            if (String.IsNullOrWhiteSpace(textBox_CName.Text)) { errorMsg("Course name cannot be empty."); return; }
            if (textBox_CName.Text.Length > 20) { errorMsg("Course name exceeded character limit. (max.20)"); return; }

            if (String.IsNullOrWhiteSpace(comboBox_TID.Text)) { errorMsg("Teacher ID cannot be empty."); return; }
            if (!comboBox_TID.Items.Contains(comboBox_TID.Text)) { errorMsg("Invalid Teacher ID."); return; }

            if (String.IsNullOrWhiteSpace(textBox_Credit.Text)) { errorMsg("Course credit cannot be empty."); return; }
            if (decimal.TryParse(textBox_Credit.Text, out decimal Credit))
            {
                if (Credit < 0 || Credit >= 100) { errorMsg("Invalid credit. (expected a positive decimal ##.##)"); return; }
                CourseCredit = decimal.Round(Credit, 2);
            }
            else { errorMsg("Invalid credit. (expected a positive decimal ##.##)"); return; }

            if (String.IsNullOrWhiteSpace(textBox_Grade.Text)) { errorMsg("Course grade cannot be empty."); return; }
            if (textBox_Grade.Text.Length > 20) { errorMsg("Course grade exceeded character limit. (max.20)"); return; }

            if (String.IsNullOrWhiteSpace(textBox_CancelYear.Text)) { NullCancelYear = true; }
            else if (int.TryParse(textBox_CancelYear.Text, out int CancelYear)) 
            {
                if (CancelYear < 0) { errorMsg("Cancel year cannot be negative."); return; }
            }
            else { errorMsg("Invalid cancel year."); return; }

            
            using (SqlConnection sqlConnection = new System.Data.SqlClient.SqlConnection(SqlHelper.CnnVal("database")))
            {
                string Query = $"SELECT COUNT(cid) FROM courses WHERE cid='{ textBox_CID.Text }'";
                using (SqlCommand command = new SqlCommand(Query, sqlConnection))
                {
                    sqlConnection.Open();
                    int count = (int)command.ExecuteScalar();
                    if (count > 0)
                    {
                        errorMsg($"A course with ID \"{ textBox_CID.Text }\" already exists.");
                        return;
                    }
                }

                Query = "INSERT INTO courses" +
                    $" (cid, cname, tid, credit, grade{ (NullCancelYear ? "" : ", cancel_year") })" +
                    $" VALUES ('{textBox_CID.Text}', N'{textBox_CName.Text}', '{comboBox_TID.Text}', {CourseCredit}, '{textBox_Grade.Text}'{ (NullCancelYear ? "" : $", {textBox_CancelYear.Text}") })";

                using (SqlCommand sqlCommand = new SqlCommand(Query, sqlConnection))
                {
                    int result = sqlCommand.ExecuteNonQuery();
                    if (result > 0)
                    {
                        label_instruction.Text = "Course entry added successfully.";
                        label_instruction.ForeColor = Color.Green;
                    }
                    else errorMsg("Error inserting course entry.");
                }

            }
        }

        private void errorMsg(string errMsg)
        {
            label_instruction.Text = errMsg;
            label_instruction.ForeColor = Color.Red;
        }

        private void btn_Exit_Click(object sender, EventArgs e) => Close();
    }
}
