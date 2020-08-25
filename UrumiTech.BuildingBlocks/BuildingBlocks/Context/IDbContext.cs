 System;
 System.Threading.Tasks;
 Microsoft.EntityFrameworkCore;

namespace BuildingBlocks.Context
{
    public interface IDbContext : IDisposable
    {
        DbSet<TEntity> Set<TEntity>() where TEntity : class;

        Task<int> SaveChangesAsync();
        DbContext Instance { get; }
    }
}