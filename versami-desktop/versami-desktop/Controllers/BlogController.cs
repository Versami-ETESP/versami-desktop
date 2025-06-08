using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using versami_desktop.Util;
using versami_desktop.Entities;

namespace versami_desktop.Controllers
{
    class BlogController
    {

        private Conexao con;
        private DataTable dt;

        // Carregar todos os posts do blog
        public DataTable carregarGrid()
        {
            string sql = "SELECT idBlogPost, titulo, conteudo, dataPost FROM tblBlogPost";
            try
            {
                con = new Conexao();
                dt = con.executarSQL(sql);
            }
            catch (Exception e)
            {
                Debug.WriteLine("Erro na Consulta SQL - Carregar Posts: " + e.Message);
            }
            return dt;
        }

        // Obter dados de um post específico
        public DataTable obtemPostGrid(string id)
        {
            string sql = "SELECT idBlogPost AS idPost, titulo, conteudo, imgPost AS imagem FROM tblBlogPost";
            try
            {
                con = new Conexao();
                SqlCommand cmd = new SqlCommand(sql);
                cmd.Parameters.AddWithValue("@id", id);
                dt = con.queryComParametros(cmd);
            }
            catch (Exception e)
            {
                Debug.WriteLine("Erro na Consulta - Obter Post: " + e.Message);
            }
            return dt;
        }


        // Inserir um novo post


        public bool insertPost(BlogPost post)
        {

            Debug.WriteLine("Iniciando insertPost...");

            bool result = false;

            string sql = "INSERT INTO tblBlogPost (titulo, conteudo, dataPost, idAdmin, imgPost) " +
                         "VALUES (@titulo, @conteudo, @dataPost, @idAdmin, @imagem)";

            try
            {
                con = new Conexao(); // Usa a conexão do seu próprio objeto
                SqlCommand cmd = new SqlCommand(sql);
                cmd.Parameters.AddWithValue("@titulo", post.getTitulo());
                cmd.Parameters.AddWithValue("@conteudo", post.getConteudo());
                cmd.Parameters.AddWithValue("@dataPost", post.getDataPost());
                cmd.Parameters.AddWithValue("@idAdmin", post.getIdAdmin());
                cmd.Parameters.AddWithValue("@imagem", post.getImagem());

                int linhasAfetadas = con.updateComParametros(cmd);
                Debug.WriteLine("Linhas afetadas: " + linhasAfetadas);

                result = linhasAfetadas > 0;
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Erro no InsertPost: " + ex.Message);
                Debug.WriteLine("StackTrace: " + ex.StackTrace);
            }

            return result;
        }
        // Deletar um post
        public void deletePost(string id)
        {
            string sql = "DELETE FROM tblBlogPost WHERE idBlogPost = @id";

            try
            {
                con = new Conexao();
                SqlCommand cmd = new SqlCommand(sql);
                cmd.Parameters.AddWithValue("@id", id);
                con.updateComParametros(cmd);
            }
            catch (Exception e)
            {
                Debug.WriteLine("Erro no Delete - Deletar Post: " + e.Message);
            }
        }

        // Atualizar um post
        public void updatePost(Entities.BlogPost post)
        {
            string sql = "UPDATE tblBlogPost SET titulo = @titulo, conteudo = @conteudo, dataPost = @data WHERE idBlogPost = @id";

            try
            {
                SqlCommand cmd = new SqlCommand(sql);
                cmd.Parameters.AddWithValue("@titulo", post.getTitulo());
                cmd.Parameters.AddWithValue("@conteudo", post.getConteudo());
                cmd.Parameters.AddWithValue("@data", post.getDataPost());
                cmd.Parameters.AddWithValue("@id", post.getIdPost());

                con = new Conexao();
                con.updateComParametros(cmd);
            }
            catch (Exception e)
            {
                Debug.WriteLine("Erro no Update - Atualizar Post: " + e.Message);
            }
        }



        public DataTable BuscarPorTitulo(string titulo)
        {
            DataTable dt = new DataTable();
            string sql = "SELECT idBlogPost, titulo, conteudo  FROM tblBlogPost WHERE titulo LIKE @titulo";

            try
            {
                con = new Conexao();
                SqlConnection conexao = con.conectar();
                SqlCommand cmd = new SqlCommand(sql, conexao);
                cmd.Parameters.AddWithValue("@titulo", "%" + titulo.Trim() + "%");

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Erro SQL: " + ex.Message);
            }

            return dt;
        }

        public BlogPost BuscarPorId(int id)
        {
            BlogPost post = null;
            var sql = "SELECT idBlogPost, titulo, conteudo, imgPost FROM tblBlogPost WHERE idBlogPost = @id";

            try
            {
                con = new Conexao();
                var cmd = new SqlCommand(sql);
                cmd.Parameters.AddWithValue("@id", id);
                var dt = con.queryComParametros(cmd);

                if (dt.Rows.Count > 0)
                {
                    var row = dt.Rows[0];
                    int idPost = Convert.ToInt32(row["idBlogPost"]);  // Corrigido para idBlogPost
                    string titulo = row["titulo"].ToString();
                    string conteudo = row["conteudo"].ToString();
                    byte[] imagem = row["imgPost"] as byte[];       // Corrigido para imgPost

                    post = new BlogPost(titulo, conteudo, imagem);
                    post.setIdPost(idPost);
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine("Erro ao buscar post por ID: " + e.Message);
            }

            return post;
        }

    }
}
