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
    public partial class FormRemoveFeature : Form
    {
        FakeRequirementRepository repo = new FakeRequirementRepository();
        FakeFeatureRepository feat = new FakeFeatureRepository();
        string pname;
        int id;
        public FormRemoveFeature(string projectname)
        {
            InitializeComponent();
            pname = projectname;
            this.CenterToParent();
            foreach (Project p in FakeProjectRepository._Projects)
            {
                if (p.Name == pname)
                {
                    id = p.Id;
                }
            }
            List<Feature> list = new List<Feature>();
            list = feat.GetAll(id);
            dataGridView1.DataSource = list;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Feature needed = (Feature)dataGridView1.CurrentRow.DataBoundItem;
            var mr = MessageBox.Show("Remove Feature?", "", MessageBoxButtons.YesNo);
            if (mr == DialogResult.Yes)
            {
                int count = repo.CountByFeatureId(needed.Id);
                if (count > 0)
                {
                    var dr = MessageBox.Show("This feature has multiple requirements attached to it. Removing the feature will remove all requirements attached. Do you wish to Continue?", "Attention", MessageBoxButtons.YesNo);
                    if (dr == DialogResult.Yes)
                    {
                        repo.RemoveByFeatureId(needed.Id);
                    }
                    else
                        this.Close();
                }
                string result = feat.Remove(needed);
                if (result == "")
                    this.Close();
                else
                    MessageBox.Show(result, "Attention");
            }   
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
