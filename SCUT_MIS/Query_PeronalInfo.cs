using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace SCUT_MIS
{
    public partial class Query_PersonalInfo : Form
    {
        public DataTable retrievedData = null;
        public Query_PersonalInfo()
        {
            InitializeComponent();
        }

        private void btn_SearchInfo_Click(object sender, EventArgs e)
        {
            using (SqlConnection Students_SQLConnection = new System.Data.SqlClient.SqlConnection(SqlHelper.CnnVal("database")))
            {
                string Query;
                if (!String.IsNullOrWhiteSpace(textBox_info.Text) && (rbtn_ID.Checked || rbtn_Name.Checked))
                {
                    Query = $"SELECT COUNT(sid) FROM students WHERE { (rbtn_ID.Checked ? $"sid = '{ textBox_info.Text }'" : $"sname LIKE LOWER('%{ textBox_info.Text }%')") }";

                    SqlCommand command = new SqlCommand(Query, Students_SQLConnection);
                    Students_SQLConnection.Open();
                    int count = (int)command.ExecuteScalar();
                    if (count == 0)
                    {
                        label_warning.Text = $"No students of { (rbtn_ID.Checked ? "ID" : "name") } \"{ textBox_info.Text }\" found.";
                        label_warning.ForeColor = Color.Red;
                        return;
                    }
                }

                Query = "SELECT students.sid, students.sname, courses.cname FROM students" +
                            " INNER JOIN choose ON students.sid = choose.sid" +
                            " INNER JOIN courses ON choose.cid = courses.cid";

                if (!String.IsNullOrWhiteSpace(textBox_info.Text))
                {
                    if (rbtn_ID.Checked)
                        Query += $" WHERE students.sid = '{ textBox_info.Text }'";
                    else
                        Query += $" WHERE LOWER(students.sname) LIKE LOWER('%{ textBox_info.Text }%')"; //case insensitive
                }

                retrievedData = new DataTable();

                SqlDataAdapter dataAdapter = new SqlDataAdapter(Query, Students_SQLConnection);
                _ = new SqlCommandBuilder(dataAdapter);
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
