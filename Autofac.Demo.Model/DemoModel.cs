using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autofac.Demo.Model
{
    using System.Diagnostics;
    using System.Runtime.CompilerServices;

    public class DemoModel
    {
        [DebuggerDisplay("DemoName={DemoName}, Name={DemoName}")]
        public string DemoName { get; set; }
    }
}
