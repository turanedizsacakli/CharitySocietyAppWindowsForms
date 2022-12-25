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
    public class AddressManager : IAddressService
    {
        private IAddressDal _addressDal;

        public AddressManager(IAddressDal addressDal)
        {
            _addressDal = addressDal;
        }

        public void Add(Address entity)
        {
            _addressDal.Add(entity);
        }

        public void Delete(Address entity)
        {
            _addressDal.Delete(entity);
        }

        public Address Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Address> GetAll()
        {
            return _addressDal.GetAll();
        }

        public void Update(Address entity)
        {
            _addressDal.Update(entity);
        }
    }
}
