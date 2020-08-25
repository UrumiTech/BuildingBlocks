using System;
using Phm.MobileSp.BuildingBlocks.Contracts;
using Phm.MobileSp.BuildingBlocks.Contracts.Entities;

namespace BuildingBlocks.Entity
{
    public abstract class BaseEntity<T> : AuditableEntity<T>, IBaseEntity<T> where T : IEquatable<T>, new()
    {
        protected BaseEntity()
        {
            Id = new T();
            CreatedAt = DateTime.UtcNow;
            UpdatedAt = DateTime.UtcNow;
            Enabled = true;
            Published = true;
            MasterId = Guid.NewGuid();
        }

        protected BaseEntity(IBaseEntity<T> obj)
        {
            CreatedAt = DateTime.UtcNow;
            UpdatedAt = DateTime.UtcNow;
            Enabled = false;
            Published = false;
            MasterId = obj.MasterId;
            DeletedAt = obj.DeletedAt;
        }

        public bool Enabled { get; set; }

        public bool Published { get; set; }

        public Guid? MasterId { get; set; }

        public override bool Equals(BaseEntity<T> other)
        {
            return Id.Equals(other.Id);
        }

        public virtual void PrepareForUpdate(BaseEntity<T> incomingObj)
        {
            DeletedAt = incomingObj.DeletedAt;
            Enabled = incomingObj.Enabled;
            Id = incomingObj.Id;
            MasterId = incomingObj.MasterId;
            Published = incomingObj.Published;
            UpdatedAt = incomingObj.UpdatedAt;

        }

    }
}
