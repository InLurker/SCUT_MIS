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
    public partial class Modify_Choose : Form
    {
        public Modify_Choose()
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
                        {
                            comboBox_SID.Items.Add(sqlDataReader[0]);
                            comboBox_SID2.Items.Add(sqlDataReader[0]);
                        }
                    }

                    sqlCommand.CommandText = "SELECT tid FROM teachers";
                    using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                    {
                        comboBox_TID.Items.Clear();
                        while (sqlDataReader.Read())
                        {
                            comboBox_TID.Items.Add(sqlDataReader[0]);
                            comboBox_TID2.Items.Add(sqlDataReader[0]);
                        }
                    }

                    sqlCommand.CommandText = "SELECT cid FROM courses";
                    using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                    {
                        comboBox_CID.Items.Clear();
                        while (sqlDataReader.Read())
                        {
                            comboBox_CID.Items.Add(sqlDataReader[0]);
                            comboBox_CID2.Items.Add(sqlDataReader[0]);
                        }
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
                                comboBox_SID2.Enabled = true;
                                comboBox_CID2.Enabled = true;
                                comboBox_TID2.Enabled = true;
                                textBox_ChosenYear.Enabled = true;
                                btn_Save.Enabled = true;

                                comboBox_SID2.Text = comboBox_SID.Text;
                                comboBox_CID2.Text = comboBox_CID.Text;
                                comboBox_TID2.Text = comboBox_TID.Text;
                                textBox_ChosenYear.Text = reader["chosen_year"].ToString();
                                return;
                            }
                        }
                    }
                }
            }
            errorMsg("Course choosing not found.");
            comboBox_SID2.Enabled = false;
            comboBox_CID2.Enabled = false;
            comboBox_TID2.Enabled = false;
            textBox_ChosenYear.Enabled = false;
            btn_Save.Enabled = false;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            int ChosenYear;
            if (String.IsNullOrWhiteSpace(comboBox_SID2.Text)) { errorMsg("Course name cannot be empty."); return; }
            if (!comboBox_SID2.Items.Contains(comboBox_SID2.Text)) { errorMsg("Invalid Student ID."); return; }

            if (String.IsNullOrWhiteSpace(comboBox_CID2.Text)) { errorMsg("Course ID cannot be empty."); return; }
            if (!comboBox_CID2.Items.Contains(comboBox_CID2.Text)) { errorMsg("Invalid Course ID."); return; }

            if (String.IsNullOrWhiteSpace(comboBox_TID2.Text)) { errorMsg("Teacher ID cannot be empty."); return; }
            if (!comboBox_TID2.Items.Contains(comboBox_TID2.Text)) { errorMsg("Invalid Teacher ID."); return; }

            if (String.IsNullOrWhiteSpace(textBox_ChosenYear.Text)) { errorMsg("Chosen year cannot be empty."); return; }
            if (int.TryParse(textBox_ChosenYear.Text, out int chosenYear))
            {
                if (chosenYear < 0) { errorMsg("Chosen year cannot be negative."); return; }
                ChosenYear = chosenYear;
            }
            else { errorMsg("Invalid chosen year"); return; }

            using (SqlConnection sqlConnection = new System.Data.SqlClient.SqlConnection(SqlHelper.CnnVal("database")))
            {
                string Query = $"SELECT cancel_year FROM courses WHERE cid='{ comboBox_CID.Text }'";
                using (SqlCommand sqlCommand = new SqlCommand(Query, sqlConnection))
                {
                    sqlConnection.Open();
                    object DB_CancelYear = sqlCommand.ExecuteScalar();
                    if (DB_CancelYear != DBNull.Value)
                    {
                        int CancelYear = (int)DB_CancelYear;
                        if (ChosenYear > CancelYear) { errorMsg($"Course was cancelled at {CancelYear}."); return; }
                    }

                    sqlCommand.CommandText = "ALTER TABLE choose NOCHECK CONSTRAINT ALL";
                    sqlCommand.ExecuteNonQuery();
                    sqlCommand.CommandText = "UPDATE choose" +
                            $" SET sid='{comboBox_SID2.Text}', cid='{comboBox_CID2.Text}', tid='{comboBox_TID2.Text}', chosen_year={textBox_ChosenYear.Text}" +
                            $" WHERE sid='{comboBox_SID.Text}' AND cid='{comboBox_CID.Text}' AND tid='{comboBox_TID.Text}'";
                    if(sqlCommand.ExecuteNonQuery() > 0)
                    {
                        label_instruction.Text = "Course entry modified successfully.";
                        label_instruction.ForeColor = Color.Green;
                    } else errorMsg("Error modifying course choosing.");
                    sqlCommand.CommandText = "ALTER TABLE choose WITH CHECK CHECK CONSTRAINT ALL";
                    sqlCommand.ExecuteNonQuery();
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
            comboBox_SID2.Enabled = false;
            comboBox_CID2.Enabled = false;
            comboBox_TID2.Enabled = false;
            textBox_ChosenYear.Enabled = false;
            btn_Save.Enabled = false;
        }
    }
}
