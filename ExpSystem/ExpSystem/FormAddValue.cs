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
    public partial class FormAddValue : Form
    {
        FormDomains fff;

        public FormAddValue(FormDomains fff)
        {
            InitializeComponent();
            this.fff = fff;
            textBox1.Focus();
        }

        public FormAddValue(FormDomains fff, string oldVal)
        {
            InitializeComponent();
            this.fff = fff;
            textBox1.Text = oldVal;
        }

        private void frmAddVal_Load(object sender, EventArgs e)
        {
            textBox1.Select();
        }

        private void btnOk_Click_1(object sender, EventArgs e)
        {
            fff.newVal = textBox1.Text;
        }
    }
}
