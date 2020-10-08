using BibliotecaJogosDAL;
using BibliotecaJogosEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaJogosBLL
{
    public class EditorBo
    {
        private EditorDAO _editorDAO;

        public List<Editor> ObterEditores()
        {
            _editorDAO = new EditorDAO();
            return _editorDAO.ObterEditores();
        }
    }
}
