using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using versami_desktop.Util;

namespace versami_desktop.Controllers
{
    class DashboardController
    {
        Conexao con;
        DataTable dt;

        /*
         * Selects para criar o dashBoard
         * SELECT COUNT(*) AS TOTAL, MONTH(dataPublic) AS MES FROM tblPublicacao WHERE YEAR(dataPublic) = 2025 GROUP BY MONTH(dataPublic)
         * 
           SELECT COUNT(*) AS TOTAL, MONTH(data_coment) AS MES FROM tblComentario WHERE YEAR(data_coment) = 2025 GROUP BY MONTH(data_coment)

            SELECT TOP 10 u.nome, u.arroba_usuario, COUNT(p.idPublicacao) AS total_publicacoes
            FROM tblUsuario u
            JOIN tblPublicacao p ON u.idUsuario = p.idUsuario
            GROUP BY u.nome, u.arroba_usuario
            ORDER BY total_publicacoes DESC
        */
        public DataTable obterEstatisticasPublicacoes()
        {
            DateTime data = DateTime.Now;
            var sql = "SELECT COUNT(*) AS TOTAL, MONTH(dataPublic) AS MES " +
                     "FROM tblPublicacao WHERE YEAR(dataPublic) = @ano GROUP BY MONTH(dataPublic)";

            try
            {
                this.con = new Conexao();
                SqlCommand cmd = new SqlCommand(sql);
                cmd.Parameters.AddWithValue("@ano", data.Year);
                this.dt = this.con.queryComParametros(cmd);
            }catch(Exception e)
            {
                Debug.WriteLine("Erro ao consultar publicacoes: " + e.Message);
            }
            return this.dt;
        }

        public DataTable obterEstatisticasComentarios()
        {
            DateTime data = DateTime.Now;
            string sql = "SELECT COUNT(*) AS TOTAL, MONTH(data_coment) AS MES " +
                "FROM tblComentario WHERE YEAR(data_coment) = @ano GROUP BY MONTH(data_coment)";

            try
            {
                this.con = new Conexao();
                SqlCommand cmd = new SqlCommand(sql);
                cmd.Parameters.AddWithValue("@ano", data.Year);
                this.dt = this.con.queryComParametros(cmd);
            }catch(Exception e)
            {
                Debug.WriteLine("Erro ao consultar comentarios: " + e.Message);
            }
            return this.dt;
        }

        public DataTable obterEstatisticasUsers()
        {
            string sql = "usp_faixaEtatariaUsers";
            try
            {
                this.con = new Conexao();
                SqlCommand cmd = new SqlCommand(sql);
                this.dt = this.con.queryComParametros(cmd);
            }catch(Exception e)
            {
                Debug.WriteLine("Erro ao executar procedure de estatistica: " + e.Message);
            }

            return this.dt;
        }
    }
}
