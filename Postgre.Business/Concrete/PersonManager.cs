using Postgre.DataAccess.Concrete;
using Postgre.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Postgre.Business.Concrete
{
    public class PersonManager : IPersonService
    {
        private IPersonDal _personDal;

        public PersonManager(IPersonDal personDal)
        {
            this._personDal = personDal;
        }

        public void Add(Person person)
        {
            throw new NotImplementedException();
        }

        public void Delete(Person person)
        {
            throw new NotImplementedException();
        }

        public Person Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Person> GetAll()
        {
            return _personDal.GetAll();
        }

        public void Update(Person person)
        {
            throw new NotImplementedException();
        }
    }
}
