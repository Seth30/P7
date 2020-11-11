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
    public partial class FormCreateFeature : Form
    {
        string newname;
        int id;
        public FormCreateFeature(string name)
        {
            InitializeComponent();
            this.CenterToParent();
            newname = name;
        }
        private void FormCreateFeature_Load(object sender, EventArgs e)
        {
            this.CenterToParent();
        }

        private void createbutton_Click(object sender, EventArgs e)
        {
            foreach (Project p in FakeProjectRepository._Projects)
            {
                if (newname == p.Name)
                {
                    id = p.Id;
                }
            }
            FakeFeatureRepository featureRepository = new FakeFeatureRepository();
            Feature feature = new Feature();
            feature.Title = textBox1.Text.Trim();
            feature.ProjectId = id;
            string result = featureRepository.Add(feature);
            if (result == FakeFeatureRepository.NO_ERROR)
            {
                MessageBox.Show("Project added successfully");
            }
            else
            {
                MessageBox.Show(result);
            }
            this.Close();
        }

        private void cancelbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
