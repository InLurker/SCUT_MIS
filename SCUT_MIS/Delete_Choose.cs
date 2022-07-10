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
    public partial class Delete_Choose : Form
    {
        public Delete_Choose()
        {
            InitializeComponent();
            LoadIDList();
        }

        private void LoadIDList()
        {
            using (SqlConnection sqlConnection = new System.Data.SqlClient.SqlConnection(SqlHelper.CnnVal("database")))
            {
                using (SqlCommand sqlCommand = new SqlCommand("SELECT sid FROM students", sqlConnection))
                {
                    sqlConnection.Open();
                    using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                    {
                        comboBox_SID.Items.Clear();
                        while (sqlDataReader.Read())
                            comboBox_SID.Items.Add(sqlDataReader[0]);
                    }

                    sqlCommand.CommandText = "SELECT tid FROM teachers";
                    using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                    {
                        comboBox_TID.Items.Clear();
                        while (sqlDataReader.Read())
                            comboBox_TID.Items.Add(sqlDataReader[0]);
                    }

                    sqlCommand.CommandText = "SELECT cid FROM courses";
                    using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                    {
                        comboBox_CID.Items.Clear();
                        while (sqlDataReader.Read())
                            comboBox_CID.Items.Add(sqlDataReader[0]);
                    }

                }
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            if (comboBox_CID.Items.Contains(comboBox_CID.Text))
            {
                using (SqlConnection sqlConnection = new System.Data.SqlClient.SqlConnection(SqlHelper.CnnVal("database")))
                {
                    using (SqlCommand sqlCommand = new SqlCommand($"SELECT chosen_year FROM choose WHERE sid='{comboBox_SID.Text}' AND cid='{comboBox_CID.Text}' AND tid='{comboBox_TID.Text}'", sqlConnection))
                    {
                        sqlConnection.Open();
                        using (SqlDataReader reader = sqlCommand.ExecuteReader(CommandBehavior.SingleRow))
                        {
                            if (reader.Read())
                            {
                                btn_Delete.Enabled = true;

                                label_SID.Text = comboBox_SID.Text;
                                label_CID.Text = comboBox_CID.Text;
                                label_TID.Text = comboBox_TID.Text;
                                label_ChosenYear.Text = reader["chosen_year"].ToString();
                                return;
                            }
                        }
                    }
                }
            }
            errorMsg("Course choosing not found.");
            btn_Delete.Enabled = false;
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlConnection = new System.Data.SqlClient.SqlConnection(SqlHelper.CnnVal("database")))
            {
                string Query = "DELETE FROM choose" +
                    $" WHERE sid='{label_SID.Text}' AND cid='{label_CID.Text}' AND tid='{label_TID.Text}'";

                using (SqlCommand sqlCommand = new SqlCommand(Query, sqlConnection))
                {
                    sqlConnection.Open();
                    int result = sqlCommand.ExecuteNonQuery();
                    if (result > 0)
                    {
                        label_instruction.Text = "Teacher entry deleted successfully.";
                        label_instruction.ForeColor = Color.Green;
                        LoadIDList();
                    }
                    else errorMsg("Error deleting teacher entry.");
                }

            }

        }
        private void errorMsg(string errorMsg)
        {
            label_instruction.Text = errorMsg;
            label_instruction.ForeColor = Color.Red;
        }

        private void btn_Exit_Click(object sender, EventArgs e) => Close();

        private void comboBox_ID_TextChanged(object sender, EventArgs e)
        {
            btn_Delete.Enabled = false;
        }
    }
}
