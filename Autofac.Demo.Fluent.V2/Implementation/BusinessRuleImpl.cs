namespace Autofac.Demo.Fluent.V2
{
    public class BusinessRuleImpl : IProvideBusinessRule
    {
        #region Implementation of IBuildBusinessRuleFluent

       
        #endregion

        #region Implementation of IProvideBusinessRule

        public IProvideBusinessRule BuildAttributes()
        {
            return this;
        }

        public IProvideBusinessRule BoostMathsSkills()
        {
            return this;
        }

        public IProvideBusinessRule AverageOutScores()
        {
            return this;
        }

        public IProvideBusinessRule RemoveDuplicates()
        {
            return this;
        }

        public IProvideBusinessRule CombineAttributes()
        {
            return this;
        }

        public IProvideBusinessRule RemoveSupressions()
        {
            return this;
        }

        public IProvideBusinessRule MoveBottomLevelAttributes()
        {
            return this;
        }

        public IProvideBusinessRule AddTitle()
        {
            return this;
        }

        public IProvideBusinessRule GetResults()
        {
            return this;
        }

        #endregion
    }
}