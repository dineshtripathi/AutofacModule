﻿namespace Autofac.Interface.ConcatFactory
{
    using System;
    using Autofac.Demo.Common;
    using Autofac.Demo.Interceptor;
    using BusConcat;
    using Castle.DynamicProxy;
    using Configuration;
    using Demo.Fluent.AutofacConfig;
    using Demo.Interface;
    using Demo.Interface.Impl.Car;
    using Demo.Model;
    using Extras.DynamicProxy;
    using Microsoft.Extensions.Configuration;

    public class AutofacModuleLoader
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="builder"></param>
        public static void Loader(ContainerBuilder builder)
        {
            var config = new ConfigurationBuilder();
            config.AddJsonFile("AutofacConfiguration.json");
            var module = new ConfigurationModule(config.Build());
            
            builder.RegisterModule(module);
            builder.RegisterModule<RegisterFluentModelAutofac>();
        }
    }

    public static class AutoFacContainerConfig
    {
        public static ILifetimeScope RegisterLifetimeScope()
        {
            var builder = new ContainerBuilder();
            RegisterTypeWithContrainer(builder);
            ILifetimeScope containerLifetimeScope = builder.Build();
            return containerLifetimeScope;
        }

        private static void RegisterTypeWithContrainer(ContainerBuilder builder)
        {
            //Register the Log Interceptor, which will log out to the console of the application. Anything registered with 'log-calls' will be intercepted
            builder.Register(c => new LogInterceptor(Console.Out)).AsSelf().Named<IInterceptor>(LogInterceptor.name);

            //Register the repository, make sure 'EnableInterfaceInterceptors' is called, this is important in letting Castle know it has Interceptors


            builder.RegisterType<ConcatFactory>().AsImplementedInterfaces().SingleInstance().EnableInterfaceInterceptors().InterceptedBy(LogInterceptor.name, LogInterceptor.name); 
            builder.RegisterAssemblyTypes(typeof(ModelAbstract).Assembly).Where(t => t.IsSubclassOf(typeof(ModelAbstract))).As<ModelAbstract>();
            builder.RegisterType<BusConcat>().Keyed<IAutoFacDemo>(ViewerType.Bus);
            builder.RegisterType<CarConcat>().Keyed<IAutoFacDemo>(ViewerType.Car);
            AutofacModuleLoader.Loader(builder);
            builder.RegisterType<ModelFeeder>();
        }
    }
}