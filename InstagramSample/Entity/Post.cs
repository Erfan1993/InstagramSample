using System.ComponentModel.DataAnnotations.Schema;

namespace Entity;
public class Post : ExtraEntity
{
    public PostType Type { get; set; }
    
    public int Seen { get; set; }
    public int Like { get; set; }
    public string Description { get; set; }
    public string Url { get; set; }
    public string DateTime { get; set; }

    public User User { get; set; }

    public List<Comment> Comments { get; set; }
}