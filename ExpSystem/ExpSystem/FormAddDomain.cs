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
    public partial class FormAddDomain : Form
    {
        FormDomains fff;

        public FormAddDomain(FormDomains fff)
        {
            this.fff = fff;
            InitializeComponent();
            textBox1.Focus();
        }

        public FormAddDomain(FormDomains fff, string oldDom)
        {
            InitializeComponent();
            this.fff = fff;
            textBox1.Text = oldDom;
            textBox1.Focus();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            fff.newDom = textBox1.Text;
        }

        private void frmAddDom_Load(object sender, EventArgs e)
        {
            textBox1.Select();
        }
    }
}
