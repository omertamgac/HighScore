using HightScore.DAL.Repository.Abstract;
using HightScore.Entities.DbContexts;
using HightScore.Entities.Model.Abstract;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace HightScore.DAL.Repository.Concrete
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        readonly AppDbContext _dbContext;
        readonly DbSet<T> _dbSet;

        public Repository()
        {
            _dbContext = new AppDbContext();
            _dbSet = _dbContext.Set<T>();
        }

        public int Delete(T input)
        {
            throw new NotImplementedException();
        }

        public int DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public T? Get(Expression<Func<T, bool>> predicate = null)
        {
            throw new NotImplementedException();
        }

        public List<T>? GetAll(Expression<Func<T, bool>> predicate = null)
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> GetAllInclude(Expression<Func<T, bool>>? predicate, params Expression<Func<T, object>>[] include)
        {
            throw new NotImplementedException();
        }

        public T? GetById(int id)
        {
            throw new NotImplementedException();
        }

        public int Insert(T input)
        {
            throw new NotImplementedException();
        }

        public int Update(T input)
        {
            throw new NotImplementedException();
        }
    }
}
