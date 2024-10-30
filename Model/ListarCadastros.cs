namespace Cadastro_API.Model
{
    public class ListarCadastros: Servico
    {

        public ListarCadastros(String r, WebApplication a):base(r, a)
        {

        }

        public void RunService()
        {
            this.app.MapGet(this.route, async (PessoaDb pdb, EnderecoDb edb) => { 
            
            });
        }
    }
}
