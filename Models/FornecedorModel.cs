using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaFornecedores.Models
{
    public class FornecedorModel
    {
        public int Id { get; set; }
        [MaxLength(100)]
        [Required(ErrorMessage = "o campo 'nome' é obrigatório")] 
        public string Name { get; set; }
        [MaxLength(14)]
        [Required(ErrorMessage = "o campo 'CNPJ' é obrigatório")]
        public string CNPJ { get; set; }
        public string Especialidade { get; set; }
        [MaxLength(8)]
        [Required(ErrorMessage = "o campo 'CEP' é obrigatório")]
        public string CEP { get; set; }
        public string Rua { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string UF { get; set; }
        public string Endereco
        {
            get
            {
                return $"{Rua}, {Bairro}, {Cidade}, {UF}";
            }
            set { }
        }

    }
}
