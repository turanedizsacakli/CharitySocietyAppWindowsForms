using Postgre.Business.Abstract;
using Postgre.DataAccess.Abstract;
using Postgre.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Postgre.Business.Concrete
{
    public class UrgencyManager : IUrgencyService
    {
        private IUrgencyDal _urgencyDal;

        public UrgencyManager(IUrgencyDal urgencyDal)
        {
            _urgencyDal = urgencyDal;
        }

        public List<Urgency> GetAll()
        {
            return _urgencyDal.GetAll();
        }
    }
}
