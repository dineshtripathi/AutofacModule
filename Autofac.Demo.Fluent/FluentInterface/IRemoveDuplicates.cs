namespace Autofac.Demo.Fluent.FluentInterface
{
    public interface IRemoveDuplicates<T> where T : class
    {
        IRemoveSupression<T> RemoveSupressions();
    }
}