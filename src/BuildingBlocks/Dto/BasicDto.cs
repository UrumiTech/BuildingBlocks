﻿using BuildingBlocks.Dto.Contracts;

namespace BuildingBlocks.Dto
{
    public class BasicDto<T>: IBasicDto<T>
    {

        #region Public Constructors

        public BasicDto()
        {

        }
        public BasicDto(BasicDto<T> obj)
        {
            Id = obj.Id;
        }

        #endregion Public Constructors



        #region Public Properties

        public T Id { get; set; }
        

        #endregion Public Properties

    }
}