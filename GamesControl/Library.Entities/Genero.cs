using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Entities
{
    public class Genero : IntId
    {
        public IntId Id { get; set; }
        public string Descricao { get; set; }
    }
}
