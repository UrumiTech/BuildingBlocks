using System;
using AutoMapper;
using BuildingBlocks.Dto.Contracts;
using Phm.MobileSp.BuildingBlocks.Contracts;
using Phm.MobileSp.BuildingBlocks.Contracts.Entities;
using Phm.MobileSp.BuildingBlocks.Dto;
using Phm.MobileSp.BuildingBlocks.Entity;

namespace Phm.MobileSp.BuildingBlocks.Mappings
{
    public static class BaseMappingHelper
    {
        public static IBasicDto<TId> ToDto<TId>(this IBasicEntity<TId> entity, IMapper mapper) where TId: IEquatable<TId>, new()
        {
            return mapper.Map<IBasicDto<TId>>(entity);
        }
    }
}