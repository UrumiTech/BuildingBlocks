using System;
using System.Threading.Tasks;
using BuildingBlocks.Contracts.Entities;
using BuildingBlocks.SqlServer.Services.Contracts;
using Microsoft.EntityFrameworkCore;

namespace BuildingBlocks.SqlServer.Services
{
    public abstract class AuditableEntityService< TEntity, TId> : BaseService<TEntity, TId>, IAuditableEntityService<TEntity, TId>
        where TEntity : class, IAuditableEntity<TId>, new()
        where TId : struct, IEquatable<TId>
    {
        protected AuditableEntityService(DbContext context):base(context)
        {
            
        }

        public virtual async Task<bool> Delete(TId id)
        {
            var entity = await GetById(id);
            if (entity == null)
            {
                return false;
            }

            Context.Remove(entity);
            await Context.SaveChangesAsync();
            return true;
        }
    }
}