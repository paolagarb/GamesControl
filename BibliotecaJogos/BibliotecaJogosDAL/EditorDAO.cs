using BibliotecaJogosEntities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaJogosDAL
{
    public class EditorDAO
    {
            public List<Editor> ObterEditores()
            {
                try
                {
                    Conexao.Conectar();
                    var comm = new SqlCommand();
                    comm.Connection = Conexao.conexao;
                    comm.CommandText = "SELECT * FROM Editor order by Nome ASC";

                    var reader = comm.ExecuteReader();
                    var editores = new List<Editor>();

                    while (reader.Read())
                    {
                        var editor = new Editor();

                        editor.Id = Convert.ToInt32(reader["Id"]);
                        editor.Nome = reader["Nome"].ToString();

                        editores.Add(editor);
                    }
                    return editores;
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