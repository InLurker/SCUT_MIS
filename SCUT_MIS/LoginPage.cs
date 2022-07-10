using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace SCUT_MIS
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private bool verifyInput()
        {
            if (!String.IsNullOrWhiteSpace(textBox_username.Text)
                && !String.IsNullOrWhiteSpace(textBox_pass.Text))
            {
                if (rbtn_student.Checked || rbtn_teacher.Checked || rbtn_admin.Checked)
                {
                    if (textBox_username.Text.Length <= 15 && textBox_pass.Text.Length <= 15)
                        return true;
                    else
                    {
                        label_instruction.Text = "Username or password exceeded character limit (max.15)";
                        label_instruction.ForeColor = Color.Red;
                    }
                }
                else
                {
                    label_instruction.Text = "Select an account option.";
                    label_instruction.ForeColor = Color.Red;
                }
            }
            else
            {
                label_instruction.Text = "Username and password cannot be empty.";
                label_instruction.ForeColor = Color.Red;
            }
            return false;
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            if (!verifyInput()) //if input invalid, return early
                return;

            string AccountTableName = "account_" + (rbtn_student.Checked ? "students" : (rbtn_teacher.Checked ? "teachers" : "admins"));

            using (SqlConnection Account_SQLConnection = new System.Data.SqlClient.SqlConnection(SqlHelper.CnnVal("database")))
            {
                string Query = $"SELECT COUNT(username) FROM { AccountTableName } WHERE username = '{ textBox_username.Text }'";
                SqlCommand command = new SqlCommand(Query, Account_SQLConnection);

                Account_SQLConnection.Open();
                int count = (int)command.ExecuteScalar();
                if (count == 0)
                {
                    Query = $"INSERT INTO { AccountTableName } (username, password) VALUES ('{ textBox_username.Text }', '{ textBox_pass.Text }')";
                    command.CommandText = Query;
                    command.ExecuteNonQuery();
                    label_instruction.Text = "Successfully registered. You can now log in.";
                    label_instruction.ForeColor = Color.Green;
                }
                else
                {
                    label_instruction.Text = "Account username is already taken.";
                    label_instruction.ForeColor = Color.Red;
                }
            }
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            label_instruction.Text = "Loading...";
            label_instruction.ForeColor = Color.Black;

            if (!verifyInput()) //if input invalid, return early
                return;

            string AccountTableName;
            Form Portal;
            if (rbtn_student.Checked)
            {
                AccountTableName = "account_students";
                Portal = new Portal_Student(textBox_username.Text);
            }
            else if (rbtn_teacher.Checked)
            {
                AccountTableName = "account_teachers";
                Portal = new Portal_Teacher(textBox_username.Text);
            }
            else
            {
                AccountTableName = "account_admins";
                Portal = new Portal_Admin(textBox_username.Text);
            }

            using (SqlConnection Account_SQLConnection = new System.Data.SqlClient.SqlConnection(SqlHelper.CnnVal("database")))
            {
                string Query = $"SELECT COUNT(username) FROM { AccountTableName } WHERE username = '{ textBox_username.Text }' AND  password = '{ textBox_pass.Text }'";
                SqlCommand command = new SqlCommand(Query, Account_SQLConnection);

                Account_SQLConnection.Open();
                int count = (Int32)command.ExecuteScalar();
                if (count > 0)
                {
                    label_instruction.Text = "Successfully logged in.";
                    label_instruction.ForeColor = Color.Green;
                    Portal.ShowDialog();
                }
                else
                {
                    label_instruction.Text = "Incorrect password or account doesn't exist.";
                    label_instruction.ForeColor = Color.Red;
                }
            }
        }
    }
}
