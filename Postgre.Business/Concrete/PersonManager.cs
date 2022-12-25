using FluentValidation;
using Postgre.Business.Utilities;
using Postgre.Business.ValidationRules.FluentValidation;
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
            ValidationTool.Validate(new PersonValidator(),person);
            _personDal.Add(person);
        }

        public void Update(Person person)
        {
            _personDal.Update(person);
        }

        public void Delete(Person person)
        {
            try
            {
                _personDal.Delete(person);
            }
            catch 
            {

            }
        }

        public Person Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Person> GetAll()
        {
            return _personDal.GetAll();
        }

        public List<Person> GetByCategoryId(int categoryID)
        {
            return _personDal.GetAll(p => p.CategoryId == categoryID);
        }

        public List<Person> GetByCategoryName(string searchKey)
        {
            return _personDal.GetAll(p => p.Name.ToLower().Contains(searchKey.ToLower()));
        }

        public List<Person> GetByUrgencyId(int urgencyId)
        {
            return _personDal.GetAll(p=> p.UrgencyId== urgencyId);
        }

        //public List<Person> GetByUrgencyName(string searchKey)
        //{
        //    //return _personDal.GetAll(p => p.UrgencyName = searchKey);
        //}
    }
}
