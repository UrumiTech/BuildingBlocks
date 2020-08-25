namespace BuildingBlocks.Filters.Contracts
{
    public interface IBasicFilter 
    {
        #region Public Properties

        int? Page { get; set; }
        int? Size { get; set; }
        bool? IncludeAll { get; set; }

        #endregion Public Properties
    }
}