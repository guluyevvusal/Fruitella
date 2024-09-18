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
    public class CategoryManager : ICategoryService
    {
        private readonly ICategoryDAL _categorydal;

        public CategoryManager(ICategoryDAL categorydal)
        {
            _categorydal = categorydal;
        }

        public void TDelete(int id)
        {
           _categorydal.Delete(id);
        }

        public List<Category> TGetAll()
        {
            return _categorydal.GetAll();
        }

        public Category TGetByİd(int id)
        {
            return _categorydal.GetByİd(id);
        }

        public void TInsert(Category entity)
        {
          _categorydal.Insert(entity);
        }

        public void TUpdate(Category entity)
        {
            _categorydal.Update(entity);
        }
    }
}
