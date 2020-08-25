using System;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Phm.MobileSp.BuildingBlocks.Context;
using Phm.MobileSp.BuildingBlocks.Contracts;
using Phm.MobileSp.BuildingBlocks.Contracts.Entities;
using Phm.MobileSp.BuildingBlocks.Services.Contracts;

namespace Phm.MobileSp.BuildingBlocks.Services
{
    public abstract class AuditableEntityService<TId, TEntity> : BaseService<TId,TEntity>, IAuditableEntityService<TId, TEntity>
        where TEntity : class, IAuditableEntity<TId>, new()
        where TId : struct, IEquatable<TId>
    {

        public AuditableEntityService(IDbContext context, IMapper mapper):base(context, mapper)
        {
            
        }

        public virtual async Task<bool> Delete(TId id)
        {
            var entity = await GetById(id);
            if (entity == null)
            {
                return false;
            }

            Context.Instance.Remove(entity);
            await Context.SaveChangesAsync();
            return true;
        }
    }
}