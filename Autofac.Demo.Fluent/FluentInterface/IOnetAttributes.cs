namespace Autofac.Demo.Fluent.FluentInterface
{
    using System.Security.Cryptography.X509Certificates;

    public interface IOnetAttributes<T> where T:class
    {
        IAttributeElements<T> BuildAttributes();
    }

    
}