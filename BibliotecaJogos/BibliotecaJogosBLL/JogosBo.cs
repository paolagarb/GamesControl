using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaJogosBLL.Autenticacao;
using BibliotecaJogosBLL.Exceptions;
using BibliotecaJogosDAL;
using BibliotecaJogosEntities;

namespace BibliotecaJogosBLL
{
    public class JogosBo
    {
        private JogoDAO _jogoDAO;

        public List<Jogo> ObterJogos()
        {
            _jogoDAO = new JogoDAO();
            return _jogoDAO.ObterJogos();
        }

        public Jogo ObterJogoId(int id)
        {
            _jogoDAO = new JogoDAO();
            var jogo = _jogoDAO.ObterJogoId(id);

            if (jogo == null )
            {
                throw new JogoNaoEncontradoException();
            } 
            return jogo;
        }

        public void InserirNovoJogo(Jogo jogo)
        {
            _jogoDAO = new JogoDAO();
            ValidarJogo(jogo);

            var linhasAfetadas = _jogoDAO.InserirJogo(jogo);

            if (linhasAfetadas == 0)
            {
                throw new JogoNaoCadastradoException();
            }
        }

        public void ValidarJogo(Jogo jogo)
        {
            if (string.IsNullOrWhiteSpace(jogo.Titulo)
                || jogo.IdEditor == 0
                || jogo.IdGenero == 0)
                throw new JogoInvalidoException();
        }
    }
}
