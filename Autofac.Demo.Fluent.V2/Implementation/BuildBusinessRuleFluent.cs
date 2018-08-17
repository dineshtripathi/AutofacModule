namespace Autofac.Demo.Fluent.V2
{
    public class BuildBusinessRuleFluent : IBuildBusinessRuleFluent
    {
        #region Implementation of IBuildBusinessRuleFluent

        public BuildBusinessRuleFluent()
        {
            
        }
        public IProvideBusinessRule Create()
        {
            return new BusinessRuleImpl();
        }

        #endregion
    }
}