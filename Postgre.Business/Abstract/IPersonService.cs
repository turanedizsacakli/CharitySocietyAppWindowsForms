using Postgre.Business.Abstract;
using Postgre.Entities.Concrete;
using System.Collections.Generic;

namespace Postgre.Business.Concrete
{
    public interface IPersonService : IServiceRepository<Person>
    {
        List<Person> GetByCategoryId(int categoryID);
        List<Person> GetByCategoryName(string searchKey);

        List<Person> GetByUrgencyId(int urgencyId);
       //List<Person> GetByUrgencyName(string searchKey);
    }
}