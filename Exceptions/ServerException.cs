using System;
namespace csharp_console_app.Exceptions
{
    public class ServerException : Exception
    {
        public ServerException(string message)
        {
            Console.WriteLine("Server exception: " + message);
        }
    }
}
