using System.Collections.Generic;

namespace BuildingBlocks.Dto
{
    public class PaginatedResponse<T>
    {
        public PaginatedResponse()
        {
            
        }
        public PaginatedResponse(int count, ICollection<T> data)
        {
            TotalCount = count;
            Data = data;
        }
        public int TotalCount { get; set; }
        public ICollection<T> Data { get; set; }
    }
}
