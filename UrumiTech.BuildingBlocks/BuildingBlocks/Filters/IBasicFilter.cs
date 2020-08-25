namespace Phm.MobileSp.BuildingBlocks.Filters
{
    public interface IBasicFilter 
    {
        #region Public Properties

        public int? Page { get; set; }
        public int? Size { get; set; }
        public bool? IncludeAll { get; set; }

        #endregion Public Properties
    }
}