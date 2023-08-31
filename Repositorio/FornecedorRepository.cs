using SistemaFornecedores.Context;
using SistemaFornecedores.Models;

namespace SistemaFornecedores.Repositorio
{
    public class FornecedorRepository : IFornecedorRepository
    {
        private readonly DatabaseContext _DbContext;
        public FornecedorRepository(DatabaseContext DbContext)
        {
            _DbContext = DbContext;
        }
        public FornecedorModel Adicionar(FornecedorModel fornecedor)
        {
            _DbContext.Fornecedores.Add(fornecedor);
            _DbContext.SaveChanges();
            return fornecedor;
        }
    }
}
