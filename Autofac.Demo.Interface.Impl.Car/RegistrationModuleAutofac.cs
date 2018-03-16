namespace Autofac.Demo.Interface.Impl.Car
{
    public class RegistrationModuleAutofac : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<CarConcat>().AsImplementedInterfaces().SingleInstance()
                .PropertiesAutowired();
        }
    }
}