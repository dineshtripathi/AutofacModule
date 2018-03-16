namespace Autofac.Demo.Model
{
    public class ModelSupplier : ModelAbstract
    {
        public ModelSupplier()
        {
            
        }
        public override string GenerateModel()
        {
            return "MyModelSupplier";
        }
    }
}