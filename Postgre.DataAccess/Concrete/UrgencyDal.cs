using Postgre.DataAccess.Abstract;
using Postgre.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Postgre.DataAccess.Concrete
{
    public class UrgencyDal : PostgreEntityRepositoryBase<Urgency,PostgreContext>, IUrgencyDal
    {
    }
}
