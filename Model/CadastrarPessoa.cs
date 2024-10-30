namespace Cadastro_API.Model
{
    public class CadastrarPessoa:Servico
    {
        public CadastrarPessoa(String r, WebApplication a):base(r, a)
        {

        }

        override
        public void RunService()
        {
            this.app.MapPost(this.route, async (Pessoa pessoa, PessoaDb db) => {

                db.Pessoas.Add(pessoa);

                await db.SaveChangesAsync();

                return Results.Created(this.route + $"/{pessoa.Id}", pessoa);
            });
        }

    }
}
