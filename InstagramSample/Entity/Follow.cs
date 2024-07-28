using System.ComponentModel.DataAnnotations.Schema;

namespace Entity
{
    public class Follow : ExtraEntity
    {
        public Guid FollowerId { get; set; }
        public Guid UserId { get; set; }
        public Guid FollowedUserId { get; set; }

        [ForeignKey("UserId")]
        [InverseProperty("Followings")]
        public User User { get; set; }

        [ForeignKey("FollowedUserId")]
        [InverseProperty("Followers")]
        public User FollowedUser { get; set; }
    }
}
