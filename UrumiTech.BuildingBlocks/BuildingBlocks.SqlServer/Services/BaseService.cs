using System;
using System.Linq;
using System.Threading.Tasks;
using BuildingBlocks.SqlServer.Helpers;
using Phm.MobileSp.BuildingBlocks.Contracts.Entities;
using BuildingBlocks.SqlServer.Services.Contracts;
using Microsoft.EntityFrameworkCore;

namespace BuildingBlocks.SqlServer.Services
{
    public abstract class BaseService<TEntity, TId> : IBaseService<TEntity, TId>
        where TEntity : class, IBasicEntity<TId>, new()
        where TId : struct, IEquatable<TId>
    {
        protected readonly DbContext Context;


        protected BaseService(DbContext context)
        {
            Context = context;

        }
        public virtual async Task<TId> Add(TEntity entity)
        {
            Context.Set<TEntity>().Add(entity);
            await Context.SaveChangesAsync();
            return await Task.FromResult(entity.Id);
        }

        public virtual async Task<bool> Edit(TEntity entity, TId id)
        {
            if (!entity.Id.Equals(id))
                return await Task.FromResult(false);
            var element = await GetById(id);
            if (element == null)
                return await Task.FromResult(false);

            Context.Entry(element).CurrentValues.SetValues(entity);
            await Context.SaveChangesAsync();
            return await Task.FromResult(true);
        }
        public virtual async Task<TEntity> GetById(TId id, bool includeAll = false, bool tracking = false)
        {
            var elements = Context.Set<TEntity>().AsQueryable();

            if (!tracking)
            {
                elements = elements.AsNoTracking();
            }

            elements = elements.Where(o => o.Id.Equals(id));

            if (includeAll)
            {
                return await elements.FirstOrDefaultAsync();
            }

            return await elements.FirstOrDefaultAsync();
        }

        public virtual async Task<bool> HardDelete(TId id)
        {
            Context.Remove(Context.FindTracked<TEntity>(id) ?? new TEntity { Id = id });
            await Context.SaveChangesAsync();
            return await Task.FromResult(true);
        }
    }
}