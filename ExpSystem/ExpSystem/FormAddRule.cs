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
    public partial class FormAddRule : Form
    {
        private FormRules f;

        public FormAddRule(FormRules f)
        {
            InitializeComponent();
            this.f = f;
        }


        public FormAddRule(FormRules f, string rName, string reasoning)
            : this(f)
        {
            textBox1.Text = rName;
          //textBox2.Text = reasoning;
        }


        private void btnOk_Click(object sender, EventArgs e)
        {

        }

        private void frmAddRule_Load(object sender, EventArgs e)
        {
            textBox1.Select();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            f.newRule = textBox1.Text;
        }
    }
}
