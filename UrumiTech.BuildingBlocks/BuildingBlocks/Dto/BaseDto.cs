using System;
using BuildingBlocks.Dto.Contracts;

namespace Phm.MobileSp.BuildingBlocks.Dto
{
    public class BaseDto<T> : AuditableDto<T>, IBaseDto<T>
    {
        #region Public Constructors

        public BaseDto()
        {
            CreatedAt = DateTime.UtcNow;
            UpdatedAt = DateTime.UtcNow;
            Enabled = true;
        }

        public BaseDto(BaseDto<T> obj)
        {
            CreatedAt = DateTime.UtcNow;
            UpdatedAt = DateTime.UtcNow;
            Enabled = obj.Enabled;
            Published = obj.Published;
            MasterId = obj.MasterId;
            DeletedAt = obj.DeletedAt;
            Id = obj.Id;
        }

        #endregion Public Constructors

        #region Public Properties
        public bool Enabled { get; set; }
        public Guid? MasterId { get; set; }
        public bool Published { get; set; }




        #endregion Public Properties
    }
}