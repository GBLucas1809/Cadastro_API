using Microsoft.EntityFrameworkCore; //importa os recursos para criar uma estrutura de bd 


namespace Cadastro_API.Model
{
    public class EnderecoDb : DbContext
    {

        //Herda as operações do construtor da classe DbContext
        //(que passa DbContextOptions<Endereco> como parâmetro)
        public EnderecoDb(DbContextOptions<EnderecoDb> options):base(options) { }
        public DbSet<Endereco> Enderecos => Set<Endereco>(); //Cria um set(conjunto) de endereços para bd 
    }
}
