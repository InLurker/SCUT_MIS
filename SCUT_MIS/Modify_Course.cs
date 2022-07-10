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
    public partial class Modify_Course : Form
    {
        public Modify_Course()
        {
            InitializeComponent();
            LoadCourseIDList();
        }

        private void comboBox_ID_TextChanged(object sender, EventArgs e)
        {
            if(comboBox_ID.Items.Contains(comboBox_ID.Text))
            {
                using (SqlConnection sqlConnection = new System.Data.SqlClient.SqlConnection(SqlHelper.CnnVal("database")))
                {
                    using (SqlCommand sqlCommand = new SqlCommand($"SELECT * FROM courses WHERE cid='{comboBox_ID.Text}'", sqlConnection))
                    {
                        sqlConnection.Open();
                        using (SqlDataReader reader = sqlCommand.ExecuteReader(CommandBehavior.SingleRow))
                        {
                            if (reader.Read())
                            {
                                textBox_Name.Enabled = true;
                                comboBox_TID.Enabled = true;
                                textBox_Credit.Enabled = true;
                                textBox_Grade.Enabled = true;
                                textBox_CancelYear.Enabled = true;

                                btn_Save.Enabled = true;

                                textBox_Name.Text = reader["cname"].ToString();
                                textBox_Credit.Text = reader["credit"].ToString();
                                textBox_Grade.Text = reader["grade"].ToString();
                                textBox_CancelYear.Text = reader["cancel_year"].ToString();
                                comboBox_TID.Text = reader["tid"].ToString();

                                return;
                            }
                        }
                    }
                }
            } 
            else
            {
                textBox_Name.Enabled = false;
                comboBox_TID.Enabled = false;
                textBox_Credit.Enabled = false;
                textBox_Grade.Enabled = false;
                textBox_CancelYear.Enabled = false;

                btn_Save.Enabled = false;
            }
        }

        private void LoadCourseIDList()
        {
            using (SqlConnection sqlConnection = new System.Data.SqlClient.SqlConnection(SqlHelper.CnnVal("database")))
            {
                using (SqlCommand sqlCommand = new SqlCommand("SELECT cid FROM courses", sqlConnection))
                {
                    sqlConnection.Open();
                    using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                    {
                        comboBox_ID.Items.Clear();
                        while (sqlDataReader.Read())
                            comboBox_ID.Items.Add(sqlDataReader[0]);
                    }

                    sqlCommand.CommandText = "SELECT tid FROM teachers";
                    using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                    {
                        comboBox_TID.Items.Clear();
                        while (sqlDataReader.Read())
                            comboBox_TID.Items.Add(sqlDataReader[0]);
                    }

                }
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            decimal CourseCredit;
            bool NullCancelYear = false;

            if (String.IsNullOrWhiteSpace(textBox_Name.Text)) { errorMsg("Course name cannot be empty."); return; }
            if (textBox_Name.Text.Length > 20) { errorMsg("Course name exceeded character limit. (max.20)"); return; }

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
                string Query = "UPDATE courses" +
                    $" SET cname=N'{textBox_Name.Text}', tid='{comboBox_TID.Text}', credit={CourseCredit}, grade='{textBox_Grade.Text}', cancel_year={ (NullCancelYear ? "NULL" : $"'{textBox_CancelYear.Text}'") }" +
                    $" WHERE cid='{comboBox_ID.Text}'";

                using (SqlCommand sqlCommand = new SqlCommand(Query, sqlConnection))
                {
                    sqlConnection.Open();
                    int result = sqlCommand.ExecuteNonQuery();
                    if (result > 0)
                    {
                        label_instruction.Text = "Course entry modified successfully.";
                        label_instruction.ForeColor = Color.Green;
                        LoadCourseIDList();
                    }
                    else errorMsg("Error modifying course entry.");
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
