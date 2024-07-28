using DataLayer.Repository;
using Entity;

namespace Infrastructure.Persistance;
internal class FollowRepository : BaseRepository<Follow>, IBaseRepository<Follow>, IFollowRepository
{
    public FollowRepository(InstagramDBContext dBContext) : base(dBContext)
    {

    }
}
