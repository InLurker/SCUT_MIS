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
    public partial class Query_AverageScore : Form
    {
        public DataTable retrievedData = null;

        public Query_AverageScore()
        {
            InitializeComponent();
        }

        private void rbtn_aStu_CheckedChanged(object sender, EventArgs e)
        {
            label_warning.Text = "Leaving this box empty will display information for all students.";
            label_warning.ForeColor = Color.Black;
            if(rbtn_aStu.Checked)
            {
                rbtn_ID.Text = "Student ID";
                rbtn_Name.Text = "Student Name";
            }
        }

        private void rbtn_allStu_CheckedChanged(object sender, EventArgs e)
        {
            if(rbtn_allStu.Checked)
            {
                textBox.ReadOnly = true;
                rbtn_ID.Enabled = false;
                rbtn_ID.Text = "Student ID";
                rbtn_Name.Enabled = false;
                rbtn_Name.Text = "Student Name";
                label_warning.Enabled = false;
            }
            else //when unchecked
            {
                textBox.ReadOnly = false;
                rbtn_ID.Enabled = true;
                rbtn_Name.Enabled = true;
                label_warning.Enabled = true;
            }
        }
        private void rbtn_classStu_CheckedChanged(object sender, EventArgs e)
        {
            label_warning.Text = "Leaving this box empty will display information for all classes.";
            label_warning.ForeColor = Color.Black;
            if(rbtn_classStu.Checked)
            {
                rbtn_ID.Checked = false;
                rbtn_ID.Enabled = false;
                rbtn_ID.Text = "ID";
                rbtn_Name.Checked = true;
                rbtn_Name.Text = "Class Name";
            }
            else rbtn_ID.Enabled = true; //when unchecked
        }
        private void rbtn_courseStu_CheckedChanged(object sender, EventArgs e)
        {
            label_warning.Text = "Leaving this box empty will display information for all courses.";
            label_warning.ForeColor = Color.Black;
            if(rbtn_courseStu.Checked)
            {
                rbtn_ID.Text = "Course ID";
                rbtn_Name.Text = "Course Name";
            }
        }
        private void btn_Search_Click(object sender, EventArgs e)
        {
            string Query;
            if (rbtn_allStu.Checked)
            {
                using (SqlConnection sqlConnection = new System.Data.SqlClient.SqlConnection(SqlHelper.CnnVal("database")))
                {
                    Query = "SELECT students.sid, students.sname, FORMAT(AVG(choose.score), 'N2') AS average_score" +
                        " FROM students LEFT JOIN choose ON students.sid = choose.sid" +
                        " GROUP BY students.sid, students.sname";
                    retrievedData = new DataTable();

                    SqlDataAdapter dataAdapter = new SqlDataAdapter(Query, sqlConnection);
                    SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(dataAdapter);
                    dataAdapter.Fill(retrievedData);
                }
                Close();
            }

            if (rbtn_aStu.Checked)
            {
                using (SqlConnection sqlConnection = new System.Data.SqlClient.SqlConnection(SqlHelper.CnnVal("database")))
                {
                    string QueryFilter = "";

                    if (!String.IsNullOrWhiteSpace(textBox.Text))
                    {
                        QueryFilter = $" WHERE { (rbtn_ID.Checked ? $"students.sid = '{ textBox.Text }'" : $"students.sname LIKE LOWER('%{ textBox.Text }%')") }";
                        Query = $"SELECT COUNT(students.sid) FROM students" + QueryFilter;
                        SqlCommand sqlCommand = new SqlCommand(Query, sqlConnection);
                        sqlConnection.Open();
                        int count = (int)sqlCommand.ExecuteScalar();
                        if (count == 0)
                        {
                            label_warning.Text = $"No students of { (rbtn_ID.Checked ? "ID" : "name") } \"{ textBox.Text }\" found.";
                            label_warning.ForeColor = Color.Red;
                            return;
                        }
                    }

                    Query = "SELECT students.sid, students.sname, FORMAT(AVG(score), 'N2') AS average_score " +
                        "FROM students LEFT JOIN choose ON students.sid = choose.sid"
                        + QueryFilter
                        + " GROUP BY students.sid, students.sname";

                    retrievedData = new DataTable();

                    SqlDataAdapter dataAdapter = new SqlDataAdapter(Query, sqlConnection);
                    SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(dataAdapter);
                    dataAdapter.Fill(retrievedData);
                    Close();
                }
            }

            if (rbtn_classStu.Checked)
            {
                using (SqlConnection sqlConnection = new System.Data.SqlClient.SqlConnection(SqlHelper.CnnVal("database")))
                {
                    string QueryFilter = "";

                    if (!String.IsNullOrWhiteSpace(textBox.Text))
                    {
                        QueryFilter = $" WHERE LOWER(students.class) LIKE LOWER('%{ textBox.Text }%')";
                        Query = $"SELECT COUNT(students.class) FROM students" + QueryFilter;
                        SqlCommand sqlCommand = new SqlCommand(Query, sqlConnection);
                        sqlConnection.Open();
                        int count = (int)sqlCommand.ExecuteScalar();
                        if (count == 0)
                        {
                            label_warning.Text = $"No class of name \"{ textBox.Text }\" found.";
                            label_warning.ForeColor = Color.Red;
                            return;
                        }
                    }

                    Query = "SELECT students.class, FORMAT(AVG(choose.score), 'N2') AS average_score" +
                        " FROM students LEFT JOIN choose ON students.sid = choose.sid" +
                        QueryFilter +
                        " GROUP BY class";

                    retrievedData = new DataTable();

                    SqlDataAdapter dataAdapter = new SqlDataAdapter(Query, sqlConnection);
                    SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(dataAdapter);
                    dataAdapter.Fill(retrievedData);
                    Close();
                }
            }


            if (rbtn_courseStu.Checked)
            {
                using (SqlConnection sqlConnection = new System.Data.SqlClient.SqlConnection(SqlHelper.CnnVal("database")))
                {
                    string QueryFilter = "";

                    if (!String.IsNullOrWhiteSpace(textBox.Text))
                    {
                        QueryFilter = $" WHERE { (rbtn_ID.Checked ? $"courses.cid = '{ textBox.Text }'" : $"courses.cname LIKE LOWER('%{ textBox.Text }%')") }";
                        Query = $"SELECT COUNT(cid) FROM courses" + QueryFilter;
                        SqlCommand sqlCommand = new SqlCommand(Query, sqlConnection);
                        sqlConnection.Open();
                        int count = (int)sqlCommand.ExecuteScalar();
                        if (count == 0)
                        {
                            label_warning.Text = $"No courses of { (rbtn_ID.Checked ? "ID" : "name") } \"{ textBox.Text }\" found.";
                            label_warning.ForeColor = Color.Red;
                            return;
                        }
                    }

                    Query = "SELECT courses.cid, courses.cname, FORMAT(AVG(score), 'N2') AS average_score" +
                        " FROM courses LEFT JOIN choose ON courses.cid = choose.cid"
                        + QueryFilter +
                        " GROUP BY courses.cid, courses.cname";

                    retrievedData = new DataTable();

                    SqlDataAdapter dataAdapter = new SqlDataAdapter(Query, sqlConnection);
                    SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(dataAdapter);
                    dataAdapter.Fill(retrievedData);
                    Close();
                }
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
