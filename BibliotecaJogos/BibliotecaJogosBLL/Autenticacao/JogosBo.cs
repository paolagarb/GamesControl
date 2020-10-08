using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaJogosDAL;
using BibliotecaJogosEntities;

namespace BibliotecaJogosBLL.Autenticacao
{
    public class JogosBo
    {
        private JogoDAO _jogoDAO;

        public List<Jogo> ObterJogos()
        {
            _jogoDAO = new JogoDAO();
            return _jogoDAO.ObterJogos();
        }
    }
}
