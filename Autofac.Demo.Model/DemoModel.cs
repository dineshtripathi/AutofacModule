namespace Autofac.Demo.Model
{
    using System.Diagnostics;

    public class DemoModel
    {
        [DebuggerDisplay("DemoName={DemoName}, Name={DemoName}")]
        public string DemoName { get; set; }
    }
}
