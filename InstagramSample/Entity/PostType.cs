namespace Entity;
public class PostType : ExtraEntity
{
    public string Type { get; set; }
    public List<Post> Posts { get; set; }
}