using System;
using System.Windows.Forms;

namespace P5
{
    public partial class FormRecord : Form
    {
        FakeIssueStatusRepository issueRepository = new FakeIssueStatusRepository();
        FakeIssueRepository newissue = new FakeIssueRepository();
        int i;
        string _SelectedProject;
        public FormRecord(string name)
        {
            InitializeComponent();
            _SelectedProject = name;
        }
        private void Record_Load(object sender, EventArgs e)
        {
            this.CenterToParent();
            foreach (Issue x in FakeIssueRepository._Issues)
            {
                    i++;
            }
            IDbox.Text = i.ToString();
            discovererbox.DataSource = new BindingSource(FakeAppUserRepository._AppUsers, null);
            discovererbox.DisplayMember = "Key";
            statusbox.DataSource = FakeIssueStatusRepository._IssueStatuses;
            statusbox.DisplayMember = "Value";
        }
        private void cancelbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void createbutton_Click(object sender, EventArgs e)
        {
            Issue issue = new Issue();
            issue.Title = Titlebox.Text.Trim();
            issue.Id = i;
            issue.DiscoveryDate = dateTimePicker1.Value;
            issue.Discoverer = discovererbox.SelectedItem.ToString();
            issue.Component = textBox3.Text.Trim();
            string statusval = statusbox.SelectedItem.ToString();
            issue.IssueStatusId = issueRepository.GetIdByStatus(statusval);
            issue.InitialDescription = descriptbox.Text;
            foreach (Project p in FakeProjectRepository._Projects)
            {
                if (_SelectedProject == p.Name)
                {
                    issue.ProjectId = p.Id;
                }
            }
            string result = newissue.Add(issue);
            if (result == FakeIssueRepository.NO_ERROR)
            {
                MessageBox.Show("Issue Recorded Successfully.");
            }
            else
            {
                MessageBox.Show("Issue not recorded. " + result, "Attention.");
            }
            this.Close();
        }
    }
}