using Microsoft.EntityFrameworkCore;

namespace Cadastro_API.Model
{
    public class PessoaDb : DbContext
    {

        public PessoaDb(DbContextOptions<PessoaDb> options) : base(options) { }


        public DbSet<Pessoa> Pessoas => Set<Pessoa>();

    }
}
