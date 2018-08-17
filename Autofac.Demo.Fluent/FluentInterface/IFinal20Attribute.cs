namespace Autofac.Demo.Fluent.FluentInterface
{
    using System.Collections.Generic;
    using Model;

    public interface IFinal20Attribute<T> where T : class
    {
        IDictionary<OnetAttributeModelKey, OnetAttributeModelValue> GetResults();
    }
}