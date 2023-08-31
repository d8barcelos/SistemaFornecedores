using Microsoft.EntityFrameworkCore;
using SistemaFornecedores.Models;

namespace SistemaFornecedores.Context
{
    public class DatabaseContext :DbContext 
    { 
        public DatabaseContext(DbContextOptions<DatabaseContext> contextOptions) : base(contextOptions)
        { 
        }

        public DbSet<FornecedorModel>Fornecedores { get; set; }
    }
}

