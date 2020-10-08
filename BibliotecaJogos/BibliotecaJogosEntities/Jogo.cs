using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaJogosEntities
{
    public class Jogo : IntID
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public double? Valor { get; set; }
        public string Imagem { get; set; }
        public DateTime? Data { get; set; }
        public int IdGenero { get; set; }
        public Genero Genero { get; set; }
        public int IdEditor { get; set; }
        public Editor Editor { get; set; }
    }
}
