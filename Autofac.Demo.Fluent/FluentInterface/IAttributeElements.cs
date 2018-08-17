namespace Autofac.Demo.Fluent.FluentInterface
{
    public interface IAttributeElements<T> where T : class
    {
        IScore<T> AverageOutScores();
    }
}