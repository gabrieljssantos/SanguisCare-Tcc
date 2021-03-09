using Login.Apresentação;
using Login.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Cadastro cad = new Cadastro();
            cad.Show();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            controle.acessar(txbLogin.Text, txbSenha.Text);
            if (controle.mensagem.Equals(""))
            {
                if (controle.tem)
                {
                    MessageBox.Show("Logado Com Sucesso", "Entrando", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Hide();
                    BemVindo bv = new BemVindo();
                    bv.Show(); 
                }
                else
                {
                    MessageBox.Show("Login Não Encontrado, verifique Login e Senha", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(controle.mensagem);

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblSanguisCare_Click(object sender, EventArgs e)
        {

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {

        }

        private void txbLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lblLogin_Click(object sender, EventArgs e)
        {

        }

        private void txbLogin_Enter(object sender, EventArgs e)
        {
          
        }

        private void txbLogin_Leave(object sender, EventArgs e)
        {

        }

        private void txbSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ConsultarSangueCliente consultaSangue = new ConsultarSangueCliente();
            consultaSangue.Show();
        }
    }
}
