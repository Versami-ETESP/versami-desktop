using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace versami_desktop.Entities
{
    class BlogPost
    {
        private int idPost;
        private string titulo;
        private string conteudo;
        private DateTime dataPost;
        private int idAdmin;
        private byte[] imagem;

        public BlogPost() { }

        public BlogPost(string titulo, string conteudo, byte[] imagem)
        {
            this.titulo = titulo;
            this.conteudo = conteudo;
            this.imagem = imagem;
        }

        // Getters e Setters
        public int getIdPost()
        {
            return idPost;
        }

        public void setIdPost(int id)
        {
            idPost = id;
        }

        public string getTitulo()
        {
            return titulo;
        }

        public void setTitulo(string titulo)
        {
            this.titulo = titulo;
        }

        public string getConteudo()
        {
            return conteudo;
        }

        public void setConteudo(string conteudo)
        {
            this.conteudo = conteudo;
        }

        public DateTime getDataPost()
        {
            return dataPost;
        }

        public void setDataPost(DateTime data)
        {
            dataPost = data;
        }

        public int getIdAdmin()
        {
            return idAdmin;
        }

        public void setIdAdmin(int idAdmin)
        {
            this.idAdmin = idAdmin;
        }

        public byte[] getImagem()
        {
            return imagem;
        }

        public void setImagem(byte[] imagem)
        {
            this.imagem = imagem;
        }
    }
}
