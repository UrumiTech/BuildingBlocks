namespace BuildingBlocks.Filters
{
    public interface IBaseFilter<T> :IBasicFilter where T:struct
    {
        #region Public Properties

        public T? Id { get;set; }

        #endregion Public Properties
    }
}