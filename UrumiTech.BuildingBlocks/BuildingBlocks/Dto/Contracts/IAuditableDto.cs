using System;
using Phm.MobileSp.BuildingBlocks.Contracts.Entities;

namespace BuildingBlocks.Dto.Contracts
{
    public interface IAuditableDto<T> : IBasicDto<T>, ITimeStampEntity where T : IEquatable<T>, new()
    {
      
    }
}