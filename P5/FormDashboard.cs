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
    public partial class FormDashboard : Form
    {
        FakeIssueRepository newissue = new FakeIssueRepository();
        int id;
        public FormDashboard(string pname)
        {
            InitializeComponent();
            int y=0;
            foreach (Project p in FakeProjectRepository._Projects)
            {
                if (pname == p.Name)
                {
                    id = p.Id;
                }
            }
            DateTime today = DateTime.Today;
            int year = today.Year;
            List<string> Months = newissue.GetIssuesByMonth(id);
            foreach (string x in Months)
            {
                y = 0;
                foreach (Issue t in FakeIssueRepository._Issues)
                {
                    if (t.DiscoveryDate.Month.ToString() == x)
                    {
                        y++;
                    }
                }
                listBox1.Items.Add(year + " - " + x + ": " + y);
            }

            List<string> Discovered = newissue.GetIssuesbyDiscoverer(id);
            foreach (string x in Discovered)
            {
                y = 0;
                foreach (Issue t in FakeIssueRepository._Issues)
                {
                    if (t.Discoverer == x)
                    {
                        y++;
                    }
                }
                foreach (AppUser user in FakeAppUserRepository._AppUsers.Values)
                {
                    if (user.UserName == x)
                    {
                        listBox2.Items.Add(user.LastName + ", " + user.FirstName + ": " + y);
                    }
                }
            }

            label4.Text = newissue.GetTotalNumberOfIssues(id).ToString();
        }
        private void Dashboard_Load(object sender, EventArgs e)
        {
            this.CenterToParent();
            label4.Text = "5";
        }

        private void cancelbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
