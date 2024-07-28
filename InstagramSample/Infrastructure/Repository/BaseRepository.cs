using DataLayer.Repository;
using Entity;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Infrastructure.Persistance;
internal abstract class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
{
    protected DbSet<T> _dbSet;
    protected readonly InstagramDBContext _dbContext;
    protected BaseRepository(InstagramDBContext dBContext)
    {
        _dbContext = dBContext;
        _dbSet = _dbContext.Set<T>();
    }

    public T Add(T inModel)
    {
        if (inModel == null)
        {
            throw new System.ArgumentNullException(paramName: nameof(inModel));
        }

        _dbSet.Add(inModel);

        return inModel;
    }

    public T Update(T inModel)
    {
        if (inModel == null)
        {
            throw new System.ArgumentNullException(paramName: nameof(inModel));
        }
        _dbSet.Update(inModel);

        return inModel;

        //Microsoft.EntityFrameworkCore.EntityState
        //	entityState = DatabaseContext.Entry(entity).State;

        //if (entityState == Microsoft.EntityFrameworkCore.EntityState.Detached)
        //{
        //	DbSet.Attach(entity);
        //}

        ////entityState =
        ////	DatabaseContext.Entry(entity).State;

        ////DatabaseContext.Entry(entity).State =
        ////	Microsoft.EntityFrameworkCore.EntityState.Modified;

        ////entityState =
        ////	DatabaseContext.Entry(entity).State;

        //_ =
        //	DatabaseContext.Entry(entity).State;

        //DatabaseContext.Entry(entity).State =
        //	Microsoft.EntityFrameworkCore.EntityState.Modified;

        //_ =
        //	DatabaseContext.Entry(entity).State;
    }

    public T GetById(Guid id)
    {
        var res = _dbSet.Find(id);
        return res;
    }

    public IEnumerable<T> GetAll()
    {
        var res = _dbSet.ToList();
        return res;
    }

    public bool DeleteById(Guid id)
    {
        _dbSet.Remove(GetById(id));
        return true;
    }

    public async Task SaveChangesAsync()
    {
        await _dbContext.SaveChangesAsync();
    }

    public void SaveChanges()
    {
        _dbContext.SaveChanges();
    }

    public async Task<bool> DeleteByIdAsync(Guid id)
    {
        T entity = await GetByIdAsync(id);

        if (entity == null)
        {
            return false;
        }

        await System.Threading.Tasks.Task.Run(() =>
        {
            _dbSet.Remove(entity);
        });

        return true;
    }

    public async Task<T> AddAsync(T inModel)
    {
        throw new NotImplementedException();
    }

    public async Task<T> UpdateAsync(T inModel)
    {
        if (inModel == null)
        {
            throw new System.ArgumentNullException(paramName: nameof(inModel));
        }

        //DbSet.Update(entity);

        await System.Threading.Tasks.Task.Run(() =>
        {
            _dbSet.Update(inModel);
        });

        return inModel;
    }

    public async Task<T> GetByIdAsync(Guid id)
    {
        var res = await _dbSet.FindAsync(id);
        return res;
    }

    public async Task<IEnumerable<T>> GetAllAsync()
    {
        var result = await _dbSet.ToListAsync();
        return result;
    }


}
