using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Entities
{
    public class Usuario :IntId
    {
        public string User { get; set; }
        public string Senha { get; set; }
        public char Perfil { get; set; }

    }
}
