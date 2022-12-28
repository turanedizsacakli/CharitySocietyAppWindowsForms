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

        public ControlManager(IControlDal controlDal)
        {
            _controlDal = controlDal;   
        }

        public void Update(Control control)
        {
            _controlDal.Update(control);
        }

        public List<Control> GetAll()
        {
            return _controlDal.GetAll();
        }

        public void Add(Control entity)
        {
            _controlDal.Add(entity);
        }

        public void Delete(Control entity)
        {
            _controlDal.Delete(entity);
        }

        public Control Get(int id)
        {
            throw new NotImplementedException();
        }
    }
}
