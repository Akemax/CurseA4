using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpSystem
{
    public partial class FormGoal : Form
    {
        ExpertSystem es;
        FormMain mother;

        public FormGoal(ExpertSystem es, FormMain mother)
        {
            InitializeComponent();
            foreach (string s in es.Vars.Keys)
                if (es.Vars[s].MyType != VarType.Queried)
                    comboBox1.Items.Add(s);
            this.es = es;
            this.mother = mother;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
                es.Goal = null;
            else
                es.Goal = es.Vars[comboBox1.SelectedItem.ToString()];
        }

        private void frmGoal_Load(object sender, EventArgs e)
        {
            comboBox1.Select();
        }
    }
}
