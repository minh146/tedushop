using System;
using System.Linq;
using System.Linq.Expressions;

namespace TeduShop.Data.Infrastructure
{
    public interface IRepository<T> where T : class
    {
        //Marks an Entity as new
        void Add(T entity);

        // Marks an Entity as modified
        void Update(T entity);

        //Marks an entity to be removed
        void Delete(T entity);

        //delete multi records
        void DeleteMulti(Expression<Func<T, bool>> where);

        //Get an entity bi int id
        T GetSingleById(int id);

        T GetSingleByCondition(Expression<Func<T, bool>> exception, string[] includes = null);

        IQueryable<T> GetAll(string[] includes = null);

        IQueryable<T> GetMulti(Expression<Func<T, bool>> predicate, string[] includes = null);

        IQueryable<T> GetMultiPaging(Expression<Func<T, bool>> filter, out int total, int index = 0, int size = 50, string[] includes = null);

        int Count(Expression<Func<T, bool>> where);

        bool CheckContains(Expression<Func<T, bool>> predicate);
    }
}