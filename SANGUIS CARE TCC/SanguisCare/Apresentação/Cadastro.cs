using Login.Modelo;
using System;
using System.Windows.Forms;

namespace Login.Apresentação
{
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }


        private void btnCadastrar_Click(object sender, EventArgs e)
        {

            Controle controle = new Controle();

            String mensagem = controle.cadastrar(txbLogin.Text, txbSenha.Text, txbSenhaConfirmar.Text);

            if (controle.tem) //Mensagem de Sucesso
            {
                MessageBox.Show(mensagem, "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(controle.mensagem); //Mensagem de ERRO
            }
            this.Hide();
            Form1 telaInicial = new Form1();
            telaInicial.Show();

        }

        private void txbLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblConfirmarSenha_Click(object sender, EventArgs e)
        {

        }

        private void lblLogin_Click(object sender, EventArgs e)
        {

        }

        private void txbSenhaConfirmar_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblSenha_Click(object sender, EventArgs e)
        {

        }

        private void Cadastro_Load(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
