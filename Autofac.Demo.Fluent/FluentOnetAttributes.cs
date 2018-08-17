namespace Autofac.Demo.Fluent
{
    using FluentInterface;

    public class FluentOnetAttributes<T> :IBuildFluent where T:class
    {
        private IOnetAttributes<T> Fluent;
        private T Attributes { get; set; }
        public FluentOnetAttributes<T> Create()
        {
            this.Fluent = new OnetAttributes<T>(Attributes);
            return this;
        }


        #region Implementation of IBuildFluent

        public IOnetAttributes<T> Create<T>() where T : class
        {
            return (Autofac.Demo.Fluent.FluentInterface.IOnetAttributes<T>)this.Fluent;
        }

        #endregion
    }
}
