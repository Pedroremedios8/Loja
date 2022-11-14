using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Loja
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
         




            }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        Form4 form = new Form4();
        form.MdiParent = this;
         form.Show();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3();
            form.MdiParent = this;
            form.Show();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.MdiParent = this.ParentForm;
            form.Show();
        }
    }
}
