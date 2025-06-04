using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace versami_desktop.Entities
{
    class Denuncia
    {
        public const int STATUS_PENDENTE = 1;
        public const int STATUS_DEFERIDO = 2;
        public const int STATUS_INDEFERIDO = 3;

        private int idDenuncia;
        private int statusDenuncia;
        private string observacao;
        private DateTime dataDenuncia;
        private Post publicacao;
        private Admin admin;
        private Usuario user;

        public Denuncia()
        {

        }

        public int getIdDenuncia()
        {
            return this.idDenuncia;
        }

        public void setIdDenuncia(int id)
        {
            this.idDenuncia = id;
        }

        public int getStatusDenuncia()
        {
            return this.statusDenuncia;
        }

        public void setStatusDenuncia(int status)
        {
            this.statusDenuncia = status;
        }

        public string getObservacao()
        {
            return this.observacao;
        }

        public void setObservacao(string obs)
        {
            this.observacao = obs;
        }

        public DateTime getDataDenuncia()
        {
            return this.dataDenuncia;
        }

        public void setDataDenuncia(DateTime data)
        {
            this.dataDenuncia = data;
        }

        public Post GetPost()
        {
            return this.publicacao;
        }

        public void setPost(Post post)
        {
            this.publicacao = post;
        }

        public Admin GetAdmin()
        {
            return this.admin;
        }

        public void setAdmin(Admin adm)
        {
            this.admin = adm;
        }

        public Usuario getUser()
        {
            return this.user;
        }

        public void setUsuario(Usuario usuario)
        {
            this.user = usuario;
        }
    }
}
