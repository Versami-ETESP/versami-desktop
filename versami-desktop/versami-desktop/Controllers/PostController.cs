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
    class PostController
    {
        private Conexao con;
        private DataTable dt;

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