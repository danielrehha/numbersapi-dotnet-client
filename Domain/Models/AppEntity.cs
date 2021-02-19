using System;
namespace csharp_console_app.Models
{
    public abstract class AppEntity
    {
        public AppEntity(string type)
        {
            Console.WriteLine("Entity created: " + type);
        }
    }
}
