using Microsoft.AspNetCore.Diagnostics.EntityFrameworkCore; //Ajuda na geração de diagnósticos para debug e análise de possíveis erros
using Microsoft.EntityFrameworkCore.InMemory; //Permite gerar uma estrutura de bd em memória local 

namespace Cadastro_API.Control
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();

            

            app.Run();
        }
    }
}
