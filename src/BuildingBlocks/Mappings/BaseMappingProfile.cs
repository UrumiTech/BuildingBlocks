using System;
using AutoMapper;
using BuildingBlocks.Dto.Contracts;
using BuildingBlocks.Contracts.Entities;

namespace BuildingBlocks.Mappings
{
    public static class BaseMappingHelper
    {
        public static IBasicDto<TId> ToDto<TId>(this IBasicEntity<TId> entity, IMapper mapper) where TId: IEquatable<TId>, new()
        {
            return mapper.Map<IBasicDto<TId>>(entity);
        }

        public static IBasicEntity<TId> ToModel<TId>(this IBasicEntity<TId> entity, IMapper mapper) where TId : IEquatable<TId>, new()
        {
            return mapper.Map<IBasicEntity<TId>>(entity);
        }
    }
}