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
    public class SliderManager : ISliderService
    {
        private readonly ISliderDAL _sliderdal;

        public SliderManager(ISliderDAL sliderdal)
        {
            _sliderdal = sliderdal;
        }

        public void TDelete(int id)
        {
            _sliderdal.Delete(id);
        }

        public List<Slider> TGetAll()
        {
          return _sliderdal.GetAll();
        }

        public Slider TGetByİd(int id)
        {
            return _sliderdal.GetByİd(id);
        }

        public void TInsert(Slider entity)
        {
           _sliderdal.Insert(entity);
        }

        public void TUpdate(Slider entity)
        {
           _sliderdal.Update(entity);
        }
    }
}
