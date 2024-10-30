using Microsoft.AspNetCore.Diagnostics.EntityFrameworkCore; //Ajuda na gera��o de diagn�sticos para debug e an�lise de poss�veis erros
using Microsoft.EntityFrameworkCore.InMemory; //Permite gerar uma estrutura de bd em mem�ria local 

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
