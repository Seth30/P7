using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P5
{
    public partial class FormModifyIssue : Form
    {
        FakeIssueStatusRepository issueRepository = new FakeIssueStatusRepository();
        FakeIssueRepository newissue = new FakeIssueRepository();
        Issue modifyme = new Issue();
        int i;
        string _SelectedProject;
        public FormModifyIssue(int issid)
        {
            InitializeComponent();
            modifyme = newissue.GetIssueById(issid);
            
        }
        private void ModifyIssue_Load(object sender, EventArgs e)
        {
            this.CenterToParent();
            IDbox.Text = modifyme.Id.ToString();
            discovererbox.DataSource = new BindingSource(FakeAppUserRepository._AppUsers, null);
            discovererbox.DisplayMember = "Key";
            statusbox.DataSource = FakeIssueStatusRepository._IssueStatuses;
            statusbox.DisplayMember = "Value";
        }
        private void modifybutton_Click_1(object sender, EventArgs e)
        {
                Issue issue = new Issue();
                issue.Title = Titlebox.Text.Trim();
                issue.Id = i;
                issue.DiscoveryDate = dateTimePicker1.Value;
                issue.Discoverer = discovererbox.GetItemText(discovererbox.SelectedItem);
                issue.Component = textBox3.Text.Trim();
                string statusval = statusbox.GetItemText(statusbox.SelectedItem);
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

        private void cancelbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }
}