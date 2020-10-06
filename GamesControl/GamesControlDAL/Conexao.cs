using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace GamesControlDAL
{
    public class Conexao
    {
        public void Conectar()
        {
            string stringConexao = ConfigurationManager.ConnectionStrings["ConexaoSqlServer"].ConnectionString;
            SqlConnection conn = new SqlConnection();
            
        }

        public void Desconectar()
        {

        }
    }
}
