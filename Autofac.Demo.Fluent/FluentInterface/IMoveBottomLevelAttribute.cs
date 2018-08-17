namespace Autofac.Demo.Fluent.FluentInterface
{
    public interface IMoveBottomLevelAttribute<T> where T : class
    {
        IRemoveDuplicates<T> RemoveDuplicates();
    }
}