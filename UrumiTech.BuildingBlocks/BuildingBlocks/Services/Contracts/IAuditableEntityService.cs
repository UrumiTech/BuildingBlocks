using System;
using System.Threading.Tasks;
using Phm.MobileSp.BuildingBlocks.Contracts;
using Phm.MobileSp.BuildingBlocks.Contracts.Entities;

namespace Phm.MobileSp.BuildingBlocks.Services.Contracts
{
    public interface IAuditableEntityService<TId, TEntity> :IBaseService<TId, TEntity>
        where TEntity : IAuditableEntity<TId> 
        where TId: struct, IEquatable<TId>
    {
        Task<bool> Delete(TId id);
    }
}