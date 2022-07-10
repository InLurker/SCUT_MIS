using System;
using System.Windows.Forms;

namespace SCUT_MIS
{
    public partial class Portal_Teacher : Form
    {
        public Portal_Teacher(string user_id) {
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
                dataGridView.DataSource = query_PersonalInfo.retrievedData;
                if (dataGridView.Rows.Count == 0)
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
                dataGridView.DataSource = query_CourseInfo.retrievedData;
                if (dataGridView.Rows.Count == 0)
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
                dataGridView.DataSource = query_ScoreLookup.retrievedData;
                if (dataGridView.Rows.Count == 0)
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
                dataGridView.DataSource = query_AverageScore.retrievedData;
                if (dataGridView.Rows.Count == 0)
                    label_Instruction.Text = "No results found.";
            }
        }

        private void btn_ModifyScore_Click(object sender, EventArgs e)
        {
            Modify_Score modify_Score = new Modify_Score();
            modify_Score.ShowDialog();
            label_Instruction.Text = "Score modification result:";
            dataGridView.DataSource = modify_Score.retrievedData;
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
