using System.Collections.Generic;

namespace Repository.Repository
{
    public interface IGenericRepository<T>
    {
        T Add(T traveler);

        T Update(T traveler);

        void Remove(int id);

        void Remove(T traveler);

        T Get(int id);

        IList<T> GetAll();

        void SaveChanges();
    }
}