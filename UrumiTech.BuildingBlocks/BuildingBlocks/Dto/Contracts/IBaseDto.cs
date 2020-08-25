using System;

namespace BuildingBlocks.Dto.Contracts
{
    public interface IBaseDto<T>
    {
        public bool Enabled { get; set; }
        public Guid? MasterId { get; set; }
        public bool Published { get; set; }
    }
}