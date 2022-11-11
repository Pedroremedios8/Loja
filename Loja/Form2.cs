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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            DialogResult resposta = new DialogResult();
            resposta = MessageBox.Show("Deseja guardar o ficheiro?", "Aviso",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resposta == DialogResult.Yes)
            {
                //Guardar ficheiro
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show(" Deseja mesmo sair da aplicação? ", "Mensage do sistema ",

            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) ;

            {

                Application.Exit();

            }
        }
    }
}
