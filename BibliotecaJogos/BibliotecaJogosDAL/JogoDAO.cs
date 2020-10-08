using BibliotecaJogosEntities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaJogosDAL
{
    public class JogoDAO
    {
        public List<Jogo> ObterJogos()
        {
            try
            {
                Conexao.Conectar();
                var comm = new SqlCommand();
                comm.Connection = Conexao.conexao;
                comm.CommandText = "SELECT * FROM Jogo";

                var reader = comm.ExecuteReader();
                var jogos = new List<Jogo>();

                while (reader.Read())
                {
                    var jogo = new Jogo();

                    jogo.Id = Convert.ToInt32(reader["Id"]);
                    jogo.Imagem = reader["Imagem"] == DBNull.Value? null : reader["Imagem"].ToString();
                    jogo.Data = reader["Compra"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(reader["Compra"]);
                    jogo.Titulo = reader["Titulo"].ToString();
                    jogo.Valor = reader["Valor"] == DBNull.Value ? (double?)null : Convert.ToDouble(reader["Valor"]);
                    jogos.Add(jogo);
                }
                return jogos;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                Conexao.Desconectar();
            }
        }
    }
}
