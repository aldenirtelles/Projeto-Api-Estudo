using Entities.Enums;
using Entities.Validation;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    public  class ApplicationUser : IdentityUser
    {
        [CpfValidation(ErrorMessage = "CPF Inválido!")]
        [Required(ErrorMessage = "O preenchimento do CPF é obrigatório!")]
        [Column("USR_CPF")]
        public string CPF { get; set; }

        [Column("USR_TIPO")]
        public TipoUsuario? Tipo { get; set; }
    }
}
