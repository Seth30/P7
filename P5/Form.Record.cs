using System;
using System.Windows.Forms;

namespace P5
{
    public partial class FormRecord : Form
    {
        public FormRecord()
        {
            InitializeComponent();
        }
        private void PreferenceCreateProject_Load(object sender, EventArgs e)
        {
            this.CenterToParent();
        }
        private void cancelbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void createbutton_Click(object sender, EventArgs e)
        {
            FakeIssueRepository issueRepository = new FakeIssueRepository();
            Issue issue = new Issue();
            issue.Title = Titlebox.Text.Trim();
            var rand = new Random();
            var i = rand.Next();
            foreach (Issue x in FakeIssueRepository._Issues)
            {
                if (x.Id == (int) i)
                {
                    i = rand.Next();
                }
            }
            issue.DiscoveryDate = dateTimePicker1.Value;
            issue.Discoverer = discovererbox.SelectedItem.ToString();
            issue.Component = textBox3.Text.Trim();
            issue.IssueStatusId = statusbox.SelectedItem.ToString();
        }
    }
}
FakeProjectRepository projectRepository = new FakeProjectRepository();
Project project = new Project();
project.Name = textBoxProjectName.Text.Trim();
int assignedProjectId;
string result = projectRepository.Add(project, out assignedProjectId);
if (result == FakeProjectRepository.NO_ERROR)
{
    MessageBox.Show("Project added successfully.");
}
else
{
    MessageBox.Show("Project not created. " + result, "Attention.");
}
this.Close();