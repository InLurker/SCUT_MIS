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
    public partial class Modify_Student : Form
    {
        public Modify_Student()
        {
            InitializeComponent();
            LoadStudentIDList();
        }

        private void comboBox_ID_TextChanged(object sender, EventArgs e)
        {
            if(comboBox_ID.Items.Contains(comboBox_ID.Text))
            {
                using (SqlConnection sqlConnection = new System.Data.SqlClient.SqlConnection(SqlHelper.CnnVal("database")))
                {
                    using (SqlCommand sqlCommand = new SqlCommand($"SELECT * FROM students WHERE sid='{comboBox_ID.Text}'", sqlConnection))
                    {
                        sqlConnection.Open();
                        using (SqlDataReader reader = sqlCommand.ExecuteReader(CommandBehavior.SingleRow))
                        {
                            if (reader.Read())
                            {
                                textBox_Name.Enabled = true;
                                textBox_EntAge.Enabled = true;
                                textBox_EntYear.Enabled = true;
                                textBox_Class.Enabled = true;

                                rbtn_Male.Enabled = true;
                                rbtn_Female.Enabled = true;

                                btn_Save.Enabled = true;

                                textBox_Name.Text = reader["sname"].ToString();
                                textBox_EntAge.Text = reader["entrance_age"].ToString();
                                textBox_EntYear.Text = reader["entrance_year"].ToString();
                                textBox_Class.Text = reader["class"].ToString();

                                rbtn_Male.Checked = (reader["sex"].ToString() == "male");
                                rbtn_Female.Checked = !rbtn_Male.Checked;
                                return;
                            }
                        }
                    }
                }
            } 
            else
            {
                textBox_Name.Enabled = false;
                textBox_EntAge.Enabled = false;
                textBox_EntYear.Enabled = false;
                textBox_Class.Enabled = false;

                rbtn_Male.Enabled = false;
                rbtn_Female.Enabled = false;

                btn_Save.Enabled = false;
            }
        }

        private void LoadStudentIDList()
        {
            using (SqlConnection sqlConnection = new System.Data.SqlClient.SqlConnection(SqlHelper.CnnVal("database")))
            {
                using (SqlCommand sqlCommand = new SqlCommand("SELECT sid FROM students", sqlConnection))
                {
                    sqlConnection.Open();
                    using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                    {
                        comboBox_ID.Items.Clear();
                        while (sqlDataReader.Read())
                            comboBox_ID.Items.Add(sqlDataReader[0]);
                    }
                }
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBox_Name.Text)) { errorMsg("Student name cannot be empty."); return; }
            if (textBox_Name.Text.Length > 20) { errorMsg("Student name exceeded character limit. (max.20)"); return; }

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
                string Query = "UPDATE students" +
                    $" SET sname=N'{textBox_Name.Text}', sex='{(rbtn_Male.Checked ? "male" : "female")}', entrance_age={textBox_EntAge.Text}, entrance_year={textBox_EntYear.Text}, class='{textBox_Class.Text}'" +
                    $" WHERE sid='{comboBox_ID.Text}'";

                using (SqlCommand sqlCommand = new SqlCommand(Query, sqlConnection))
                {
                    sqlConnection.Open();
                    int result = sqlCommand.ExecuteNonQuery();
                    if (result > 0)
                    {
                        label_instruction.Text = "Student entry modified successfully.";
                        label_instruction.ForeColor = Color.Green;
                    }
                    else errorMsg("Error modifying student entry.");
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
