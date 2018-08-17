namespace Autofac.Demo.Fluent.FluentInterface
{
    using System.Runtime.InteropServices.WindowsRuntime;

    public class BoostMaths<T> : IBoostMaths<T> where T : class
    {
        private readonly T model;
        #region Implementation of IBoostMaths<T>

        public BoostMaths(T model)
        {
            this.model = model;
        }
        public ICombination<T> CombineAttributes()
        {
           return new Combination<T>(model);
        }

        #endregion
    }
}