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
    public partial class FormRemoveRequirement : Form
    {
        Requirement newone = new Requirement();
        FakeRequirementRepository repo = new FakeRequirementRepository();
        List<Requirement> biglist = new List<Requirement>();
        string pname;
        int id;
        public FormRemoveRequirement(string projectname)
        {
            InitializeComponent();
            pname = projectname;
            this.CenterToParent();
            foreach (Project x in FakeProjectRepository._Projects)
            {
                if (pname == x.Name)
                    id = x.Id;
            }
            comboBox1.Items.Insert(0, "--Select--");
            int i = 1;
            foreach (Feature x in FakeFeatureRepository.features)
            {
                if (x.ProjectId == id)
                {
                    comboBox1.Items.Insert(i, x.Title);
                    i++;
                }
            }
            comboBox1.SelectedIndex = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Requirement needed = (Requirement)dataGridView1.CurrentRow.DataBoundItem;
            string result = repo.Remove(needed);
            if (result == "")
            {
                MessageBox.Show("Requirement Removed Successfully");
                this.Close();
            }
            else
            {
                MessageBox.Show(result, "Attention");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
                dataGridView1.DataSource = null;
            else
            {
                List<Requirement> newlist = new List<Requirement>();
                newlist = repo.GetAll(id);
                List<Requirement> nextlist = new List<Requirement>();
                foreach (Requirement x in newlist)
                {
                    if (x.FeatureId == comboBox1.SelectedIndex)
                        nextlist.Add(x);
                }
                dataGridView1.DataSource = nextlist;
                biglist = nextlist;
            }
        }
    }
}
