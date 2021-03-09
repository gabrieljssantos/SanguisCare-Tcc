using Login.DAL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.Modelo
{
    public class Controle
    {
        public bool tem;
        public String mensagem = "";
        public bool acessar(String login, String senha)
        {
            LoginDaoComandos loginDao = new LoginDaoComandos();
            tem = loginDao.verificarLogin(login, senha);    //Verifica login
            if(!loginDao.mensagem.Equals("")) //ok
            {
                this.mensagem = loginDao.mensagem;  
            }
            return tem;
        }

        public String cadastrar(String email, String senha, String confSenha)
        {
            LoginDaoComandos loginDao = new LoginDaoComandos();
            this.mensagem = loginDao.cadastrar(email, senha, confSenha);

            if (loginDao.tem) //Mensagem de cadastro com Sucesso
            {
                this.tem = true;
            }

            return mensagem;
        }

    }
}

