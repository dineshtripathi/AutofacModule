namespace Autofac.Demo.Fluent.FluentInterface
{
    public class AttributeElements<T> : IAttributeElements<T> where T : class
    {
        #region Implementation of IAttributeElements<T>

        private T Attributes;
        public AttributeElements(T attributeElements)
        {
            Attributes = attributeElements;
        }
        

        #endregion

        #region Implementation of IAttributeElements<T>

        public IScore<T> AverageOutScores()
        {
            return new Score<T>(Attributes);
        }

        #endregion
    }
}