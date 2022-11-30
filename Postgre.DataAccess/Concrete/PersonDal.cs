using Postgre.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Postgre.DataAccess.Concrete
{
    public class PersonDal : IPersonDal
    {
        public List<Person> GetAll()
        {
            using (PostgreContext context = new PostgreContext())
            {
                return context.People.ToList();
            }
        }
    }
}
