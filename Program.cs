using System;
using System.Threading.Tasks;
using csharp_console_app.Data;
using csharp_console_app.Domain;
using csharp_console_app.Domain.Usecases;

namespace csharp_console_app
{
    class Program
    {

        static void Main(string[] args)
        {
            GetTrivia().Wait();
        }

        
        static async Task GetTrivia()
        {
            GetConcreteTrivia getConcreteTrivia = new GetConcreteTrivia(
            new TriviaRepository(
                new RemoteDataSource()));

            var trivia = await getConcreteTrivia.Return("2");
            if (trivia != null)
            {
                Console.WriteLine("Successful Trivia fetch: " + trivia.Text);
            }
            else
            {
                Console.WriteLine("Trivia returned null");
            }

        }
    }
}
