using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaJogosEntities;

namespace BibliotecaJogosDAL
{
    public class UsuarioDAO
    {
        public Usuario ObterUsuario(string nomeUsuario, string senha)
        {
            try
            {
                Conexao.Conectar();

                var comm = new SqlCommand();
                comm.Connection = Conexao.conexao;
                comm.CommandText = "SELECT * FROM USUARIO WHERE USUARIO = @USUARIO AND SENHA = @SENHA";

                comm.Parameters.AddWithValue("@USUARIO", nomeUsuario);
                comm.Parameters.AddWithValue("@SENHA", senha);

                var reader = comm.ExecuteReader();
                Usuario usuario = null;

                while (reader.Read())
                {
                    usuario = new Usuario();
                    usuario.Id = Convert.ToInt32(reader["Id"]);
                    usuario.User = reader["Usuario"].ToString();
                    usuario.Senha = reader["Senha"].ToString();
                    usuario.Perfil = Convert.ToChar(reader["Perfil"]);
                }
                return usuario;
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
