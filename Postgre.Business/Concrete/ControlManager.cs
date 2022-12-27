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
    public class ControlManager : IControlService
    {
        private IControlDal _controlDal; 
        public List<Control> GetAll()
        {
            return _controlDal.GetAll();
        }
    }
}
