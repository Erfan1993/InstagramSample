namespace Entity;
public class UserType : ExtraEntity
{
    public string Type { get; set; }
    public List<User> Users { get; set; }
}