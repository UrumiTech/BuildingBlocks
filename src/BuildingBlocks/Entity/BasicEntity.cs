using System;
using System.ComponentModel.DataAnnotations;
using BuildingBlocks.Contracts.Entities;

namespace BuildingBlocks.Entity
{
    public abstract class BasicEntity<T> : IBasicEntity<T> where T : IEquatable<T>, new()
    {
        protected BasicEntity()
        {
            Id = new T();
        }
        protected BasicEntity(IBasicEntity<T> obj)
        {
            Id = obj.Id;
        }


        public virtual void PrepareForUpdate(BasicEntity<T> incomingObj)
        {
            Id = incomingObj.Id;
        }

        [Key]
        public T Id { get; set; }


    }
}
