namespace Cadastro_API.Model
{
    public class CadastrarEndereco:Servico
    {
        public CadastrarEndereco(String r, WebApplication a):base(r, a)
        {

        }

        override //Sobrescreve o método da classe pai nesta subclasse
        public void RunService()
        {
            this.app.MapPost(this.route, async (Pessoa pessoa,Endereco address, EnderecoDb db) => {
                
                db.Enderecos.Add(address);
                await db.SaveChangesAsync();

                return Results.Created(this.route + $"/{pessoa.Id}/{address.Id}", address);
            });
        }

    }
}
