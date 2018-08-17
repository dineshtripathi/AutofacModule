namespace Autofac.Demo.Fluent.FluentInterface
{
    public interface ICombination<T> where T : class
    {
        IFinal20Attribute<T> ProcessResults();
    }
}