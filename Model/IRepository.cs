using System.Collections.Generic;

namespace Model
{
    public interface IRepository<T> where T: class
    {
        int Add(T obj);
        void Update(T obj);
        void Remove(int id);
        void Save();
        T Find(int id);
        IEnumerable<T> GetAll();
    }
}