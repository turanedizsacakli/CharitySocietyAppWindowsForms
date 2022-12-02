using Postgre.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Postgre.Business.Abstract
{
    public interface IServiceRepository<T>
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        T Get(int id);
        List<T> GetAll();
        
    }
}
