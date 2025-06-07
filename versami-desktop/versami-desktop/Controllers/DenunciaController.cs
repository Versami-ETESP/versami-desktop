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

        public Post obterPublicacao(int idPublic)
        {
            Debug.WriteLine("Valor do id: " + idPublic);
            string sql = "SELECT p.idPublicacao, p.conteudo, p.dataPublic, u.fotoUsuario, u.nome, u.arroba_usuario, l.idLivro, l.nomeLivro, l.imgCapa " +
                "FROM tblPublicacao p " +
                "JOIN tblUsuario u ON p.idUsuario = u.idUsuario " +
                "LEFT JOIN tblLivro l ON p.idLivro = l.idLivro " +
                "WHERE p.idPublicacao = @id";
            Post post = new Post();
            try
            {
                this.con = new Conexao();
                SqlCommand cmd = new SqlCommand(sql);
                cmd.Parameters.AddWithValue("@id", idPublic);
                this.dt = this.con.queryComParametros(cmd);
                Usuario user = new Usuario();
                if (this.dt == null || this.dt.Rows.Count == 0) {
                    Debug.WriteLine("dt vazio");
                    return null;
                }

                    
                DataRow r = dt.Rows[0];

                user.setUserName(r["nome"].ToString());
                user.setUserLogin(r["arroba_usuario"].ToString());
                if (!r.IsNull("fotoUsuario")) user.setUserImage((byte[])r["fotoUsuario"]);

                post.setUsuario(user);
                post.setIdPublicacao(Convert.ToInt32(r["idPublicacao"]));
                post.setConteudo(r["conteudo"].ToString());
                post.setDataPublic(Convert.ToDateTime(r["dataPublic"]));

                if (!r.IsNull("idLivro"))
                {
                    Livro livro = new Livro();
                    livro.setTitle(r["nomeLivro"].ToString());
                    livro.setCover((byte[])r["imgCapa"]);
                    post.setLivro(livro);
                }
            }catch(Exception e)
            {
                Debug.WriteLine("Erro ao consultar publicação: " + e.ToString());
                throw;
            }
            return post;
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

        public void excluirPost(int idPublicacao)
        {
            string sql = "DELETE FROM tblPublicacao WHERE idPublicacao = @id";

            try
            {
                this.con = new Conexao();
                SqlCommand cmd = new SqlCommand(sql);
                cmd.Parameters.AddWithValue("@id", idPublicacao);
                this.con.updateComParametros(cmd);
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Erro ao excluir post: " + ex.Message);
            }
        }

        public bool tratarDenuncia(Denuncia denuncia)
        {
            bool resposta = false;
            string sql = "UPDATE tblDenuncia SET observacao_admin = @justificativa, idAdmin = @idAdmin, statusDenun = @status WHERE idDenuncia = @id";

            if(denuncia == null)
            {
                Debug.WriteLine("Objeto Denuncia está nulo");
                return resposta;
            }

            try
            {
                this.con = new Conexao();
                SqlCommand cmd = new SqlCommand(sql);
                cmd.Parameters.AddWithValue("@justificativa", denuncia.getObservacao());
                cmd.Parameters.AddWithValue("@idAdmin", denuncia.GetAdmin().getID());
                cmd.Parameters.AddWithValue("@status", denuncia.getStatusDenuncia());
                cmd.Parameters.AddWithValue("@id", denuncia.getIdDenuncia());

                resposta = this.con.updateComParametros(cmd) > 0;
            }catch(Exception e)
            {
                Debug.WriteLine("Erro ao tratar denuncia: " + e.Message);
            }

            return resposta;
        }

        public void notificarTratamentoDenuncia(int tipoNotificacao, int statusDenuncia, Usuario user)
        {
            if(user == null || user.getUserID() == 0)
            {
                Debug.WriteLine("Objeto Usuário está nulo ou id é 0");
                return;
            }

            if(tipoNotificacao != 5 && tipoNotificacao != 6)
            {
                Debug.WriteLine("Tipo de notificação inválida para o Desktop");
                return;
            }

            string msg = string.Empty;

            switch (tipoNotificacao)
            {
                case 5:
                    if(statusDenuncia == Denuncia.STATUS_DEFERIDO)
                    {
                        msg = "A publicação indevida foi deletada. Obrigado pela sua contribução!";
                    }else if(statusDenuncia == Denuncia.STATUS_INDEFERIDO)
                    {
                        msg = "A publicação não viola nossas diretrizes. Agradecemos pela sua contribução!";
                    }
                    break;
                case 6:
                    if(statusDenuncia == Denuncia.STATUS_DEFERIDO)
                    {
                        msg = "Sua publicação foi removida por violar nossas diretrizes.";
                    }
                    break;
            }

            if (string.IsNullOrEmpty(msg))
            {
                Debug.WriteLine("Mensagem de notificação não definida para os parâmetros informados.");
                return;
            }

            try
            {
                string sql = "INSERT INTO tblNotificacao(mensagem,tipoNotificacao,idUsuario) VALUES (@msg,@tipo,@idUser)";
                this.con = new Conexao();
                SqlCommand cmd = new SqlCommand(sql);
                cmd.Parameters.AddWithValue("@msg", msg);
                cmd.Parameters.AddWithValue("@tipo", tipoNotificacao);
                cmd.Parameters.AddWithValue("@idUser", user.getUserID());

                this.con.updateComParametros(cmd);
            }catch(Exception e)
            {
                Debug.WriteLine("Erro ao notificar usuario: " + e.Message);
            }
        }
    }
}