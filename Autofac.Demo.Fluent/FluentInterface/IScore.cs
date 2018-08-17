namespace Autofac.Demo.Fluent.FluentInterface
{
    public interface IScore<T> where T : class
    {
        IMoveBottomLevelAttribute<T> MoveBottomLevelAttributes();
    }
}