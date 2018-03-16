namespace Autofac.Demo.Model
{
    using System;

    public class ModelConsumer : ModelAbstract
    {
        #region Overrides of ModelImplementation

        public ModelConsumer()
        {
            Console.WriteLine( GenerateModel());
        }
        public sealed override string GenerateModel()
        {
            return "MyModelConsumer";
        }

        #endregion
    }
}