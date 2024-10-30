using Microsoft.EntityFrameworkCore;
namespace Cadastro_API.Model
{
    public class Pessoa
    {
        public int Id { get; set; }    
        public String Nome { get; set; }
        public String? Email { get; set; }
        public int Idade { get; set; }

        public List<Endereco> Addresses { get; set; }


    }
}
