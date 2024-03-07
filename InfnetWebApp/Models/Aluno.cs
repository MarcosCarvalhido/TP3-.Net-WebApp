
using System.ComponentModel.DataAnnotations;

namespace InfnetWebApp.Models
{
    public class Aluno
    {
        [Required(ErrorMessage ="Id Obrigatorio")]
        public string Id { get; set; }

        [Required(ErrorMessage = "Nome Obrigatorio")]
        [Display(Name = "Nome do Aluno")]
        [StringLength(50, MinimumLength = 4, ErrorMessage ="Nome deve ter entre 5 e 50 Caracteries")]
        public string Nome { get; set; }

        public string Endereco { get; set; }
        public string Telefone { get; set; }

        [DataType(DataType.EmailAddress,ErrorMessage = "Prencha apenas com Emails!")]
        public string Email { get; set; }

        [Display(Name = "Data de Nascimento")]
        [DataType(DataType.Date,ErrorMessage ="Prencha apenas com datas!")]
        public string Nascimento { get; set; }
    }
}
