using GamesControlBLL.Exceptions;
using GamesControlDAL;
using Library.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamesControlBLL.Autenticacao
{
    public class LoginBo
    {
        private UsuarioDAO _usuarioDao;
        public Usuario ObterUsuario(string nomeUsuario, string senha)
        {
            Usuario usuario = _usuarioDao.ObterUsuario(nomeUsuario, senha);
            if (usuario == null)
            {
                throw new UsuarioNaoCadastradoException();
            } else
            {
                return usuario;
            }
        }
    }
}
