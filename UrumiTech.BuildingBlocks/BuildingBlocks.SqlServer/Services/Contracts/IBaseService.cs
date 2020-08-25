using System;
using System.Threading.Tasks;
using Phm.MobileSp.BuildingBlocks.Contracts.Entities;

namespace BuildingBlocks.SqlServer.Services.Contracts
{
    public interface IBaseService<TEntity, TId> 
        where TEntity : IBasicEntity<TId> 
        where TId: struct, IEquatable<TId>
    {
        Task<TId> Add(TEntity entity);


        Task<bool> Edit(TEntity entity, TId id);

        Task<TEntity> GetById(TId id, bool includeAll = false, bool tracking = false);

        Task<bool> HardDelete(TId id);
    }
}