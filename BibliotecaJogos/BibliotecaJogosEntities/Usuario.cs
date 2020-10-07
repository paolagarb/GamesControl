using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaJogosEntities
{
    public class Usuario : IntID
    {
            public string User { get; set; }
            public string Senha { get; set; }
            public char Perfil { get; set; }

    }
}
