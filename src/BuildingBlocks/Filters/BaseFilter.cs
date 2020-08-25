using BuildingBlocks.Filters.Contracts;

namespace BuildingBlocks.Filters
{
    public abstract class BaseFilter<TId> : BasicFilter, IBaseFilter<TId> where TId : struct
    {
        #region Public Properties

        public TId? Id { get; set; }
        public bool IsDeleted { get; set; }
        #endregion Public Properties
    }
}