using System;
using System.Threading.Tasks;
using csharp_console_app.Models;

namespace csharp_console_app.Domain.Usecases
{
    public class GetConcreteTrivia : UseCase<TriviaModel>
    {
        private readonly ITriviaRepository _triviaRepository;

        public GetConcreteTrivia(ITriviaRepository triviaRepository)
        {
            _triviaRepository = triviaRepository;
        }

        public async Task<TriviaModel> Return(string arg = "")
        {
            var result = await _triviaRepository.GetConcreteTrivia(arg);
            return result;
        }
    }
}
