using System;
using BuildingBlocks.Contracts.Entities;

namespace BuildingBlocks.Dto
{
    public class AuditableDto<T> : BasicDto<T>, ITimeStampEntity
    {
        public AuditableDto()
        {
            CreatedAt = DateTime.UtcNow;
            UpdatedAt = DateTime.UtcNow;
           
        }

        public AuditableDto(AuditableDto<T> obj)
        {
            CreatedAt = DateTime.UtcNow;
            UpdatedAt = DateTime.UtcNow;
            DeletedAt = obj.DeletedAt;
            Id = obj.Id;
        }

        public DateTime? CreatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}