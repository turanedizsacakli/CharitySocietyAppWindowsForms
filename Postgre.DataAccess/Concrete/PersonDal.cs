using Postgre.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace Postgre.DataAccess.Concrete
{
    public class PersonDal : IPersonDal
    {
        public void Add(Person person)
        {
            using (PostgreContext context = new PostgreContext())
            {
                context.People.Add(person);
                context.SaveChanges();

            }
        }

        public void Update(Person person)
        {
            //using (PostgreContext context = new PostgreContext())
            //{
            //    List<Person> people= context.People.ToList();
            //    foreach (var person in people)
            //    {
            //        person.
            //    }
            //    //return context.People.
            //}
        }
        public void Delete(Person person)
        {
            using (PostgreContext context = new PostgreContext())
            {
               context.People.Remove(person);
               context.SaveChanges();
            }
        }

        public Person Get(Expression<Func<Person, bool>> filter)
        {
            using (PostgreContext context = new PostgreContext())
            {
                return context.People.SingleOrDefault(filter);
            }
        }

        public List<Person> GetAll(Expression<Func<Person, bool>> filter = null)
        {
            using (PostgreContext context = new PostgreContext())
            {
                return context.People.ToList();
            }
        }
    }
}
