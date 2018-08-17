namespace Autofac.Demo.Fluent.FluentInterface
{
    using System;
    using System.Collections.Generic;
    using System.Reflection;
    using Model;

    public class Final20Attribute<T> : IFinal20Attribute<T> where T : class
    {
        private readonly T Attributes;

        public Final20Attribute(T attributesElements)
        {
            Attributes = attributesElements;
        }
        #region Implementation of IFinal20Attribute<T>

        public IDictionary<OnetAttributeModelKey, OnetAttributeModelValue> GetResults()
        {
            var AttributeObject = Attributes.GetType();
            var AttributesProperties = AttributeObject.GetProperty("KeyValueOnetAttribute");
            return (IDictionary<OnetAttributeModelKey, OnetAttributeModelValue>)AttributesProperties?.GetValue(Attributes);
        }

        #endregion
    }
}