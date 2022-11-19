using Postgre.DataAccess.Concrete;
using Postgre.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Postgre.Business.Concrete
{
    public class PersonManager : IPersonManager
    {
        private IPersonDal _personDal;

        public PersonManager(IPersonDal personDal)
        {
            this._personDal = personDal;
        }

        public List<Person> GetAll()
        {
            return _personDal.GetAll();
        }
    }
}
