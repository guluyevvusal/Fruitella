using Fruitella.BusinessLayer.Abstract;
using Fruitella.DataAccessLayer.Abstract;
using Fruitella.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fruitella.BusinessLayer.Concrete
{
    public class AddressManager : IAddressService
    {

        private readonly IAddressDAL _addressdal;

        public AddressManager(IAddressDAL addressdal)
        {
            _addressdal = addressdal;
        }

        public void TDelete(int id)
        {
          _addressdal.Delete(id);
        }

        public List<Address> TGetAll()
        {
          return _addressdal.GetAll();
        }

        public Address TGetByİd(int id)
        {
         return _addressdal.GetByİd(id);
        }

        public void TInsert(Address entity)
        {
           _addressdal.Insert(entity);
        }

        public void TUpdate(Address entity)
        {
            _addressdal.Update(entity);
        }
    }
}
