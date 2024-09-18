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
    public class ProductManager : IProductService
    {
        private readonly IProductDAL _productdal;

        public ProductManager(IProductDAL productdal)
        {
            _productdal = productdal;
        }

        public void TDelete(int id)
        {
            _productdal.Delete(id);
        }

        public List<Product> TGetAll()
        {
          return _productdal.GetAll();
        }

        public Product TGetByİd(int id)
        {
          return _productdal.GetByİd(id);
        }

        public void TInsert(Product entity)
        {
           _productdal.Insert(entity);
        }

        public void TUpdate(Product entity)
        {
          _productdal.Update(entity);
        }
    }
}
