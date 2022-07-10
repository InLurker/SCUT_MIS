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
    public partial class Modify_Score : Form
    {
        private string QueryFilter = "";

        private readonly SqlConnection sqlConnection = new System.Data.SqlClient.SqlConnection(SqlHelper.CnnVal("database"));

        public DataTable retrievedData = new DataTable();

        public Modify_Score()
        {
            InitializeComponent();
            sqlConnection.Open();
            LoadDataGridView();

            using (SqlCommand sqlCommand = new SqlCommand("SELECT sid FROM students", sqlConnection))
            {
                using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                {
                    while (sqlDataReader.Read())
                        comboBox_Student.Items.Add(sqlDataReader[0]);
                }
                dataGridView.DataSource = retrievedData;
            }
        }

        private void LoadDataGridView()
        {
            const string sqlQuery = "SELECT choose.sid AS 'Student ID', students.sname AS 'Student Name', courses.cname AS 'Course Name', choose.cid AS 'Course ID', choose.score AS 'Score'" +
                " FROM choose" +
                " INNER JOIN courses ON choose.cid = courses.cid" +
                " INNER JOIN students ON choose.sid = students.sid";

            using (SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlQuery, sqlConnection))
            {
                using (SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(dataAdapter))
                {
                    retrievedData.Clear();
                    dataAdapter.Fill(retrievedData);
                }
            }
        }

        private void comboBox_Student_TextChanged(object sender, EventArgs e)
        {
            comboBox_Course.Enabled = false;
            textBox_Score.Enabled = false;
            btn_Confirm.Enabled = false;
            comboBox_Course.Text = "";
            textBox_Score.Text = "";

            if (String.IsNullOrEmpty(comboBox_Student.Text))
            {
                (dataGridView.DataSource as DataTable).DefaultView.RowFilter = "";
            }
            else if (comboBox_Student.Items.Contains(comboBox_Student.Text))
            {
                QueryFilter = $" WHERE choose.sid = '{comboBox_Student.Text}'";

                using (SqlCommand sqlCommand = new SqlCommand("SELECT choose.cid FROM choose INNER JOIN students ON students.sid = choose.sid" + QueryFilter, sqlConnection))
                {
                    using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                    {
                        comboBox_Course.Items.Clear();
                        while (sqlDataReader.Read())
                            comboBox_Course.Items.Add(sqlDataReader[0]);
                        if(comboBox_Course.Items.Count > 0)
                            comboBox_Course.SelectedIndex = 0;
                    }
                }
                comboBox_Course.Enabled = true;
                (dataGridView.DataSource as DataTable).DefaultView.RowFilter = $"[Student ID] = '{ comboBox_Student.Text }'";
            }
            else return; //return if string is not empty nor contain in dropdown list
        }

        private void comboBox_Course_TextChanged(object sender, EventArgs e)
        {
            if (comboBox_Course.Items.Contains(comboBox_Course.Text))
            {
                textBox_Score.Enabled = true;
                btn_Confirm.Enabled = true;
                QueryFilter = $" WHERE choose.sid = '{comboBox_Student.Text}' AND choose.cid = '{comboBox_Course.Text}'";
            }
            else
            {
                textBox_Score.Enabled = false;
                btn_Confirm.Enabled = false;
            }
        }
        private void btn_Confirm_Click(object sender, EventArgs e)
        {
            if (float.TryParse(textBox_Score.Text, out float newScore))
            {
                string Query = $"UPDATE choose SET score = { newScore }" + QueryFilter;
                using (SqlCommand sqlCommand = new SqlCommand(Query, sqlConnection))
                {
                    int result = sqlCommand.ExecuteNonQuery();
                    if (result > 0)
                    {
                        label_instruction.Text = "Score modified successfully.";
                        label_instruction.ForeColor = Color.Green;
                        LoadDataGridView();
                    }
                    else
                    {
                        label_instruction.Text = "Error inserting data into database.";
                        label_instruction.ForeColor = Color.Red;
                    }
                }
            }
            else
            {
                label_instruction.Text = "Please enter a valid score input.";
                label_instruction.ForeColor = Color.Red;
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Modify_Score_FormClosing(object sender, FormClosingEventArgs e)
        {
            sqlConnection.Dispose();
        }

    }
}
