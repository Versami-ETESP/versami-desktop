using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using versami_desktop.Entities;
using versami_desktop.Util;

namespace versami_desktop.Controllers
{
    class DenunciaController
    {
        private Conexao con;
        private DataTable dt;

        public DataTable listarDenunciasPendentes()
        {
            String sql = "SELECT d.idDenuncia, d.data_denuncia, s.descStatus " +
                "FROM tblDenuncia d " +
                "JOIN tblStatusDenuncia s ON s.idStatusDenuncia = d.statusDenun " +
                "WHERE s.descStatus = @status";

            SqlCommand cmd = new SqlCommand(sql);
            cmd.Parameters.AddWithValue("@status", "PENDENTE");

            try
            {
                this.con = new Conexao();
                this.dt = this.con.queryComParametros(cmd);
            }
            catch(Exception ex)
            {
                Debug.WriteLine("Erro ao consultar denuncias: " + ex.Message);
            }
            return this.dt;
        }

        public Denuncia obterDenuncia(string id)
        {
            string sql = "SELECT d.idDenuncia, d.statusDenun, p.idPublicacao, p.idUsuario AS denunciado, u.idUsuario AS denunciante, u.arroba_usuario " +
                "FROM tblDenuncia d " +
                "JOIN tblUsuario u ON d.idUsuario = u.idUsuario " +
                "JOIN tblPublicacao p ON d.idPublicacao = p.idPublicacao " +
                "WHERE d.idDenuncia = @id";
            Denuncia denuncia = new Denuncia();
            Post post = new Post();
            Usuario usuarioDenunciado = new Usuario();
            Usuario usuarioDenunciante = new Usuario();

            try
            {
                this.con = new Conexao();
                SqlCommand cmd = new SqlCommand(sql);
                cmd.Parameters.AddWithValue("@id", id);
                DataTable dt = this.con.queryComParametros(cmd);
                usuarioDenunciado.setUserID(Convert.ToInt32(dt.Rows[0]["denunciado"]));
                post.setUsuario(usuarioDenunciado);
                post.setIdPublicacao(Convert.ToInt32(dt.Rows[0]["idPublicacao"]));
                usuarioDenunciante.setUserID(Convert.ToInt32(dt.Rows[0]["denunciante"]));
                usuarioDenunciante.setUserLogin(dt.Rows[0]["arroba_usuario"].ToString());
                denuncia.setUsuario(usuarioDenunciante);
                denuncia.setPost(post);
                denuncia.setIdDenuncia(Convert.ToInt32(dt.Rows[0]["idDenuncia"]));
                denuncia.setStatusDenuncia(Convert.ToInt32(dt.Rows[0]["statusDenun"]));
            }
            catch(Exception e)
            {
                Debug.WriteLine("Erro ao consultar denuncia: " + e.Message);
            }

            return denuncia;

        }

        public DataTable listarStatusDenuncia()
        {
            string sql = "SELECT * FROM tblStatusDenuncia";

            try
            {
                this.con = new Conexao();
                this.dt = this.con.executarSQL(sql);
            }catch(Exception e)
            {
                Debug.WriteLine("Erro ao listar status de denuncia: " + e.Message);
            }

            return this.dt;
        }

        public DataTable listarPosts()
        {
            string sql = @"
                SELECT 
                    p.idPublicacao, 
                    p.conteudo, 
                    p.dataPublic, 
                    u.nome,
                    (SELECT COUNT(*) FROM tblLikesPorPost WHERE idPublicacao = p.idPublicacao) AS qtdCurtidas,
                    (SELECT COUNT(*) FROM tblComentario WHERE idPublicacao = p.idPublicacao) AS qtdComentarios
                FROM tblPublicacao AS p
                JOIN tblUsuario AS u ON p.idUsuario = u.idUsuario
                ORDER BY p.dataPublic DESC";

            try
            {
                con = new Conexao();
                dt = con.executarSQL(sql);
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Erro ao listar posts: " + ex.Message);
            }

            return dt;
        }
        public void excluirPost(int idPublicacao)
        {
            string sql = "DELETE FROM tblPublicacao WHERE idPublicacao = @id";

            try
            {
                con = new Conexao();
                using (SqlCommand cmd = new SqlCommand(sql, con.conectar()))
                {
                    cmd.Parameters.AddWithValue("@id", idPublicacao);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Erro ao excluir post: " + ex.Message);
            }
        }
    }
}