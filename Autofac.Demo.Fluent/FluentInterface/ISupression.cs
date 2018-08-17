namespace Autofac.Demo.Fluent.FluentInterface
{
    public interface IRemoveSupression<T> where T : class
    {
        IAddTitle<T> AddTitle();
    }
}