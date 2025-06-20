﻿using System;
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

        public bool insertPost(BlogPost post)
        {

            Debug.WriteLine("Iniciando insertPost...");

            bool result = false;

            string sql = "INSERT INTO tblBlogPost (titulo, conteudo, dataPost, idAdmin, imgPost) " +
                         "VALUES (@titulo, @conteudo, @dataPost, @idAdmin, @imagem)";

            try
            {
                con = new Conexao(); 
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

        public bool updatePost(BlogPost post, int op)
        {
            if (op < 1 || op > 2)
            {
                Debug.WriteLine("Valor in´válido para as opcoes de update: " + op);
                return false;
            }

            string sql = "";
            var resp = false;
            switch (op)
            {
                case 1:
                    sql = "UPDATE tblBlogPost SET titulo = @titulo, conteudo = @conteudo, dataPost = @data WHERE idBlogPost = @id";
                    break;
                case 2:
                    sql = "UPDATE tblBlogPost SET titulo = @titulo, conteudo = @conteudo, dataPost = @data, imgPost = @img WHERE idBlogPost = @id";
                    break;
            }
                
            try
            {
                SqlCommand cmd = new SqlCommand(sql);
                cmd.Parameters.AddWithValue("@titulo", post.getTitulo());
                cmd.Parameters.AddWithValue("@conteudo", post.getConteudo());
                cmd.Parameters.AddWithValue("@data", post.getDataPost());
                cmd.Parameters.AddWithValue("@id", post.getIdPost());

                if (op == 2)
                    cmd.Parameters.AddWithValue("@img", post.getImagem());

                con = new Conexao();
                resp = con.updateComParametros(cmd) > 0;
            }
            catch (Exception e)
            {
                Debug.WriteLine("Erro no Update - Atualizar Post: " + e.Message);
            }

            return resp;
        }

        public DataTable BuscarPorTitulo(string titulo)
        {
            DataTable dt = new DataTable();
            string sql = "SELECT idBlogPost, titulo  FROM tblBlogPost WHERE titulo LIKE @titulo";

            try
            {
                con = new Conexao();
                SqlCommand cmd = new SqlCommand(sql);
                cmd.Parameters.AddWithValue("@titulo", "%" + titulo.Trim() + "%");
                dt = con.queryComParametros(cmd);
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
