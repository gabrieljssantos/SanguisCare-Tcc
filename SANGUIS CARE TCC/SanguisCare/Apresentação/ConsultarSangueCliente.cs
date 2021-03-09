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

namespace Login
{
    public partial class ConsultarSangueCliente : Form
    {
        SqlConnection conexao;
        SqlCommand comando;
        SqlDataAdapter da;
        SqlDataReader dr;
        string strSQL;

        public ConsultarSangueCliente()
        {
            InitializeComponent();
        }

        private void lblTipoSangueConsulta_Click(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 telaInicial = new Form1();
            telaInicial.Show();
        }

        private void btnConsultarSangue_Click(object sender, EventArgs e)
        {

            if (cboxTipoSangueConsulta.Text == "A")
            {
                if (cboxRhSangueConsulta.Text == "+")
                {
                    try
                    {
                        conexao = new SqlConnection(@"Data Source=DESKTOP-JJ8NI5U\SQLEXPRESS;Initial Catalog=ProjetoLogin;Integrated Security=True");

                        strSQL = "select sum(quantidadeDoSangue) as totalSangue from SanguesGeral WHERE SanguesGeral.tipoDoSangue = 'A' AND SanguesGeral.rhDoSangue = '+'"; //Consulta os dados que estao no servidor

                        comando = new SqlCommand(strSQL, conexao);

                        comando.Parameters.AddWithValue("@totalSangue", txbTotalSangueConsulta.Text);

                        conexao.Open();
                        dr = comando.ExecuteReader();


                        while (dr.Read())      
                        {
                            txbTotalSangueConsulta.Text = Convert.ToString(dr["totalSangue"]);
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao Consultar o Banco de Sangue!", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        conexao.Close();
                        conexao = null;
                        comando = null;
                    }

                }
                else if (cboxRhSangueConsulta.Text == "-")
                {
                    try
                    {
                        conexao = new SqlConnection(@"Data Source=DESKTOP-JJ8NI5U\SQLEXPRESS;Initial Catalog=ProjetoLogin;Integrated Security=True");

                        strSQL = "select sum(quantidadeDoSangue) as totalSangue from SanguesGeral WHERE SanguesGeral.tipoDoSangue = 'A' AND SanguesGeral.rhDoSangue = '-'"; //Consulta os dados que estao no servidor

                        comando = new SqlCommand(strSQL, conexao);

                        comando.Parameters.AddWithValue("@totalSangue", txbTotalSangueConsulta.Text);

                        conexao.Open();
                        dr = comando.ExecuteReader();


                        while (dr.Read())
                        {
                            txbTotalSangueConsulta.Text = Convert.ToString(dr["totalSangue"]);
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao Consultar o Banco de Sangue!", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        conexao.Close();
                        conexao = null;
                        comando = null;
                    }
                }
                else
                {

                }
            }

            if (cboxTipoSangueConsulta.Text == "B")
            {
                if (cboxRhSangueConsulta.Text == "+")
                {
                    try
                    {
                        conexao = new SqlConnection(@"Data Source=DESKTOP-JJ8NI5U\SQLEXPRESS;Initial Catalog=ProjetoLogin;Integrated Security=True");

                        strSQL = "select sum(quantidadeDoSangue) as totalSangue from SanguesGeral WHERE SanguesGeral.tipoDoSangue = 'B' AND SanguesGeral.rhDoSangue = '+'"; //Consulta os dados que estao no servidor

                        comando = new SqlCommand(strSQL, conexao);

                        comando.Parameters.AddWithValue("@totalSangue", txbTotalSangueConsulta.Text);

                        conexao.Open();
                        dr = comando.ExecuteReader();


                        while (dr.Read())
                        {
                            txbTotalSangueConsulta.Text = Convert.ToString(dr["totalSangue"]);
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao Consultar o Banco de Sangue!", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        conexao.Close();
                        conexao = null;
                        comando = null;
                    }
                }
                else if (cboxRhSangueConsulta.Text == "-")
                {
                    try
                    {
                        conexao = new SqlConnection(@"Data Source=DESKTOP-JJ8NI5U\SQLEXPRESS;Initial Catalog=ProjetoLogin;Integrated Security=True");

                        strSQL = "select sum(quantidadeDoSangue) as totalSangue from SanguesGeral WHERE SanguesGeral.tipoDoSangue = 'B' AND SanguesGeral.rhDoSangue = '-'"; //Consulta os dados que estao no servidor

                        comando = new SqlCommand(strSQL, conexao);

                        comando.Parameters.AddWithValue("@totalSangue", txbTotalSangueConsulta.Text);

                        conexao.Open();
                        dr = comando.ExecuteReader();


                        while (dr.Read())
                        {
                            txbTotalSangueConsulta.Text = Convert.ToString(dr["totalSangue"]);
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao Consultar o Banco de Sangue!", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        conexao.Close();
                        conexao = null;
                        comando = null;
                    }
                }
                else
                {

                }
            }

            if (cboxTipoSangueConsulta.Text == "AB")
            {
                if (cboxRhSangueConsulta.Text == "+")
                {
                    try
                    {
                        conexao = new SqlConnection(@"Data Source=DESKTOP-JJ8NI5U\SQLEXPRESS;Initial Catalog=ProjetoLogin;Integrated Security=True");

                        strSQL = "select sum(quantidadeDoSangue) as totalSangue from SanguesGeral WHERE SanguesGeral.tipoDoSangue = 'AB' AND SanguesGeral.rhDoSangue = '+'"; //Consulta os dados que estao no servidor

                        comando = new SqlCommand(strSQL, conexao);

                        comando.Parameters.AddWithValue("@totalSangue", txbTotalSangueConsulta.Text);

                        conexao.Open();
                        dr = comando.ExecuteReader();


                        while (dr.Read())
                        {
                            txbTotalSangueConsulta.Text = Convert.ToString(dr["totalSangue"]);
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao Consultar o Banco de Sangue!", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        conexao.Close();
                        conexao = null;
                        comando = null;
                    }
                }
                else if (cboxRhSangueConsulta.Text == "-")
                {
                    try
                    {
                        conexao = new SqlConnection(@"Data Source=DESKTOP-JJ8NI5U\SQLEXPRESS;Initial Catalog=ProjetoLogin;Integrated Security=True");

                        strSQL = "select sum(quantidadeDoSangue) as totalSangue from SanguesGeral WHERE SanguesGeral.tipoDoSangue = 'AB' AND SanguesGeral.rhDoSangue = '-'"; //Consulta os dados que estao no servidor

                        comando = new SqlCommand(strSQL, conexao);

                        comando.Parameters.AddWithValue("@totalSangue", txbTotalSangueConsulta.Text);

                        conexao.Open();
                        dr = comando.ExecuteReader();


                        while (dr.Read())
                        {
                            txbTotalSangueConsulta.Text = Convert.ToString(dr["totalSangue"]);
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao Consultar o Banco de Sangue!", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        conexao.Close();
                        conexao = null;
                        comando = null;
                    }
                }
                else
                {
                    MessageBox.Show("Erro ao Consultar o Banco de Sangue!", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (cboxTipoSangueConsulta.Text == "O")
            {
                if (cboxRhSangueConsulta.Text == "+")
                {
                    try
                    {
                        conexao = new SqlConnection(@"Data Source=DESKTOP-JJ8NI5U\SQLEXPRESS;Initial Catalog=ProjetoLogin;Integrated Security=True");

                        strSQL = "select sum(quantidadeDoSangue) as totalSangue from SanguesGeral WHERE SanguesGeral.tipoDoSangue = 'O' AND SanguesGeral.rhDoSangue = '+'"; //Consulta os dados que estao no servidor

                        comando = new SqlCommand(strSQL, conexao);

                        comando.Parameters.AddWithValue("@totalSangue", txbTotalSangueConsulta.Text);

                        conexao.Open();
                        dr = comando.ExecuteReader();


                        while (dr.Read())
                        {
                            txbTotalSangueConsulta.Text = Convert.ToString(dr["totalSangue"]);
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao Consultar o Banco de Sangue!", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        conexao.Close();
                        conexao = null;
                        comando = null;
                    }
                }
                else if (cboxRhSangueConsulta.Text == "-")
                {
                    try
                    {
                        conexao = new SqlConnection(@"Data Source=DESKTOP-JJ8NI5U\SQLEXPRESS;Initial Catalog=ProjetoLogin;Integrated Security=True");

                        strSQL = "select sum(quantidadeDoSangue) as totalSangue from SanguesGeral WHERE SanguesGeral.tipoDoSangue = 'O' AND SanguesGeral.rhDoSangue = '-'"; //Consulta os dados que estao no servidor

                        comando = new SqlCommand(strSQL, conexao);

                        comando.Parameters.AddWithValue("@totalSangue", txbTotalSangueConsulta.Text);

                        conexao.Open();
                        dr = comando.ExecuteReader();


                        while (dr.Read())
                        {
                            txbTotalSangueConsulta.Text = Convert.ToString(dr["totalSangue"]);
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao Consultar o Banco de Sangue!", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        conexao.Close();
                        conexao = null;
                        comando = null;
                    }
                }
                else
                {
                    MessageBox.Show("Erro ao Consultar o Banco de Sangue!", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }

