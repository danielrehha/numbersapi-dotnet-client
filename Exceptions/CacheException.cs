using System;
namespace csharp_console_app.Exceptions
{
    public class CacheException : Exception
    {
        public CacheException(string message)
        {
            Console.WriteLine("Cache exception occured" + message);
        }
    }
}
