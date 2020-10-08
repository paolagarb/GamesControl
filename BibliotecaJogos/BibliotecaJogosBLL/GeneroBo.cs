using BibliotecaJogosDAL;
using BibliotecaJogosEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaJogosBLL
{
    public class GeneroBo
    {
        private GeneroDAO _generoDao;

        public List<Genero> ObterGeneros()
        {
            _generoDao = new GeneroDAO();
            return _generoDao.ObterGeneros();
        }
    }
}
