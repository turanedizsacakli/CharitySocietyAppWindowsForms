using Postgre.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Postgre.Business.Abstract
{
    public interface ICategoryService : IServiceRepository<Category>
    {
        List<Person> GetByCategoryId(int categoryId);
    }
}
