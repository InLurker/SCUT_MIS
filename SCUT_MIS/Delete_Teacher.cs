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
    public partial class Delete_Teacher : Form
    {
        public Delete_Teacher()
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
                                btn_Delete.Enabled = true;

                                label_Name.Text = reader["tname"].ToString();
                                label_Course.Text = reader["course"].ToString();
                                return;
                            }
                        }
                    }
                }
            } 
            else
            {
                btn_Delete.Enabled = false;
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

        private void btn_Delete_Click(object sender, EventArgs e)
        {

            using (SqlConnection sqlConnection = new System.Data.SqlClient.SqlConnection(SqlHelper.CnnVal("database")))
            {
                string Query = "DELETE FROM teachers" +
                    $" WHERE tid='{comboBox_ID.Text}'";

                using (SqlCommand sqlCommand = new SqlCommand(Query, sqlConnection))
                {
                    sqlConnection.Open();
                    int result = sqlCommand.ExecuteNonQuery();
                    if (result > 0)
                    {
                        label_instruction.Text = "Teacher entry deleted successfully.";
                        label_instruction.ForeColor = Color.Green;
                        LoadTeacherIDList();
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
