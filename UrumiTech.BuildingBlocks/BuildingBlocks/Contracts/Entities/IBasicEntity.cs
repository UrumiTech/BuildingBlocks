using System;

namespace Phm.MobileSp.BuildingBlocks.Contracts.Entities
{
    public interface IBasicEntity<T> where T : IEquatable<T>
    {
        T Id { get; set; }
    }
}