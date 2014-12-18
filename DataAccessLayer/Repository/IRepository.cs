using System.Collections.Generic;
using Core;

namespace DataAccessLayer.Repository
{
    public interface IRepository<T> where T : BaseEntity
    {
        void Add(T entity);
        void Remove(T entity);
        void Remove(int id);
        List<T> FindAll();
        T Find(int id);
        void SaveChanges();
        int Count { get;}
    }
}
