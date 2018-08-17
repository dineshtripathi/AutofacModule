namespace Autofac.Demo.Fluent.FluentInterface
{
    public class OnetAttributes<T> : IOnetAttributes<T> where T : class
    {
        private readonly T Attributes;

        #region Implementation of IOnetAttributes<T>

        public OnetAttributes(T attributes)
        {
            Attributes = attributes;
        }
        public IAttributeElements<T> BuildAttributes()
        {
            return new AttributeElements<T>(Attributes);
        }

        #endregion
    }
}