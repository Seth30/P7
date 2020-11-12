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
    public partial class FormModifyFeaturept2 : Form
    {
        int proid;
        int featid;
        public FormModifyFeaturept2(int id, int pid)
        {
            InitializeComponent();
            this.CenterToParent();
            proid = pid;
            featid = id;
        }
        private void ModifyFeature_Load(object sender, EventArgs e)
        { 
        
        }

        private void modifybutton_Click(object sender, EventArgs e)
        {
            Feature modified = new Feature();
            FakeFeatureRepository featureRepository = new FakeFeatureRepository();

            modified.Id = featid;
            modified.ProjectId = proid;
            modified.Title = textBox1.Text.Trim();
            string result = featureRepository.Modify(modified);
            if (result == FakeFeatureRepository.NO_ERROR)
                MessageBox.Show("Feature Modified Successfully");
            else
                MessageBox.Show(result);
            this.Close();
        }

        private void cancelbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
