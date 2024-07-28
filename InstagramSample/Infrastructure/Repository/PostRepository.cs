using DataLayer.Repository;
using Entity;

namespace Infrastructure.Persistance;
internal class PostRepository  :  BaseRepository<Post>, IBaseRepository<Post>, IPostReposiory 
{
    public PostRepository(InstagramDBContext dBContext) : base(dBContext)
    {
    }
}
