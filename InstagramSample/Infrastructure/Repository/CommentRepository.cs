using DataLayer.Repository;
using Entity;

namespace Infrastructure.Persistance;
internal class CommentRepository : BaseRepository<Comment>, IBaseRepository<Comment>, ICommentRepository
{
    public CommentRepository(InstagramDBContext dBContext) : base(dBContext)
    {

    }
}
