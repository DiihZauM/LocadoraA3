using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LocadoraA3.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Digite o login")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Digite a Senha")]
        public string Senha { get; set; }
    }
}
