using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LocadoraA3.Models
{
    public class Livro
    { 
        public int id { get; set; }
        public string nome  { get; set; }
        public string autor { get; set; }
        public string editora { get; set; }
        public double preco { get; set; }

    }
}
