using System;
using BuildingBlocks.Entity;

namespace BuildingBlocks.Contracts.Entities
{
  public interface IBaseEntity<T> :IAuditableEntity<T> where T : IEquatable<T>,new()
    {
        bool Enabled { get; set; }

        bool Published { get; set; }

        Guid? MasterId { get; set; }

        void PrepareForUpdate(BaseEntity<T> incomingObj);

    }
}