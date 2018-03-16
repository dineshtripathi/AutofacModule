namespace Autofac.Interface.ConcatFactory
{
    using System;
    using System.Threading.Tasks;

    public interface IFactory
    {
        Task<string> GetValueAsync(Func<string,Task<string>> fn,string input);
        Task<Func<string, Task<string>>> GetFunctionAsync(string input);
    }
}