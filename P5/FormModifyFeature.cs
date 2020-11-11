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
    public partial class FormModifyFeature : Form
    {
        FakeFeatureRepository newfeat = new FakeFeatureRepository();
        string newname;
        int id;
        int selected;
        public FormModifyFeature(string name)
        {
            InitializeComponent();
            this.CenterToParent();
            newname = name;
        }
        private void ModifyFeature_Load(object sender, EventArgs e)
        {
            foreach (Project p in FakeProjectRepository._Projects)
            {
                if (newname == p.Name)
                    id = p.Id;
            }
            List<Feature> featlist = new List<Feature>();
            featlist = newfeat.GetAll(id);
            grid.DataSource = featlist;
            Feature select = (Feature)grid.CurrentRow.DataBoundItem;
            selected = select.Id;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormModifyFeaturept2 form = new FormModifyFeaturept2(selected, id);
            form.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
