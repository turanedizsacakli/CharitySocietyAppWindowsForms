using Postgre.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Postgre.DataAccess.Concrete
{
    public class PersonDal : EntityRepositoryBase<Person,PostgreContext> ,IPersonDal
    {
        //public void Add(Person person)
        //{
        //    using (PostgreContext context = new PostgreContext())
        //    {
        //        context.People.Add(person);
        //        context.SaveChanges();
        //    }
        //}
        //public void Update(Person person)
        //{
        //    //using (PostgreContext context = new PostgreContext())
        //    //{
        //    //    context.People.Update()
        //    //    context.SaveChanges();
        //    //}
        //}
        //public void Delete(Person person)
        //{
        //    using (PostgreContext context = new PostgreContext())
        //    {
        //        context.People.Remove(person);
        //        context.SaveChanges();
        //    }
        //}

        //public Person Get(int id)
        //{
        //    throw new NotImplementedException();
        //}

        //public List<Person> GetAll(Expression<Func<Person, bool>> filter = null)
        //{
        //    //using (PostgreContext context = new PostgreContext())
        //    //{
        //    //    return context.People.ToList(filter);
        //    //}
        //}

        //public Person Get(Expression<Func<Person, bool>> filter)
        //{
        //    //using (PostgreContext context=new PostgreContext())
        //    //{
        //    //    //return context.People.SingleOrDefault ( p=>p.PersonId == id );
        //    //    return context.People.SingleOrDefault(filter);
        //    //}
        //}
    }
}
