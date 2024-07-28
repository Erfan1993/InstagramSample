using System.ComponentModel.DataAnnotations.Schema;

namespace Entity;
public class Comment : ExtraEntity
{
    public string CommentText { get; set; }

    //[ForeignKey(nameof(UserID))]
    //public Guid UserID { get; set; }

    //[ForeignKey(nameof(PostID))]
    //public Guid PostID { get; set; }
}
