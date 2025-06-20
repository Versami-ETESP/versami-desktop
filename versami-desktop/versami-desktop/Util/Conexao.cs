﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace versami_desktop.Util
{
    class Conexao
    {
        private SqlConnection conexao = new SqlConnection();

        public SqlConnection conectar()
        {
            try
            {
                if (conexao == null)
                    conexao = new SqlConnection();
                String strConexao = "Password=Tc2088275; Persist Security Info=True; User ID=sa; Initial Catalog=versami; Data Source=" + Environment.MachineName + "\\SqlExpress";
                conexao.ConnectionString = strConexao;
                conexao.Open();
                return conexao;
            }
            catch (Exception)
            {
                desconectar();
                return null;
            }
        }

        public void desconectar()
        {
            try
            {
                if ((conexao.State == ConnectionState.Open))
                {
                    conexao.Close();
                    conexao.Dispose();
                    conexao = null;
                }
            }
            catch (Exception) { }
        }

        public DataTable executarSQL(String comando_sql)
        {
            try
            {
                conectar();
                SqlDataAdapter adaptador = new SqlDataAdapter(comando_sql, conexao);
                DataSet ds = new DataSet();
                adaptador.Fill(ds);
                return ds.Tables[0];
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                desconectar();
            }
        }

        public DataTable queryComParametros(SqlCommand comando)
        {
            DataTable dt = null;
            try
            {
                comando.Connection = conectar();
                SqlDataReader dr = comando.ExecuteReader();
                dt = new DataTable();
                dt.Load(dr); //converte DataReader em DataTable
            }
            catch (Exception) { }
            desconectar();
            return dt;
        }

        public bool manutencaoDB(String comando_sql) //incluir, alterar, excluir
        {
            try
            {
                conectar();
                SqlCommand comando = new SqlCommand();
                comando.CommandText = comando_sql;
                comando.Connection = conexao;
                comando.ExecuteScalar();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                desconectar();
            }
        }//fim do método manutençãoDB

        public int updateComParametros(SqlCommand comando) //incluir, alterar, excluir com parâmetros
        {
            int retorno = 0;
            try
            {
                comando.Connection = conectar();  //adiciona a conexão ao SQLCommand
                retorno = comando.ExecuteNonQuery(); //devolve o número de linhas afetadas no banco
            }
            catch (Exception) { }
            desconectar();
            return retorno;
        }//fim do método manutençãoDB com parâmetros
    }
}
