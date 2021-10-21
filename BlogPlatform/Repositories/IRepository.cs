using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogPlatform.Repositories
{
    public interface IRepository <T>
    {
        IEnumerable<T> GetAll();       
        
        T GetByID(int id);

        void Create(T obj);

        void Update(T obj);

        void Delete(T obj);
    }
}
