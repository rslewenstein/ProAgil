using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using ProAgil.Repository.Data;

namespace ProAgil.Repository
{
    public class ProAgilContextFactory : IDesignTimeDbContextFactory<ProAgilContext>
    {
        public ProAgilContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ProAgilContext>();
            optionsBuilder.UseSqlite("Data Source=ProAgil.db");

            return new ProAgilContext(optionsBuilder.Options);
        }
    }
}

// Classe criada para resolver o erro da migration, que não estava criando o banco.
// Esta classe cria o banco em tempo de execução