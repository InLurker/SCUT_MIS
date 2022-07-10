using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace SCUT_MIS
{
    public partial class Query_CourseInfo : Form
    {
        public DataTable retrievedData = null;
        public Query_CourseInfo()
        {
            InitializeComponent();
        }

        private void btn_SearchInfo_Click(object sender, EventArgs e)
        {
            using (SqlConnection Courses_SQLConnection = new System.Data.SqlClient.SqlConnection(SqlHelper.CnnVal("database")))
            {
                string Query;
                if (!String.IsNullOrWhiteSpace(textBox_info.Text) && (rbtn_ID.Checked || rbtn_Name.Checked))
                {
                    Query = $"SELECT COUNT(cid) FROM courses WHERE { (rbtn_ID.Checked ? $"cid = '{ textBox_info.Text }'" : $"cname LIKE LOWER('%{ textBox_info.Text }%')") }";

                    SqlCommand command = new SqlCommand(Query, Courses_SQLConnection);
                    Courses_SQLConnection.Open();
                    int count = (int)command.ExecuteScalar();
                    if (count == 0)
                    {
                        label_warning.Text = $"No courses of { (rbtn_ID.Checked ? "ID" : "name") } \"{ textBox_info.Text }\" found.";
                        label_warning.ForeColor = Color.Red;
                        return;
                    }
                }

                Query = "SELECT * FROM courses " +
                            "LEFT JOIN choose ON courses.cid = choose.cid AND courses.tid = choose.tid";

                if (!String.IsNullOrWhiteSpace(textBox_info.Text))
                {
                    if (rbtn_ID.Checked)
                        Query += $" WHERE courses.cid = '{ textBox_info.Text }'";
                    else
                        Query += $" WHERE LOWER(courses.cname) LIKE LOWER('%{ textBox_info.Text }%')"; //case insensitive
                }

                retrievedData = new DataTable();

                SqlDataAdapter dataAdapter = new SqlDataAdapter(Query, Courses_SQLConnection);
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
