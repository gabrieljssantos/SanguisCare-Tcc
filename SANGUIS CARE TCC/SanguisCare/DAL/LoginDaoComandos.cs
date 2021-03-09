using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;



namespace Login.DAL
{

    class LoginDaoComandos
    {
        public bool tem = false;
        public String mensagem = ""; // Tudo certo
        SqlCommand cmd = new SqlCommand();
        Conexao con = new Conexao();
        SqlDataReader dr;
        public bool verificarLogin(String login, String Senha)
        {
            //Comandos sql para verificar se possue no banco
            cmd.CommandText = "select * from logins where email = @login and senha = @senha";
            cmd.Parameters.AddWithValue("@login", login);
            cmd.Parameters.AddWithValue("@senha", Senha);

            try
            {
                cmd.Connection = con.conectar();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)  // Se foi Encontrado
                {
                    tem = true;
                }
                con.desconectar();
                dr.Close();

            }
            catch (SqlException)
            {
                this.mensagem = "Erro com o Banco de Dados!";
            }


            return tem;
        }

        public String cadastrar(String email, String Senha, String confSenha)
        {
            tem = false;
            //Comandos parar inserir
            if (Senha.Equals(confSenha))
            {
                cmd.CommandText = "insert into logins values (@e,@s);"; //Inseri os valores
                cmd.Parameters.AddWithValue("@e", email);
                cmd.Parameters.AddWithValue("@s", Senha);

                try //Tenta realizar o cadastro
                {
                    cmd.Connection = con.conectar();    //Sucesso
                    cmd.ExecuteNonQuery();
                    con.desconectar();
                    this.mensagem = "Cadastrado com Sucesso!";
                    tem = true;
                }
                catch (SqlException)    //erro
                {
                    this.mensagem = "Erro com o Banco de Dados";
                }
            }
            else
            {
                this.mensagem = "Senhas Não Correspondem!";
            }

            return mensagem;
        }
    }
}
