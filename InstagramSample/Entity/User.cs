using System.ComponentModel.DataAnnotations.Schema;

namespace Entity;
public class User : ExtraEntity
{
    public UserType Type { get; set; } = default!;
    public string UserName { get; set; } = default!;
    public string Name { get; set; } = default!;
    public string Family { get; set; } = default!;
    public string Password { get; set; } = default!;
    public string Email { get; set; } = default!;
    public string PhoneNumber { get; set; } = default!;
    public string ProfilePhoto { get; set; } = default!;
    public bool IsConfirmed { get; set; } = default!;
    public string Bio { get; set; } = default!;
    public List<Post> Posts { get; set; }
    public Comment Comment { get; set; }

    [InverseProperty("FollowedUser")]
    public ICollection<Follow> Followers { get; set; }

    [InverseProperty("User")]
    public ICollection<Follow> Followings { get; set; }

}