namespace Autofac.Demo.Model
{
    using System.Collections.Generic;
    using System.Linq;

    public class ModelFeeder
    {
        private readonly IEnumerable<ModelAbstract> _abstraction;

        public ModelFeeder(IEnumerable<ModelAbstract> abstraction)
        {
            this._abstraction = abstraction;
        }

        public IEnumerable<string> FeederResult()
        {
            return _abstraction.Select(feed => feed.GenerateModel());
        }
    }
}