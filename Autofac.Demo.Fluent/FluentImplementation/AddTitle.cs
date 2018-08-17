namespace Autofac.Demo.Fluent.FluentInterface
{
    public class AddTitle<T> : IAddTitle<T> where T : class
    {
        private readonly T model;
        #region Implementation of IAddTitle<T>

        public AddTitle(T model)
        {
            this.model = model;
        }
        public IBoostMaths<T> BoostMathsSkills()
        {
            return new BoostMaths<T>(model);
        }

        #endregion
    }
}