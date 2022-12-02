using Postgre.Business.Abstract;
using Postgre.Entities.Concrete;
using System.Collections.Generic;

namespace Postgre.Business.Concrete
{
    public interface IPersonService: IServiceRepository<Person>
    {

    }
}