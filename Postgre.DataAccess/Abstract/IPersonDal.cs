using Postgre.DataAccess.Abstract;
using Postgre.Entities.Concrete;
using System.Collections.Generic;

namespace Postgre.DataAccess.Concrete
{
    public interface IPersonDal:IEntityRepository<Person>
    {
        
    }

}