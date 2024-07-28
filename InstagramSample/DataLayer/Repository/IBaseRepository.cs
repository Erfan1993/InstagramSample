using Entity;

namespace DataLayer.Repository;
public interface IBaseRepository<T> where T : BaseEntity
{
    bool DeleteById(Guid id);
    T Add(T inModel);
    T Update(T inModel);
    T GetById(Guid id);
    IEnumerable<T> GetAll();

    Task<bool> DeleteByIdAsync(Guid id);
    Task<T> AddAsync(T inModel);
    Task<T> UpdateAsync(T inModel);
    Task<T> GetByIdAsync(Guid id);
    Task<IEnumerable<T>> GetAllAsync();

    Task SaveChangesAsync();
    void SaveChanges();

}
