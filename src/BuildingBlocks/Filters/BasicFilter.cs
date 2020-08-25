using BuildingBlocks.Filters.Contracts;

namespace BuildingBlocks.Filters
{
    public class BasicFilter : IBasicFilter
    {
        public int? Page { get; set; }
        public int? Size { get; set; }
        public bool? IncludeAll { get; set; }
    }
}