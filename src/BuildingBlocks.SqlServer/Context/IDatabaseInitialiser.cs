using System.Threading.Tasks;

namespace BuildingBlocks.SqlServer.Context
{
    public interface IDatabaseInitialiser
    {
        Task SeedAsync();
    }
}