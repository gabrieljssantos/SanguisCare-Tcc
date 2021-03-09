using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Data.Common;

namespace Login.Apresentação
{
    public partial class AdicionarSangue : Form
    {

        SqlConnection conexao;
        SqlCommand comando;
        SqlDataAdapter da;
        SqlDataReader dr;
        string strSQL;

        public AdicionarSangue()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AdicionarSangue_Load(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new SqlConnection(@"Data Source=DESKTOP-JJ8NI5U\SQLEXPRESS;Initial Catalog=ProjetoLogin;Integrated Security=True"); //Abre conexao

                strSQL = "INSERT INTO SanguesGeral (tipoDoSangue, quantidadeDoSangue, rhDoSangue) VALUES (@tipoDoSangue, @quantidadeDoSangue, @rhDoSangue)";
                //Envia os dados digitados pelo usario para o Servidor SQL (local)

                comando = new SqlCommand(strSQL, conexao);

                comando.Parameters.AddWithValue("@tipoDoSangue", cboxTipo.Text);
                comando.Parameters.AddWithValue("@quantidadeDoSangue", numericQuantidade.Text);
                comando.Parameters.AddWithValue("@rhDoSangue", cboxRH.Text);

                if (numericQuantidade.Text == "" || cboxTipo.Text == "" || cboxRH.Text == "")
                {
                    MessageBox.Show("Preencha Todos Campos!!", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    conexao.Open();
                    comando.ExecuteNonQuery();

                    MessageBox.Show("Sangue Adicionado com Sucesso!", "Sangue Adicionado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            }
            catch (Exception ex) //Em caso de erro
            {
                MessageBox.Show("Erro ao adicionar Sangue!", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(ex.Message);
            }
            finally // Executa no final
            {
                conexao.Close();
                conexao = null;
                comando = null;
            }

            this.Hide();
            AdicionarSangue addSangueTela = new AdicionarSangue();
            addSangueTela.Show();


        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnRemoverSangue_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new SqlConnection(@"Data Source=DESKTOP-JJ8NI5U\SQLEXPRESS;Initial Catalog=ProjetoLogin;Integrated Security=True");

                strSQL = "DELETE SanguesGeral WHERE IdSangue = @IdSangue"; //Remove os dados do Servidor

                comando = new SqlCommand(strSQL, conexao);

                comando.Parameters.AddWithValue("@idSangue", txbID.Text);

                if (numericQuantidade.Text == "" || cboxTipo.Text == "" || cboxRH.Text == "")
                {
                    MessageBox.Show("Preencha Todos Campos!!", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    conexao.Open();
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Sangue Removido com Sucesso!", "Sangue Removido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)    //Excesao em caso de erro
            {
                MessageBox.Show("Erro ao Remover Sangue!", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
                conexao = null;
                comando = null;
            }

            this.Hide();
            AdicionarSangue addSangueTela = new AdicionarSangue();
            addSangueTela.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnExibir_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new SqlConnection(@"Data Source=DESKTOP-JJ8NI5U\SQLEXPRESS;Initial Catalog=ProjetoLogin;Integrated Security=True");

                strSQL = "SELECT * FROM SanguesGeral"; //Exibi os Valores que estão no servidor

                DataSet ds = new DataSet();

                da = new SqlDataAdapter(strSQL,conexao);

                conexao.Open();

                da.Fill(ds);

                dataGridView1.DataSource = ds.Tables[0];

            }
            catch (Exception ex)    // Em caso de erro
            {
                MessageBox.Show("Erro ao Exibir Sangue!", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
                conexao = null;
                comando = null;
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new SqlConnection(@"Data Source=DESKTOP-JJ8NI5U\SQLEXPRESS;Initial Catalog=ProjetoLogin;Integrated Security=True");

                strSQL = "SELECT * FROM SanguesGeral WHERE idSangue = @idSangue"; //Consulta os dados que estao no servidor

                comando = new SqlCommand(strSQL, conexao);

                comando.Parameters.AddWithValue("@idSangue", txbID.Text);

                conexao.Open();
                dr = comando.ExecuteReader();   

                while (dr.Read())       //Consulta de acordo com o ID selecionado pelo usuario, retornando os restantes dos valores do ID
                {
                    cboxTipo.Text = (string)dr["tipoDoSangue"];
                    cboxRH.Text = (string)dr["rhDoSangue"];
                    numericQuantidade.Text = Convert.ToString(dr["quantidadeDoSangue"]);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao adicionar Sangue!", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
                conexao = null;
                comando = null;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new SqlConnection(@"Data Source=DESKTOP-JJ8NI5U\SQLEXPRESS;Initial Catalog=ProjetoLogin;Integrated Security=True");

                strSQL = "UPDATE SanguesGeral SET tipoDoSangue = @tipoDoSangue, rhDoSangue = @rhDoSangue, quantidadeDoSangue = @quantidadeDoSangue WHERE idSangue = @IdSangue ";
                   //Atualiza os dados de acordo com as edições feitas pelo usuario

                comando = new SqlCommand(strSQL, conexao);

                comando.Parameters.AddWithValue("@idSangue", txbID.Text);
                comando.Parameters.AddWithValue("@quantidadeDoSangue", numericQuantidade.Text);
                comando.Parameters.AddWithValue("@tipoDoSangue", cboxTipo.Text);
                comando.Parameters.AddWithValue("@rhDoSangue", cboxRH.Text);

                if (numericQuantidade.Text == "" || cboxTipo.Text == "" || cboxRH.Text == "" || txbID.Text == "")
                {
                    MessageBox.Show("Preencha Todos Campos!!", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    conexao.Open();
                    comando.ExecuteNonQuery();

                    MessageBox.Show("Sangue Editado com Sucesso!", "Sangue Removido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                this.Hide();
                AdicionarSangue addSangueTela = new AdicionarSangue();
                addSangueTela.Show();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Editar Sangue!", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
                conexao = null;
                comando = null;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
