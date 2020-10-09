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
                    jogo.Imagem = reader["Imagem"] == DBNull.Value ? null : reader["Imagem"].ToString();
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

        public int InserirJogo(Jogo jogo)
        {
            Conexao.Conectar();
            var comm = new SqlCommand();
            comm.Connection = Conexao.conexao;
            comm.CommandText = @"INSERT INTO Jogo (Titulo, Valor, Imagem, Compra, IdEditor, IdGenero)
                                 VALUES (@Titulo, @Valor, @Imagem, @Compra, @IdEditor, @IdGenero)";

            comm.Parameters.AddWithValue("@Titulo", jogo.Titulo);
            comm.Parameters.AddWithValue("@Valor", jogo.Valor);
            comm.Parameters.AddWithValue("Imagem", jogo.Imagem);
            comm.Parameters.AddWithValue("Compra", jogo.Data);
            comm.Parameters.AddWithValue("@IdEditor", jogo.IdEditor);
            comm.Parameters.AddWithValue("@IdGenero", jogo.IdGenero);

            return comm.ExecuteNonQuery();
        }

        public Jogo ObterJogoId(int id)
        {
            try
            {
                Conexao.Conectar();
                var comm = new SqlCommand();
                comm.Connection = Conexao.conexao;
                comm.CommandText = "SELECT * FROM Jogo WHERE ID = @Id";
                comm.Parameters.AddWithValue("@Id", id);

                var reader = comm.ExecuteReader();
                Jogo jogo = null;

                while (reader.Read())
                {
                    jogo = new Jogo();

                    jogo.Id = Convert.ToInt32(reader["Id"]);
                    jogo.Imagem = reader["Imagem"] == DBNull.Value ? null : reader["Imagem"].ToString();
                    jogo.Data = reader["Compra"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(reader["Compra"]);
                    jogo.Titulo = reader["Titulo"].ToString();
                    jogo.Valor = reader["Valor"] == DBNull.Value ? (double?)null : Convert.ToDouble(reader["Valor"]);
                    jogo.IdEditor = Convert.ToInt32(reader["IdEditor"]);
                    jogo.IdGenero = Convert.ToInt32(reader["IdGenero"]);
                }
                return jogo;
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

        public int AlterarJogo(Jogo jogo)
        {
            try
            {
                Conexao.Conectar();
                var comm = new SqlCommand();
                comm.Connection = Conexao.conexao;
                comm.CommandText = @"UPDATE Jogo SET 
                                Titulo = @Titulo, 
                                Valor = @Valor, 
                                Imagem = @Imagem, 
                                Compra = @Compra, 
                                IdEditor = @IdEditor, 
                                IdGenero = @IdGenero
                                WHERE Id = @Id";

                comm.Parameters.AddWithValue("@Titulo", jogo.Titulo);
                comm.Parameters.AddWithValue("@Valor", jogo.Valor);
                comm.Parameters.AddWithValue("Imagem", jogo.Imagem);
                comm.Parameters.AddWithValue("Compra", jogo.Data);
                comm.Parameters.AddWithValue("@IdEditor", jogo.IdEditor);
                comm.Parameters.AddWithValue("@IdGenero", jogo.IdGenero);
                comm.Parameters.AddWithValue("@Id", jogo.Id);

                return comm.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
