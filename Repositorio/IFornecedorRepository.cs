using SistemaFornecedores.Models;

namespace SistemaFornecedores.Repositorio
{
    public interface IFornecedorRepository
    {
        FornecedorModel ListarPorId(int id);
        List<FornecedorModel> GetAll();
        FornecedorModel Adicionar(FornecedorModel fornecedor);
        FornecedorModel Atualizar(FornecedorModel fornecedor);
        bool Deletar(int id);
    }
}
