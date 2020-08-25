using System;

namespace BuildingBlocks.Filters
{
    public abstract class BaseFilter<TId> : IBaseFilter<TId> where TId : struct
    {
        #region Public Properties

        public TId? Id { get; set; }
        public int? Page { get; set; }
        public int? Size { get; set; }
        public bool? IncludeAll { get; set; }
        public bool IsDeleted { get; set; }
        #endregion Public Properties
    }
}