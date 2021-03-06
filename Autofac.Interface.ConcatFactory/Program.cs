﻿namespace Autofac.Interface.ConcatFactory
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using System.Web.Configuration;
    using Autofac.Demo.Fluent;
    using Autofac.Demo.Fluent.V2;
    using Castle.Core.Internal;
    using Demo.Extensions;
    using Demo.Fluent.Model;
    using Demo.Fluent.V2.Implementation;
    using Demo.Model;

    class Program
    {
        static async Task<IEnumerable<TestIEnumerable>> GetData()
        {
            var testIEnumerables = new List<TestIEnumerable>
            {
                new TestIEnumerable { Properties = "prop1", Name = "Dinesh" },
                new TestIEnumerable { Properties = "prop1", Name = "Dinesh2" },
                new TestIEnumerable { Properties = "prop1", Name = "Dinesh21" },
                new TestIEnumerable { Properties = "prop1", Name = "Dinesh22" },
                new TestIEnumerable { Properties = "prop1", Name = "" },
                new TestIEnumerable { Properties = "prop1", Name = "" },
                new TestIEnumerable { Properties = "prop2", Name = "Dinesh25" },
                new TestIEnumerable { Properties = "prop2", Name = "Dinesh26" }
            };
            return await Task.FromResult(testIEnumerables);
        }
        static async Task Main()
        {


           // string appRoot = Environment.GetEnvironmentVariable("RoleRoot");


            //V2 with Macro interface ( Not a cleaner way , as the workflow is inconsitent but it works with less code and files
            //var BuildBusinessRule = new BuildBusinessRuleFluent()
            //    .Create()
            //    .RemoveSupressions()
            //    .AddTitle()
            //    .AverageOutScores()
            //    .BoostMathsSkills()
            //    .CombineAttributes()
            //    .MoveBottomLevelAttributes()
            //    .RemoveDuplicates()
            //    .GetResults();
            
            ////V1 Fluent with micro interfaces ( cleaner way and even can be managed and tested in a micro level granluar level
            ////as every chain provides and interface and takes model as a constructor parameter
            //var fluent = new FluentOnetAttributes<AttributeModel>()
            //    .Create<AttributeModel>()
            //    .BuildAttributes()
            //    .AverageOutScores()
            //    .MoveBottomLevelAttributes()
            //    .RemoveDuplicates()
            //    .RemoveSupressions()
            //    .AddTitle()
            //    .BoostMathsSkills()
            //    .CombineAttributes()
            //    .ProcessResults()
            //    .GetResults();
             

            var configuration = WebConfigurationManager.OpenWebConfiguration("../web.config");

            var withempty =await GetData();
            var withoutempty =  GetData().Result.Where(x => !string.IsNullOrEmpty(x.Name));

            ModelAbstract imple = new ModelConsumer();
            imple.GenerateModel();
            var scope = AutoFacContainerConfig.RegisterLifetimeScope();
            {
                using (var resolveEntity = scope.BeginLifetimeScope())
                {
                    var names = new List<string> { "CourseSearchProvider", "LMIProvider", "ApprenticehshipProvider" };

                    var factory = resolveEntity.Resolve<IFactory>();
                    Console.WriteLine(factory.GetType().ToString());
                    var val = string.Empty;
                    var nvVal = (val.Insert(0, names.First(xc => xc.Contains("LMIProvider"))));

                    var feed = resolveEntity.Resolve<ModelAbstract>();
                    var feeder = resolveEntity.Resolve<ModelFeeder>();
                    foreach (var r in feeder.FeederResult())
                    {
                        Console.WriteLine(r);
                    }

                    var returnVal = await factory.GetValueAsync(async i => i + await Task.FromResult(names.First(x1 => x1.Contains("LMIProvider"))), "ConfigureIt").ConfigureAwait(false);
                    Console.WriteLine(returnVal);
                    var valRet = string.Empty;
                    var fun = await factory.GetFunctionAsync(names.First(xc => xc.Contains("LMIProvider")));
                    var funRet = fun(valRet).Result;
                    Console.ReadKey();


                    var enumerable = await GetData().ConfigureAwait(false);
                    foreach (var e in enumerable.WhereCriteria(x => x.Properties == "prop1"))
                    {
                        var retResult = e;
                        Console.WriteLine(e.Properties);
                        Console.ReadKey();
                    }

                }
            }
        }
    }

    public class TestIEnumerable
    {
        public string Properties { get; set; }
        public string Name { get; set; }
    }

}