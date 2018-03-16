using System;
using System.Threading.Tasks;

namespace Autofac.Demo.Interface
{
    public interface IAutoFacDemo :IDisposable
    {
        Task<string> GetAsync(Func<string, Task<string>> concat, string input);
        Task<Func<string, Task<string>>> GetDelegateAsync(string input);

    }
}
