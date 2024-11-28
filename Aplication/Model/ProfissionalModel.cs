using System.ComponentModel.DataAnnotations;

namespace PainelDeGestãoDeProfissionais.Aplication.Model
{
    public class ProfissionalModel
    {
        [Required(ErrorMessage = "O nome é obrigatório.")]
        [StringLength(100, ErrorMessage = "O nome deve ter no máximo 100 caracteres.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "A especialidade é obrigatória.")]
        public string? Especialidade { get; set; }

        [Required(ErrorMessage = "O tipo de documento é obrigatório.")]
        public string? TipoDeDocumento { get; set; }

        [Required(ErrorMessage = "O número do documento é obrigatório.")]
        [StringLength(20, ErrorMessage = "O número do documento deve ter no máximo 20 caracteres.")]
        [RegularExpression(@"^\d+$", ErrorMessage = "O número do documento deve conter apenas números.")]
        public string NumeroDocumento { get; set; }
    }
}
