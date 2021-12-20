using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Models.Repositories
{
   public interface IBookstoreRepository<T>
    {
        IList<T> FindAll();
        T Find(int id);
        void Add(T t);
        void Update(int id,T t);
        void Delete(int id);

    }
}
