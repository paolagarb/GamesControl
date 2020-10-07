using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaJogosBLL.Exceptions
{
    public class UsuarioNaoEncontradoException : Exception
    {
        public UsuarioNaoEncontradoException()
        {
        }

        public UsuarioNaoEncontradoException(string message) : base(message)
        {

        }

        public UsuarioNaoEncontradoException(string message, Exception inner) : base(message, inner)
        {

        }
    }
}
