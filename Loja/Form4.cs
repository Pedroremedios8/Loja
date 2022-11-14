using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loja
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
            Form2 form = new Form2();
            form.MdiParent = this.ParentForm;
            form.Show();
            */
            if (textBox1.Text==null && textBox2.Text == null)
            {
                textBox1.Focus();
                return;
            }
            if (textBox1.Text == null )
            {
                MessageBox.Show("Digite o login!", "Aviso", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                textBox1.Focus();
                return;
            }
            if (textBox2.Text == null)
            {
                MessageBox.Show("Digite a senha!", "Aviso", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                textBox2.Focus();
                return;
            }
            if(textBox1.Text.Equals("50516") && textBox2.Text.Equals("12345"))
            {
                MessageBox.Show("Autenticado com sucesso!", "Aviso", MessageBoxButtons.OK,
                                   MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Senha e lodin incorretos!", "Aviso", MessageBoxButtons.OK,
                   MessageBoxIcon.Warning);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Limpar os campos
            textBox1.ResetText();
            textBox2.Clear();
        }
    }
}
