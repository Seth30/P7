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
         public partial class FormModifyRequirementpt2 : Form
         {
            Requirement newone = new Requirement();
            FakeRequirementRepository repo = new FakeRequirementRepository();
            int reid;
            int proid;
            public FormModifyRequirementpt2(int pid, int id)
            {
                InitializeComponent();
                proid = pid;
                reid = id;
                this.CenterToParent();
                comboBox1.Items.Insert(0, "--Select--");
                int i = 1;
                foreach (Feature x in FakeFeatureRepository.features)
                {
                    if (x.ProjectId == pid)
                    {
                        comboBox1.Items.Insert(i, x.Title);
                        i++;
                    }
                }
                comboBox1.SelectedIndex = 0;
            }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "")
            {
                MessageBox.Show("Statement cannot be blank", "Attention");
            }
            else
            {
                newone.Statement = textBox1.Text;
                newone.ProjectId = proid;
                newone.FeatureId = comboBox1.SelectedIndex;
                newone.Id = reid;
                string result = repo.Modify(newone);
                if (result == "")
                    this.Close();
                else
                {
                    MessageBox.Show(newone.Statement, result);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != 0)
            {
                textBox1.Enabled = true;
                button1.Enabled = true;
            }
            else
            {
                textBox1.Enabled = false;
                button1.Enabled = false;
            }
        }
    }
}
