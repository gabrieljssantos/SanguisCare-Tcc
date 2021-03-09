using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.DAL
{
    public class Conexao
    {

        SqlConnection con = new SqlConnection(); // Cria 'con' utilizando o objeto da classe SQLConnection

        public Conexao()
        {
            con.ConnectionString = @"Data Source=DESKTOP-JJ8NI5U\SQLEXPRESS;Initial Catalog=ProjetoLogin;Integrated Security=True"; //Servidor SQL
            // isntancia o servidor que estamos utilizando, SQL Server Management, nos fornece o codigo para utilizarmos na conexão
        }

        public SqlConnection conectar()
        { 
            if(con.State == System.Data.ConnectionState.Closed)
            {
                con.Open(); //Abre a conexao
            }
            return con;
        }
        public void desconectar() 
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();    //Fecha a conexão
            }
        }

    }
}
