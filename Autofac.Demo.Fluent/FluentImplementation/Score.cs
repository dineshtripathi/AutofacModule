namespace Autofac.Demo.Fluent.FluentInterface
{
    using Model;

    public class Score<T> : IScore<T> where T : class
    {
        private readonly T Attributes;

        public Score(T attributesElements)
        {
            this.Attributes = attributesElements;
        }
        #region Implementation of IScore<T>

        public IMoveBottomLevelAttribute<T> MoveBottomLevelAttributes()
        {
            return new MoveBottomLevelAttribute<T>();
        }

        #endregion
    }
}