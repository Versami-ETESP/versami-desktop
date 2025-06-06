using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace versami_desktop.Entities
{
    class Admin
    {
        private static string nome, arroba;
        private static int idAdm, permissao;
        private string email, senha, resposta;
        private int idPergunta;
        private DateTime nasc;

        public Admin()
        {

        }

        public Admin(string usrNome, string usrArroba, int usrPermissao, string email, string senha, DateTime nasc)
        {
            setNome(usrNome);
            setArroba(usrArroba);
            setPermissao(usrPermissao);
            setEmail(email);
            setSenha(senha);
            setNasc(nasc);
        }

        public string getResposta()
        {
            return resposta;
        }

        public void setResposta(string resp)
        {
            resposta = resp;
        }

        public int getIdPergunta()
        {
            return idPergunta;
        }

        public void setIdPergunta(int id)
        {
            idPergunta = id;
        }

        public string getNome()
        {
            return nome;
        }

        public void setNome(string usrNome)
        {
            nome = usrNome;
        }

        public string getArroba()
        {
            return arroba;
        }

        public void setArroba(string arrobaUsr)
        {
            arroba = arrobaUsr;
        }

        public string getEmail()
        {
            return email;
        }

        public void setEmail(string usrEmail)
        {
            email = usrEmail;
        }

        public string getSenha()
        {
            return senha;
        }

        public void setSenha(string usrSenha)
        {
            senha = usrSenha;
        }
        
        public int getID()
        {
            return idAdm;
        }

        public void setId(int usrId)
        {
            idAdm = usrId;
        }

        public int getPermissao()
        {
            return permissao;
        }

        public void setPermissao(int usrPermissao)
        {
            permissao = usrPermissao;
        }

        public DateTime getNasc()
        {
            return this.nasc;
        }

        public void setNasc(DateTime nasc)
        {
            this.nasc = nasc;
        }
    }
}
