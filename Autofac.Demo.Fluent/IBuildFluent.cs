namespace Autofac.Demo.Fluent
{
    using FluentInterface;

    public interface IBuildFluent
    {
        IOnetAttributes<T> Create<T>() where T:class;
    }
}