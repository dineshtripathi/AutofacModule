using System;
using System.Threading.Tasks;

namespace Autofac.Demo.Interface.Impl.Car
{
    public class CarConcat : IAutoFacDemo
    {
        #region Implementation of IAutoFacDemo

        public CarConcat()
        {

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

        ~CarConcat()
        {
            Dispose(false);
        }
        public async Task<string> GetAsync(Func<string, Task<string>> concat, string input)
        {
            if (concat != null)
                return await Task.FromResult(await (concat(input)));
            return null;
        }

        public Task<Func<string, Task<string>>> GetDelegateAsync(string input)
        {
            return null;
        }

        private async Task<string> Concat(string a)
        {
            return a + ":" + a;
        }
        #endregion
    }
}
