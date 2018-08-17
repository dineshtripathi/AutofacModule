namespace Autofac.Demo.Fluent.FluentInterface
{
    public interface IAddTitle<T> where T : class
    {
        IBoostMaths<T> BoostMathsSkills();
    }
}