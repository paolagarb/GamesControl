using BibliotecaJogosDAL;
using BibliotecaJogosEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaJogosBLL.Exceptions;

namespace BibliotecaJogosBLL.Autenticacao
{
    public class LoginBo
    {
        private UsuarioDAO _usuarioDao;
        public Usuario ObterUsuario(string nomeUsuario, string senha)
        {
            _usuarioDao = new UsuarioDAO();
            var usuario = _usuarioDao.ObterUsuario(nomeUsuario, senha);
            if (usuario == null)
            {
                throw new UsuarioNaoEncontradoException();
            }
            else
            {
                return usuario;
            }
        }
    }
}
