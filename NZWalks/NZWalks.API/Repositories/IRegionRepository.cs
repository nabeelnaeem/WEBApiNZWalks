using NZWalks.API.Models.Domain;

namespace NZWalks.API.Repositories
{
    public interface IRegionRepository
    {
        Task<List<Region>> GetAllAsync();
        //The Region with this id may not be present in the DB so it may return null
        //That's why we make return type nullable with ?
        Task<Region?> GetByIdAsync(Guid id);
        Task<Region> CreateAsync(Region region);
        //The Region with this id may not be present in the DB so it may return null
        //That's why we make return type nullable with ?
        Task<Region?> UpdateAsync(Guid id, Region region);

        Task<Region?> DeleteAsync(Guid id);
    }
}
