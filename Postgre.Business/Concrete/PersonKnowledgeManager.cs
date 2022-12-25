using Postgre.Business.Abstract;
using Postgre.DataAccess.Concrete;
using Postgre.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Postgre.Business.Concrete
{
    public class PersonKnowledgeManager : IPersonKnowledgeService
    {
        PersonKnowledgeDal _personKnowledgeDal= new PersonKnowledgeDal();
        public void Add(PersonKnowledge entity)
        {
            _personKnowledgeDal.Add(entity);
        }

        public void Delete(PersonKnowledge entity)
        {
            _personKnowledgeDal.Delete(entity);
        }

        public PersonKnowledge Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<PersonKnowledge> GetAll()
        {
            return _personKnowledgeDal.GetAll();
        }

        public void Update(PersonKnowledge entity)
        {
            _personKnowledgeDal.Update(entity);
        }
    }
}
