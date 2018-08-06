using Autofac.Demo.Interface;
using System;
using System.Threading.Tasks;

namespace Autofac.Interface.ConcatFactory
{
    using System.Collections.Generic;
    using System.Linq;
    using Core;
    using Demo.Common;

    public class ConcatFactory :IFactory
    {
        private readonly List<IAutoFacDemo> _autoFacDemo;
        private readonly Func<string, string> _process1;
      
        public ConcatFactory(IEnumerable<IAutoFacDemo> autoFacDemo)
        {
            _autoFacDemo = autoFacDemo.ToList();
            _process1 = process;
        }

        public async Task<string> GetValueAsync(Func<string, Task<string>> fn,string input)
        {
           
           var retVal= await _autoFacDemo[(int)ViewerType.Bus].GetAsync(fn,input );
            retVal = await _autoFacDemo[(int)ViewerType.Car].GetAsync(fn, input);
            return retVal;
        }

        public async Task<Func<string, Task<string>>> GetFunctionAsync(string input)
        {
            return await _autoFacDemo[(int)ViewerType.Bus].GetDelegateAsync(input).ConfigureAwait(false);
        }

        private static string process(string a)
        {
            return a;
        }
    }
}
