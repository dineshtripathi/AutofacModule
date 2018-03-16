using Autofac.Demo.Interface;
using System;
using System.Threading.Tasks;

namespace Autofac.Interface.ConcatFactory
{
    public class ConcatFactory :IFactory
    {
        private readonly IAutoFacDemo _autoFacDemo;
        private readonly Func<string, string> _process1;
      
        public ConcatFactory(IAutoFacDemo autoFacDemo)
        {
            _autoFacDemo = autoFacDemo;
            _process1 = process;
        }

        public async Task<string> GetValueAsync(Func<string, Task<string>> fn,string input)
        {
           var retVal= await _autoFacDemo.GetAsync(fn,input );
            return retVal;
        }

        public async Task<Func<string, Task<string>>> GetFunctionAsync(string input)
        {
            return await _autoFacDemo.GetDelegateAsync(input).ConfigureAwait(false);
        }

        private static string process(string a)
        {
            return a;
        }
    }
}
