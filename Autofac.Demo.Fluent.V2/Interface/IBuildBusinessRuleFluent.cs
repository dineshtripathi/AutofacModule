using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autofac.Demo.Fluent.V2
{
    using System.Dynamic;

    public interface IBuildBusinessRuleFluent
    {
        IProvideBusinessRule Create();
    }
}
