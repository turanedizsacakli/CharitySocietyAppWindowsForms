using Postgre.Entities.Concrete;
using System.Collections.Generic;

namespace Postgre.Business.Concrete
{
    public interface IPersonService
    {
        void Add(Person person);
        void Update(Person person);
        void Delete(Person person);
        Person Get(int id);
        List<Person> GetAll();
    }
}