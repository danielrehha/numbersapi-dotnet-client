using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using csharp_console_app.Exceptions;
using csharp_console_app.Models;
using Newtonsoft.Json;

namespace csharp_console_app.Data
{
    public interface IRemoteDataSource
    {
        Task<TriviaModel> GetConcreteTrivia(string number);
        Task<TriviaModel> GetRandomTrivia();
    }

    public class RemoteDataSource : IRemoteDataSource
    {
        private HttpClient _client;

        public RemoteDataSource()
        {
            _client = new HttpClient();
            _client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
        }
        public async Task<TriviaModel> GetConcreteTrivia(string number)
        {
            string url = "http://numbersapi.com/" + number;
            HttpRequestMessage _request = new HttpRequestMessage(HttpMethod.Get, url);
            _request.Headers.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            Console.WriteLine("Request URL: " + url);
            var respone = await _client.GetAsync(url);
            //respone.EnsureSuccessStatusCode();
            HttpContent content = respone.Content;
            var mycontent = await content.ReadAsStringAsync();
            Console.WriteLine("Results: " + mycontent);
            if (respone != null)
            {
                //Dictionary<string, dynamic> dict = JsonConvert.DeserializeObject<Dictionary<string, dynamic>>(result);
                TriviaModel trivia = new TriviaModel();
                //trivia = JsonConvert.DeserializeObject<TriviaModel>(respone.Content.ToString());
                return trivia;
            }
            else
            {
                throw new ServerException("Couldn't get Trivia from server.");
            }
        }

        public async Task<TriviaModel> GetRandomTrivia()
        {
            throw new NotImplementedException();
        }
    }
}
