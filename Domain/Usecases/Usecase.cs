using System;
using System.Threading.Tasks;

namespace csharp_console_app.Domain.Usecases
{
    public interface UseCase<T>
    {
        Task<T> Return(string arg = "");
    }
}
