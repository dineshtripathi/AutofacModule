namespace Autofac.Demo.Fluent.AutofacConfig
{
    using Extras.DynamicProxy;
    using FluentInterface;
    using Model;

    public class RegisterFluentModelAutofac : Module
    {
            protected override void Load(ContainerBuilder builder)
            {
                builder.RegisterAssemblyTypes(ThisAssembly).AsSelf().AsImplementedInterfaces().InstancePerDependency()
                       .PropertiesAutowired();
                builder.RegisterGeneric(typeof(AddTitle<>)).AsSelf().AsImplementedInterfaces().InstancePerLifetimeScope()
                        .InstancePerDependency().PropertiesAutowired().EnableInterfaceInterceptors();
                builder.RegisterGeneric(typeof(AttributeElements<>)).AsSelf().AsImplementedInterfaces().InstancePerLifetimeScope()
                        .PropertiesAutowired().InstancePerDependency().EnableInterfaceInterceptors();
                builder.RegisterGeneric(typeof(BoostMaths<>)).AsSelf().AsImplementedInterfaces().InstancePerLifetimeScope()
                        .PropertiesAutowired().InstancePerDependency().EnableInterfaceInterceptors();
                builder.RegisterGeneric(typeof(Combination<>)).AsSelf().AsImplementedInterfaces().InstancePerLifetimeScope()
                        .PropertiesAutowired().InstancePerDependency().EnableInterfaceInterceptors();
                builder.RegisterGeneric(typeof(Final20Attribute<>)).AsSelf().AsImplementedInterfaces().InstancePerLifetimeScope()
                        .PropertiesAutowired().InstancePerDependency().EnableInterfaceInterceptors();
                builder.RegisterGeneric(typeof(MoveBottomLevelAttribute<>)).AsSelf().AsImplementedInterfaces()
                        .InstancePerLifetimeScope().PropertiesAutowired().InstancePerDependency().EnableInterfaceInterceptors();
                builder.RegisterGeneric(typeof(OnetAttributes<>)).AsSelf().AsImplementedInterfaces().InstancePerLifetimeScope()
                        .PropertiesAutowired().InstancePerDependency().EnableInterfaceInterceptors();
                builder.RegisterGeneric(typeof(RemoveDuplicates<>)).AsSelf().AsImplementedInterfaces().InstancePerLifetimeScope()
                        .PropertiesAutowired().InstancePerDependency().EnableInterfaceInterceptors();
                builder.RegisterGeneric(typeof(Score<>)).AsSelf().AsImplementedInterfaces().InstancePerLifetimeScope()
                        .PropertiesAutowired().InstancePerDependency().EnableInterfaceInterceptors();
                builder.RegisterGeneric(typeof(Supression<>)).AsSelf().AsImplementedInterfaces().InstancePerLifetimeScope()
                        .PropertiesAutowired().InstancePerDependency().EnableInterfaceInterceptors();

            }
        }
}