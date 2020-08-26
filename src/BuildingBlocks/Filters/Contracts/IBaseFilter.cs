namespace BuildingBlocks.Filters.Contracts
{
    public interface IBaseFilter<T> : IBasicFilter where T:struct
    {
        #region Public Properties

        T? Id { get;set; }

        #endregion Public Properties
    }
}