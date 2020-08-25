using System;
using System.Threading.Tasks;
using AutoMapper;
using BuildingBlocks.Context;
using BuildingBlocks.Services;
using Microsoft.EntityFrameworkCore;
using Phm.MobileSp.BuildingBlocks.Contracts;
using Phm.MobileSp.BuildingBlocks.Contracts.Entities;
using Phm.MobileSp.BuildingBlocks.Services.Contracts;

namespace Phm.MobileSp.BuildingBlocks.Services
{
    public abstract class AuditableEntityService< TEntity, TId> : global::BuildingBlocks.SqlServer.Services.BaseService<TEntity, TId>, global::BuildingBlocks.SqlServer.Services.Contracts.IAuditableEntityService<TEntity, TId>
        where TEntity : class, IAuditableEntity<TId>, new()
        where TId : struct, IEquatable<TId>
    {

        public AuditableEntityService(DbContext context):base(context)
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