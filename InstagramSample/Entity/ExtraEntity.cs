namespace Entity;
public class ExtraEntity : BaseEntity
{
    public ExtraEntity()
    {
        CreateDate = DateTime.Now;
    }
    public DateTime CreateDate { get; set; }
    public DateTime UpdateUpdate { get; set; }
    public bool IsDelete { get; set; }
}