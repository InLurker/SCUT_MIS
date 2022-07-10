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
    public partial class Insert_Choose : Form
    {
        public Insert_Choose()
        {
            InitializeComponent();
            using (SqlConnection sqlConnection = new System.Data.SqlClient.SqlConnection(SqlHelper.CnnVal("database")))
            {
                using (SqlCommand sqlCommand = new SqlCommand("SELECT sid FROM students", sqlConnection))
                {
                    sqlConnection.Open();
                    using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                    {
                        while (sqlDataReader.Read())
                            comboBox_SID.Items.Add(sqlDataReader[0]);
                    }

                    sqlCommand.CommandText = "SELECT tid FROM teachers";
                    using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                    {
                        while (sqlDataReader.Read())
                            comboBox_TID.Items.Add(sqlDataReader[0]);
                    }

                    sqlCommand.CommandText = "SELECT cid FROM courses";
                    using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                    {
                        while (sqlDataReader.Read())
                            comboBox_CID.Items.Add(sqlDataReader[0]);
                    }
                }
            }
        }

        private void btn_Confirm_Click(object sender, EventArgs e)
        {
            int ChosenYear;
            if (String.IsNullOrWhiteSpace(comboBox_SID.Text)) { errorMsg("Course name cannot be empty."); return; }
            if (!comboBox_SID.Items.Contains(comboBox_SID.Text)) { errorMsg("Invalid Student ID."); return; }

            if (String.IsNullOrWhiteSpace(comboBox_CID.Text)) { errorMsg("Course ID cannot be empty."); return; }
            if (!comboBox_CID.Items.Contains(comboBox_CID.Text)) { errorMsg("Invalid Course ID."); return; }
            
            if (String.IsNullOrWhiteSpace(comboBox_TID.Text)) { errorMsg("Teacher ID cannot be empty."); return; }
            if (!comboBox_TID.Items.Contains(comboBox_TID.Text)) { errorMsg("Invalid Teacher ID."); return; }

            if (String.IsNullOrWhiteSpace(textBox_ChosenYear.Text)) { errorMsg("Chosen year cannot be empty."); return; }
            if (int.TryParse(textBox_ChosenYear.Text, out int chosenYear))
            {
                if (chosenYear < 0) { errorMsg("Chosen year cannot be negative."); return; }
                ChosenYear = chosenYear;
            } else { errorMsg("Invalid chosen year"); return; }

            using (SqlConnection sqlConnection = new System.Data.SqlClient.SqlConnection(SqlHelper.CnnVal("database")))
            {
                string Query = $"SELECT cancel_year FROM courses WHERE cid='{ comboBox_CID.Text }'";
                using (SqlCommand sqlCommand = new SqlCommand(Query, sqlConnection))
                {
                    sqlConnection.Open();
                    object DB_CancelYear = sqlCommand.ExecuteScalar();
                    if(DB_CancelYear != DBNull.Value)
                    {
                        int CancelYear = (int)DB_CancelYear;
                        if(ChosenYear > CancelYear) { errorMsg($"Course was cancelled at {CancelYear}."); return; }
                    }

                    sqlCommand.CommandText = "INSERT INTO choose" +
                        " (sid, cid, tid, chosen_year)" +
                        $" VALUES ('{comboBox_SID.Text}', '{comboBox_CID.Text}', '{comboBox_TID.Text}', {textBox_ChosenYear.Text})";
                    int result = sqlCommand.ExecuteNonQuery();
                    if (result > 0)
                    {
                        label_instruction.Text = "Course choosing entry added successfully.";
                        label_instruction.ForeColor = Color.Green;
                    }
                    else errorMsg("Error inserting course choosing entry.");
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
