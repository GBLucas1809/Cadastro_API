namespace Cadastro_API.Model
{
    public abstract class Servico
    {
        protected String route { get; set; }
        protected WebApplication app { get; set; }

        public Servico(String r, WebApplication a) {
            this.route = r;
            this.app = a;
        }

        public abstract void RunService();
    }
}
