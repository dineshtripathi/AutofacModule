namespace Autofac.Demo.Fluent.FluentInterface
{
    public class RemoveDuplicates<T> : IRemoveDuplicates<T> where T : class
    {
        #region Implementation of IRemoveDuplicates<T>

        public IRemoveSupression<T> RemoveSupressions()
        {
            return null;
        }

        #endregion
    }
}