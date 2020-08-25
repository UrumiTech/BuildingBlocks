 using System;
 using System.Threading.Tasks;
 namespace BuildingBlocks.Context
{
    public interface IDbContext : IDisposable
    {
        DbSet<TEntity> Set<TEntity>() where TEntity : class;

        Task<int> SaveChangesAsync();
        DbContext Instance { get; }
    }
}