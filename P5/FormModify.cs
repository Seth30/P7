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
    public partial class FormModify : Form
    {
        FakeIssueRepository newissue = new FakeIssueRepository();
        string selected;
        int selectedid;
        int selectedId;
        public FormModify(string name)
        {
            InitializeComponent();
            this.CenterToParent();
            selected = name;
        }
        private void FormModify_Load(object sender, EventArgs e)
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
        private void cancelbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void selectbutton_Click(object sender, EventArgs e)
        {
            FormModifyIssue form = new FormModifyIssue(selectedId);
            form.ShowDialog();
            this.Close();
        }
    }
}
