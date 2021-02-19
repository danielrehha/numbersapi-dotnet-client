using System;
using System.Threading.Tasks;
using csharp_console_app.Data;
using csharp_console_app.Exceptions;
using csharp_console_app.Models;

namespace csharp_console_app.Domain
{
    public interface ITriviaRepository
    {
        Task<TriviaModel> GetConcreteTrivia(string number);
        Task<TriviaModel> GetRandomTrivia();
    }

    public class TriviaRepository : ITriviaRepository
    {
        private readonly IRemoteDataSource _remoteDataSource;
        
        public TriviaRepository(IRemoteDataSource remoteDataSource)
        {
            _remoteDataSource = remoteDataSource;
        }

        public async Task<TriviaModel> GetConcreteTrivia(string number)
        {
            try
            {
                var result = await _remoteDataSource.GetConcreteTrivia(number);
                
                return result;
            }
            catch (ServerException)
            {
                return null;
            }
        }

        public async Task<TriviaModel> GetRandomTrivia()
        {
            throw new NotImplementedException();
        }
    }
}
