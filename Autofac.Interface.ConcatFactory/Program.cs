namespace Autofac.Interface.ConcatFactory
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Demo.Extensions;
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
                new TestIEnumerable { Properties = "prop1", Name = "Dinesh23" },
                new TestIEnumerable { Properties = "prop1", Name = "Dinesh24" },
                new TestIEnumerable { Properties = "prop2", Name = "Dinesh25" },
                new TestIEnumerable { Properties = "prop2", Name = "Dinesh26" }
            };
            return await Task.FromResult(testIEnumerables);
        }
        static async Task Main()
        {
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