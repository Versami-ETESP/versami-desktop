using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace versami_desktop.Entities
{
    class Post
    {
        private int idPublicacao;
        private string conteudo;
        private DateTime dataPublic;
        private Usuario user;

        public Post() { }

        public Post(int id, string conteudo, DateTime data, Usuario usuario)
        {
            this.idPublicacao = id;
            this.conteudo = conteudo;
            this.dataPublic = data;
            this.user = usuario;
        }

        public int getIdPublicacao() => idPublicacao;
        public void setIdPublicacao(int id) => idPublicacao = id;

        public string getConteudo() => conteudo;
        public void setConteudo(string texto) => conteudo = texto;

        public DateTime getDataPublic() => dataPublic;
        public void setDataPublic(DateTime data) => dataPublic = data;

        public Usuario GetUsuario() => user;
        public void setUsuario(Usuario usuario) => user = usuario;
        
    }
}

