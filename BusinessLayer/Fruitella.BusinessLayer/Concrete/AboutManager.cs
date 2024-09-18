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
    public class AboutManager : IAboutService
    {
        private readonly IAboutDAL _aboutdal;

        public AboutManager(IAboutDAL aboutdal)
        {
            _aboutdal = aboutdal;
        }

        public void TDelete(int id)
        {
           _aboutdal.Delete(id);
        }

        public List<About> TGetAll()
        {
            return _aboutdal.GetAll();
        }

        public About TGetByİd(int id)
        {
            return _aboutdal.GetByİd(id);
        }

        public void TInsert(About entity)
        {
           _aboutdal.Insert(entity);
        }

        public void TUpdate(About entity)
        {
           _aboutdal.Update(entity);
        }
    }
}
