namespace Autofac.Demo.Fluent.FluentInterface
{
    using Model;

    public class Combination<T> : ICombination<T> where T : class
    {
        private readonly T model;
        #region Implementation of ICombination<T>

        public Combination(T model)
        {
            this.model = model;
        }
        public IFinal20Attribute<T> ProcessResults()
        {
            return new Final20Attribute<T>(model);
        }

        #endregion
    }
}