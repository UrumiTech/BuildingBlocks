using System;

namespace Phm.MobileSp.BuildingBlocks.Filters
{
    public class QueryFilter
    {
        #region Public Properties

        public Guid? MarketId { get; set; }
        public bool? OrderByCreatedTime { get; set; }
        public int? Page { get; set; }
        public int? Size { get; set; }

        #endregion Public Properties
    }
}