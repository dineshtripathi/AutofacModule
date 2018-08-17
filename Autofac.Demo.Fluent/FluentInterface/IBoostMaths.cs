namespace Autofac.Demo.Fluent.FluentInterface
{
    public interface IBoostMaths<T> where T : class
    {
        ICombination<T> CombineAttributes();
    }
}