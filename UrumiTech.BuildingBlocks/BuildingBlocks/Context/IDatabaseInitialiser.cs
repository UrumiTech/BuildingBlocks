 System.Threading.Tasks;

namespace BuildingBlocks.Context
{
    public interface IDatabaseInitialiser
    {
        Task SeedAsync();
    }
}