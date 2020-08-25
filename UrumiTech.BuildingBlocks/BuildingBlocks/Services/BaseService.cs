using Phm.MobileSp.BuildingBlocks.Services.Contracts;
using System;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Phm.MobileSp.BuildingBlocks.Context;
using Phm.MobileSp.BuildingBlocks.Contracts.Entities;
using Phm.MobileSp.BuildingBlocks.Helpers;

namespace Phm.MobileSp.BuildingBlocks.Services
{
    public abstract class BaseService<TId, TEntity> : IBaseService<TId, TEntity>
        where TEntity : class, IBasicEntity<TId>, new()
        where TId : struct, IEquatable<TId>
    {
        protected readonly IDbContext Context;
        protected readonly IMapper Mapper;

        protected BaseService(IDbContext context, IMapper mapper)
        {
            Context = context;
            Mapper = mapper;
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
           
            Context.Instance.Entry(element).CurrentValues.SetValues(entity);
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
            Context.Instance.Remove(Context.Instance.FindTracked<TEntity>(id) ?? new TEntity { Id = id });
            await Context.SaveChangesAsync();
            return await Task.FromResult(true);
        }
    }
}