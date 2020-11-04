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
                modifyme.Title = Titlebox.Text.Trim();
                modifyme.Id = modifyme.Id;
                modifyme.DiscoveryDate = dateTimePicker1.Value;
                modifyme.Discoverer = discovererbox.GetItemText(discovererbox.SelectedItem);
                modifyme.Component = textBox3.Text.Trim();
                string statusval = statusbox.GetItemText(statusbox.SelectedItem);
                modifyme.IssueStatusId = issueRepository.GetIdByStatus(statusval);
                modifyme.InitialDescription = descriptbox.Text;
                foreach (Project p in FakeProjectRepository._Projects)
                {
                    if (_SelectedProject == p.Name)
                    {
                        modifyme.ProjectId = p.Id;
                    }
                }
                string result = newissue.Modify(modifyme);
                if (result == FakeIssueRepository.NO_ERROR)
                {
                    MessageBox.Show("Issue Modified Successfully.");
                }
                else
                {
                    MessageBox.Show("Issue not Modified. " + result, "Attention.");
                }
                this.Close();
            }

        private void cancelbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}