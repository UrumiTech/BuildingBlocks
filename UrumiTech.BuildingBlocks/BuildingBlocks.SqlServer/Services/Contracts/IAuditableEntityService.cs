using System;
using System.Threading.Tasks;
using Phm.MobileSp.BuildingBlocks.Contracts.Entities;

namespace BuildingBlocks.SqlServer.Services.Contracts
{
    public interface IAuditableEntityService<TEntity, TId> : IBaseService<TEntity, TId>
        where TEntity : IAuditableEntity<TId> 
        where TId: struct, IEquatable<TId>
    {
        Task<bool> Delete(TId id);
    }
}