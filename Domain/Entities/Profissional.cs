using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace PainelDeGestãoDeProfissionais.Domain.Entities
{
    public class Profissional : Entity
    {
        public string Nome { get; set; }
        public string Especialidade { get; set; }
        public string TipoDeDocumento { get; set; }
        public string NumeroDoDocumento { get; set; }


        public List<string> Validar()
        {
            var erros = new List<string>();

            if (string.IsNullOrWhiteSpace(Nome))
                erros.Add("O nome é obrigatório.");

            if (string.IsNullOrWhiteSpace(Especialidade))
                erros.Add("A especialidade é obrigatória.");

            if (string.IsNullOrWhiteSpace(TipoDeDocumento))
                erros.Add("O tipo de documento é obrigatório.");


            if (string.IsNullOrWhiteSpace(NumeroDoDocumento))
            {
                erros.Add("O número do documento é obrigatório.");
            }
            else
            {
                if (NumeroDoDocumento.Length < 5 || NumeroDoDocumento.Length > 20)
                    erros.Add("O número do documento deve ter entre 5 e 20 caracteres.");

                if (!Regex.IsMatch(NumeroDoDocumento, @"^\d+$"))
                    erros.Add("O número do documento deve conter apenas números.");
            }

            return erros;
        }

    }
}
