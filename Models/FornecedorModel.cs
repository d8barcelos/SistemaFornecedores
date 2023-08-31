using Microsoft.EntityFrameworkCore;

namespace SistemaFornecedores.Models
{
    public class FornecedorModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string CNPJ { get; set; }
        public string Especialidade { get; set; }
        public string CEP { get; set; }
        public string Endereco { get; set; } 
    }
}
