using SistemaFornecedores.Models;

namespace SistemaFornecedores.Repositorio
{
    public interface IFornecedorRepository
    {
        FornecedorModel Adicionar(FornecedorModel fornecedor);
    }
}
