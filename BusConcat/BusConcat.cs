using System;
using System.Threading.Tasks;

namespace BusConcat
{
    using Autofac.Demo.Interface;

    public class BusConcat : IAutoFacDemo
    {
        #region Implementation of IAutoFacDemo

        public BusConcat()
        {

        }
        public async Task<string> GetAsync(Func<string, Task<string>> concat, string input)
        {
            var ret = string.Empty;
            var newret = concat?.Invoke(ret).Result;
            var retVal = FunctionAsync(concat, input).Result;
            return await Task.FromResult(retVal).ConfigureAwait(false);
        }

        public async Task<Func<string, Task<string>>> GetDelegateAsync(string input)
        {
            await Task.Delay(1);
            return (async (x)=> await Task.FromResult(input + "FuncDelegate").ConfigureAwait(false));

        }

        private static async Task<string> FunctionAsync(Func<string, Task<string>> bus, string input)
        {
            if (bus != null)
            {
                var val = await bus(ProcessAsync(input).Result).ConfigureAwait(false);
                return  val;
            }
            return null;
        }

        private static async Task<string> ProcessAsync(string input)
        {
            return await Task.FromResult(input).ConfigureAwait(false);
        }
        #endregion

        #region IDisposable

        private static void ReleaseUnmanagedResources()
        {
            // TODO release unmanaged resources here
        }

        protected virtual void Dispose(bool disposing)
        {
            ReleaseUnmanagedResources();
            if (disposing)
            {
                Dispose(true);
                GC.SuppressFinalize(this);
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        ~BusConcat()
        {
            Dispose(false);
        }

        #endregion
    }
}
