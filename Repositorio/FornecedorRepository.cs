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

        public FornecedorModel Atualizar(FornecedorModel fornecedor)
        {
            FornecedorModel fornecedorDB = ListarPorId(fornecedor.Id);

            if (fornecedorDB == null) throw new System.Exception("Houve um erro na atualização");

            fornecedorDB.Name = fornecedor.Name;
            fornecedorDB.CNPJ = fornecedor.CNPJ;
            fornecedorDB.Especialidade = fornecedor.Especialidade;
            fornecedorDB.CEP = fornecedor.CEP;
            fornecedorDB.Rua = fornecedor.Rua;
            fornecedorDB.Bairro = fornecedor.Bairro;
            fornecedorDB.Cidade = fornecedor.Cidade;
            fornecedorDB.UF = fornecedor.UF;
            fornecedorDB.Endereco = fornecedor.Endereco;

            _DbContext.Fornecedores.Update(fornecedorDB);
            _DbContext.SaveChanges();

            return fornecedorDB;
        }

        public bool Deletar(int id)
        {
            FornecedorModel fornecedorDB = ListarPorId(id);

            if (fornecedorDB == null) throw new System.Exception("Houve um erro na Deleção do fornecedor");

            _DbContext.Fornecedores.Remove(fornecedorDB);
            _DbContext.SaveChanges();

            return true;
        }

        public List<FornecedorModel> GetAll()
        {
            return _DbContext.Fornecedores.ToList();
        }

        public FornecedorModel ListarPorId(int id)
        {
            var fornecedor = _DbContext.Fornecedores.Find(id);
            return fornecedor;
        }
    }
}
