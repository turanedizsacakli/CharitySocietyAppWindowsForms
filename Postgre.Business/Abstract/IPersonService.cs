using Postgre.Entities.Concrete;
using System.Collections.Generic;

namespace Postgre.Business.Concrete
{
    public interface IPersonService
    {
        List<Person> GetAll();
        //Person Get(int id);
    }
}