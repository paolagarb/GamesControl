using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;

namespace GamesControlDAL
{
    public class Conexao
    {
        public static string stringConexao = ConfigurationManager.ConnectionStrings["ConexaoSqlServer"].ConnectionString;
        public static SqlConnection conexao = new SqlConnection(stringConexao);

        public static void Conectar()
        {
            try
            {
                if (conexao.State != ConnectionState.Open) conexao.Open();
            } catch (SqlException e)
            {
                Console.WriteLine($"Erro de conexão: {e.Message}");
            }
           
        }

        public static void Desconectar()
        {
            try
            {
                if (conexao.State == ConnectionState.Open) conexao.Close();
            } catch (SqlException e)
            {
                Console.WriteLine($"Erro de conexão: {e.Message}");
            }
        }
    }
}
