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
    public partial class Modify_Teacher : Form
    {
        public Modify_Teacher()
        {
            InitializeComponent();
            LoadTeacherIDList();
        }

        private void comboBox_ID_TextChanged(object sender, EventArgs e)
        {
            if(comboBox_ID.Items.Contains(comboBox_ID.Text))
            {
                using (SqlConnection sqlConnection = new System.Data.SqlClient.SqlConnection(SqlHelper.CnnVal("database")))
                {
                    using (SqlCommand sqlCommand = new SqlCommand($"SELECT * FROM teachers WHERE tid='{comboBox_ID.Text}'", sqlConnection))
                    {
                        sqlConnection.Open();
                        using (SqlDataReader reader = sqlCommand.ExecuteReader(CommandBehavior.SingleRow))
                        {
                            if (reader.Read())
                            {
                                textBox_Name.Enabled = true;
                                textBox_Course.Enabled = true;

                                btn_Save.Enabled = true;

                                textBox_Name.Text = reader["tname"].ToString();
                                textBox_Course.Text = reader["course"].ToString();
                                return;
                            }
                        }
                    }
                }
            } 
            else
            {
                textBox_Name.Enabled = false;
                textBox_Course.Enabled = false;

                btn_Save.Enabled = false;
            }
        }

        private void LoadTeacherIDList()
        {
            using (SqlConnection sqlConnection = new System.Data.SqlClient.SqlConnection(SqlHelper.CnnVal("database")))
            {
                using (SqlCommand sqlCommand = new SqlCommand("SELECT tid FROM teachers", sqlConnection))
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
            if (String.IsNullOrWhiteSpace(textBox_Name.Text)) { errorMsg("Teacher name cannot be empty."); return; }
            if (textBox_Name.Text.Length > 20) { errorMsg("Teacher name exceeded character limit. (max.20)"); return; }

            if (String.IsNullOrWhiteSpace(textBox_Course.Text)) { errorMsg("Teacher class cannot be empty."); return; }
            if (textBox_Course.Text.Length > 20) { errorMsg("Teacher class exceeded character limit. (max.20)"); return; }

            using (SqlConnection sqlConnection = new System.Data.SqlClient.SqlConnection(SqlHelper.CnnVal("database")))
            {
                string Query = "UPDATE teachers" +
                    $" SET tname=N'{textBox_Name.Text}', course=N'{textBox_Course.Text}'" +
                    $" WHERE tid='{comboBox_ID.Text}'";

                using (SqlCommand sqlCommand = new SqlCommand(Query, sqlConnection))
                {
                    sqlConnection.Open();
                    int result = sqlCommand.ExecuteNonQuery();
                    if (result > 0)
                    {
                        label_instruction.Text = "Teacher entry modified successfully.";
                        label_instruction.ForeColor = Color.Green;
                    }
                    else errorMsg("Error modifying teacher entry.");
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
