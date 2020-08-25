using System;
using Phm.MobileSp.BuildingBlocks.Entity;

namespace Phm.MobileSp.BuildingBlocks.Contracts.Entities
{
  public interface IBaseEntity<T> :IAuditableEntity<T> where T : IEquatable<T>,new()
    {
        bool Enabled { get; set; }

        bool Published { get; set; }

        Guid? MasterId { get; set; }

        void PrepareForUpdate(BaseEntity<T> incomingObj);

    }
}