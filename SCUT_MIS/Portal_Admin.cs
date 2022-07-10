using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace SCUT_MIS
{
    public partial class Portal_Admin : Form
    {
        public Portal_Admin(string user_id) {
            InitializeComponent();
            this.label_Username.Text = user_id;
            LoadDataGridView();
        }

        private void LoadDataGridView()
        {
            string sqlQuery = "SELECT * FROM ";

            if (rbtn_Students.Checked)
                sqlQuery += "students";
            else if (rbtn_Teachers.Checked)
                sqlQuery += "teachers";
            else if (rbtn_Courses.Checked)
                sqlQuery += "courses";
            else if (rbtn_Choose.Checked)
                sqlQuery += "choose";
            else return;

            using (SqlConnection sqlConnection = new System.Data.SqlClient.SqlConnection(SqlHelper.CnnVal("database")))
            {
                using (SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlQuery, sqlConnection))
                {
                    using (SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(dataAdapter))
                    {
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);
                        dataGridView.DataSource = dataTable;
                    }
                }
            }
        }

        private void rbtn_OnClick(object sender, EventArgs e) => LoadDataGridView();

        private void btn_Stu_Insert_Click(object sender, EventArgs e) => _ = new Insert_Student().ShowDialog();

        private void btn_Stu_Modify_Click(object sender, EventArgs e) => _ = new Modify_Student().ShowDialog();

        private void btn_Stu_Delete_Click(object sender, EventArgs e) => _ = new Delete_Student().ShowDialog();

        private void btn_Teacher_Insert_Click(object sender, EventArgs e) => _ = new Insert_Teacher().ShowDialog();

        private void btn_Teacher_Modify_Click(object sender, EventArgs e) => _ = new Modify_Teacher().ShowDialog();

        private void btn_Teacher_Delete_Click(object sender, EventArgs e) => _ = new Delete_Teacher().ShowDialog();

        private void btn_Courses_Insert_Click(object sender, EventArgs e) => _ = new Insert_Course().ShowDialog();

        private void btn_Courses_Modify_Click(object sender, EventArgs e) => _ = new Modify_Course().ShowDialog();

        private void btn_Courses_Delete_Click(object sender, EventArgs e) => _ = new Delete_Course().ShowDialog();

        private void btn_Choose_Insert_Click(object sender, EventArgs e) => _ = new Insert_Choose().ShowDialog();

        private void btn_Choose_Modify_Click(object sender, EventArgs e) => _ = new Modify_Choose().ShowDialog();

        private void btn_Choose_Delete_Click(object sender, EventArgs e) => _ = new Delete_Choose().ShowDialog();

        private void btn_Exit_Click(object sender, EventArgs e) => this.Close();
    }
}
