using BibliotecaJogosEntities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaJogosDAL
{
    public class GeneroDAO
    {
        public List<Genero> ObterGeneros()
        {
            try
            {
                Conexao.Conectar();
                var comm = new SqlCommand();
                comm.Connection = Conexao.conexao;
                comm.CommandText = "SELECT * FROM Genero order by Descricao ASC";

                var reader = comm.ExecuteReader();
                var generos = new List<Genero>();

                while (reader.Read())
                {
                    var genero = new Genero();

                    genero.Id = Convert.ToInt32(reader["Id"]);
                    genero.Descricao = reader["Descricao"].ToString();
                   
                    generos.Add(genero);
                }
                return generos;
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
