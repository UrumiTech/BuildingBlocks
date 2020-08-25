using System;

namespace Phm.MobileSp.BuildingBlocks.Contracts.Entities
{
    public interface ITimeStampEntity
    {
        DateTime? CreatedAt { get; set; }

        DateTime? DeletedAt { get; set; }

        DateTime? UpdatedAt { get; set; }
    }
}