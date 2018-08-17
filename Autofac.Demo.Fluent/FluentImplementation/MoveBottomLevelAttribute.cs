namespace Autofac.Demo.Fluent.FluentInterface
{
    public class MoveBottomLevelAttribute<T> : IMoveBottomLevelAttribute<T> where T : class
    {
        #region Implementation of IMoveBottomLevelAttribute<T>

        public IRemoveDuplicates<T> RemoveDuplicates()
        {
            return null;
        }

        #endregion
    }
}