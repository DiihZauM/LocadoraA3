using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LocadoraA3.Models
{
    public class Cliente
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string cpf { get; set; }
        public string endereco { get; set; }
        public string telefone { get; set; }
        [DisplayFormat(DataFormatString ="0:dd/MM/YYYY")]
        public DateTime dataNascimento { get; set; }
        public string senha { get; set; }
        public string email { get; set; }
    }
}
