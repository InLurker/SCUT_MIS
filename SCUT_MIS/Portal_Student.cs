using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SCUT_MIS
{
    public partial class Portal_Student : Form
    {
        public Portal_Student(string user_id) {
            InitializeComponent();
            this.label_Username.Text = user_id;
        }

        private void btn_PersonalInfo_Click(object sender, EventArgs e)
        {
            Query_PersonalInfo query_PersonalInfo = new Query_PersonalInfo();
            query_PersonalInfo.ShowDialog();
            if (query_PersonalInfo.retrievedData != null)
            {
                label_Instruction.Text = "Personal info query result:";
                dataGridView1.DataSource = query_PersonalInfo.retrievedData;
                if (dataGridView1.Rows.Count == 0)
                    label_Instruction.Text = "No results found.";
            }
        }

        private void btn_CourseInfo_Click(object sender, EventArgs e)
        {
            Query_CourseInfo query_CourseInfo = new Query_CourseInfo();
            query_CourseInfo.ShowDialog();
            if (query_CourseInfo.retrievedData != null)
            {
                label_Instruction.Text = "Course info query result:";
                dataGridView1.DataSource = query_CourseInfo.retrievedData;
                if (dataGridView1.Rows.Count == 0)
                    label_Instruction.Text = "No results found.";
            }
        }

        private void btn_ScoreLookup_Click(object sender, EventArgs e)
        {
            Query_ScoreLookup query_ScoreLookup = new Query_ScoreLookup();
            query_ScoreLookup.ShowDialog();
            if (query_ScoreLookup.retrievedData != null)
            {
                label_Instruction.Text = "Score lookup query result:";
                dataGridView1.DataSource = query_ScoreLookup.retrievedData;
                if (dataGridView1.Rows.Count == 0)
                    label_Instruction.Text = "No results found.";
            }
        }

        private void btn_AverageScore_Click(object sender, EventArgs e)
        {
            Query_AverageScore query_AverageScore = new Query_AverageScore();
            query_AverageScore.ShowDialog();
            if (query_AverageScore.retrievedData != null)
            {
                label_Instruction.Text = "Average score query result:";
                dataGridView1.DataSource = query_AverageScore.retrievedData;
                if (dataGridView1.Rows.Count == 0)
                    label_Instruction.Text = "No results found.";
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
