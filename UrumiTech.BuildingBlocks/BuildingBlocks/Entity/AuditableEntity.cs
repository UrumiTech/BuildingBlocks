using System;
using Phm.MobileSp.BuildingBlocks.Contracts;
using Phm.MobileSp.BuildingBlocks.Contracts.Entities;

namespace BuildingBlocks.Entity
{
    public abstract class AuditableEntity<T> : BasicEntity<T>, IAuditableEntity<T> where T : IEquatable<T>, new()
    {
        public DateTime? CreatedAt { get; set; }

        public DateTime? DeletedAt { get; set; }

        public DateTime? UpdatedAt { get; set; }
        

        public virtual bool Equals(BaseEntity<T> other)
        {
            return Id.Equals(other.Id);
        }

        public virtual void PrepareForUpdate(IAuditableEntity<T> incomingObj)
        {
            DeletedAt = incomingObj.DeletedAt;
            Id = incomingObj.Id;
            UpdatedAt = incomingObj.UpdatedAt;

        }

    }
}