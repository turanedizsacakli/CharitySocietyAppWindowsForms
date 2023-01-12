using Postgre.DataAccess.Abstract;
using Postgre.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Postgre.DataAccess.Concrete
{
    public class HometownDal: PostgreEntityRepositoryBase<Hometown,PostgreContext>,IHometownDal
    {
    }
}
