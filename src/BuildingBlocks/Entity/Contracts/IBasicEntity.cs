using System;

namespace BuildingBlocks.Contracts.Entities
{
    public interface IBasicEntity<T> where T : IEquatable<T>
    {
        T Id { get; set; }
    }
}