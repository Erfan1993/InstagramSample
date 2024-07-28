using DataLayer.Repository;
using Entity;

namespace Infrastructure.Persistance;
internal class UserRepository : BaseRepository<User>, IBaseRepository<User>, IUserRepository
{
    public UserRepository(InstagramDBContext dBContext) : base(dBContext)
    {
    }
}
