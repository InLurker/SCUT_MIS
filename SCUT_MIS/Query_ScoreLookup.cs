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
    public partial class Query_ScoreLookup : Form
    {
        public DataTable retrievedData = null;

        public Query_ScoreLookup()
        {
            InitializeComponent();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            using (SqlConnection SQLConnection = new System.Data.SqlClient.SqlConnection(SqlHelper.CnnVal("database")))
            {
                string Query;
                if (!String.IsNullOrWhiteSpace(textBox_Student.Text) && !String.IsNullOrWhiteSpace(textBox_Course.Text))
                {
                    Query = $"SELECT COUNT(sid) FROM students WHERE { (rbtn_sid.Checked ? $"sid = '{ textBox_Student.Text }'" : $"sname LIKE LOWER('%{ textBox_Student.Text }%')") }";

                    SqlCommand command = new SqlCommand(Query, SQLConnection);
                    SQLConnection.Open();
                    int count = (int)command.ExecuteScalar();
                    if (count == 0)
                    {
                        label_warning.Text = $"No students of { (rbtn_sid.Checked ? "ID" : "name") } \"{ textBox_Student.Text }\" found.";
                        label_warning.ForeColor = Color.Red;
                        return;
                    }

                    Query = $"SELECT COUNT(cid) FROM courses WHERE { (rbtn_cid.Checked ? $"cid = '{ textBox_Course.Text }'" : $"cname LIKE LOWER('%{ textBox_Course.Text }%')") }";
                    command.CommandText = Query;
                    count = (int)command.ExecuteScalar();
                    if (count == 0)
                    {
                        label_warning.Text = $"No courses of { (rbtn_cid.Checked ? "ID" : "name") } \"{ textBox_Course.Text }\" found.";
                        label_warning.ForeColor = Color.Red;
                        return;
                    }
                }

                Query = "SELECT students.sid, students.sname, courses.cname, choose.score, choose.cid FROM students" +
                    " LEFT JOIN choose ON students.sid = choose.sid" +
                    " LEFT JOIN courses ON choose.cid = courses.cid";

                string QueryFilter = "";

                if (!String.IsNullOrWhiteSpace(textBox_Student.Text))
                {
                    QueryFilter = " WHERE ";

                    if (rbtn_sid.Checked)
                        QueryFilter += $"students.sid = '{ textBox_Student.Text }'";
                    else
                        QueryFilter += $"LOWER(students.sname) LIKE LOWER('%{ textBox_Student.Text }%')"; //case insensitive
                }

                if(!String.IsNullOrWhiteSpace(textBox_Course.Text))
                {

                    QueryFilter += String.IsNullOrEmpty(QueryFilter) ? " WHERE " : " AND ";

                    if (rbtn_sid.Checked)
                        QueryFilter += $"courses.cid = '{ textBox_Course.Text }'";
                    else
                        QueryFilter += $"LOWER(courses.cname) LIKE LOWER('%{ textBox_Course.Text }%')"; //case insensitive
                }

                Query += QueryFilter;

                retrievedData = new DataTable();

                SqlDataAdapter dataAdapter = new SqlDataAdapter(Query, SQLConnection);
                SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(dataAdapter);
                dataAdapter.Fill(retrievedData);
            }
            Close();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
