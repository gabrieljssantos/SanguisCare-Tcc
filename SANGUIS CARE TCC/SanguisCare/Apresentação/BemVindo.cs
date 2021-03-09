using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login.Apresentação
{
    public partial class BemVindo : Form
    {
        public BemVindo()
        {
            InitializeComponent();
        }

        private void lblBemVindo_Click(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAdicionarSangue_Click(object sender, EventArgs e)
        {

            this.Hide();
            AdicionarSangue addSangueTela = new AdicionarSangue();
            addSangueTela.Show();
        }

        private void lblEscolhaOpcao_Click(object sender, EventArgs e)
        {

        }

        private void btnConsultarSangue_Click(object sender, EventArgs e)
        {

        }

        private void btnRemoverSangue_Click(object sender, EventArgs e)
        {

        }

        private void BemVindo_Load(object sender, EventArgs e)
        {

        }
    }
}
