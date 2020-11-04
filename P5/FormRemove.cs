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
    public partial class FormRemove : Form
    {
        FakeIssueRepository newissue = new FakeIssueRepository();
        Issue killme = new Issue();
        string selected;
        int selectedid;
        int selectedId;
        public FormRemove(string name)
        {
            InitializeComponent();
            this.CenterToParent();
            selected = name;
        }
        private void FormRemove_Load(object sender, EventArgs e)
        {
            foreach (Project p in FakeProjectRepository._Projects)
            {
                if (selected == p.Name)
                {
                    selectedid = p.Id;
                }
            }
            List<Issue> issues = new List<Issue>();
            issues = newissue.GetAll(selectedid);
            grid.DataSource = issues;
            Issue selectId = (Issue)grid.CurrentRow.DataBoundItem;
            selectedId = selectId.ProjectId;
        }

        private void removebutton_Click_1(object sender, EventArgs e)
        {
            DialogResult isSure = MessageBox.Show("Are you sure you want to remove this issue? ", "Attention", MessageBoxButtons.YesNo);
            if (isSure == DialogResult.Yes)
            {
                killme = newissue.GetIssueById(selectedId);
                bool result = newissue.Remove(killme);
            }
            this.Close();
        }

        private void cancelbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
