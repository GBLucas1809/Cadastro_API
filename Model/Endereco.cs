namespace Cadastro_API.Model
{
    public class Endereco
    {

        public String Id {  get; set; }   
        public String Logradouro {  get; set; }
        public int Numero { get; set; }

        public String Bairro { get; set; }
        public String Cidade { get; set; }

        public String Estado { get; set; }
    }
}
