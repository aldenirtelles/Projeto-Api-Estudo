using Entities.Validation;
using System.ComponentModel.DataAnnotations;

namespace WebAPIs.Models
{
    public class Login
    {
        [EmailAddress(ErrorMessage = "Email Inválido!")]
        [Required(ErrorMessage = "O preenchimento do Email é obrigatório!")]
        public string email { get; set; }

        [Required(ErrorMessage = "O preenchimento da Senha é obrigatório!")]
        public string senha { get; set; }

        [CpfValidation(ErrorMessage = "CPF Inválido!")]
        [Required(ErrorMessage = "O preenchimento do CPF é obrigatório!")]
        public string cpf { get; set; }
    }
}
