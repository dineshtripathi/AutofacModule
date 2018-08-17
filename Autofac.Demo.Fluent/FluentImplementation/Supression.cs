namespace Autofac.Demo.Fluent.FluentInterface
{
    public class Supression<T> : IRemoveSupression<T> where T : class
    {
        #region Implementation of ISupression<T>

        private T Attributes;
        public Supression(T attributeElements)
        {
            Attributes = attributeElements;
        }
        public IAddTitle<T> AddTitle()
        {
            return new AddTitle<T>(Attributes);
        }

        #endregion
    }
}