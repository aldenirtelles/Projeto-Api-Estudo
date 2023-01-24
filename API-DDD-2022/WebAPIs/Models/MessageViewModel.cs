using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIs.Models
{
    public class MessageViewModel
    {

        public int Id { get; set; }

        [MaxLength(255)]
        [Required(ErrorMessage = "O preenchimento do Titulo é obrigatório!")]
        public string Titulo { get; set; }

        public bool Ativo { get; set; }

        public DateTime DataCadastro { get; set; }

        public DateTime DataAlteracao { get; set; }

        [ForeignKey("ApplicationUser")]
        [Required(ErrorMessage = "O preenchimento do campo é obrigatório!")]
        public string UserId { get; set; }
    }
}
