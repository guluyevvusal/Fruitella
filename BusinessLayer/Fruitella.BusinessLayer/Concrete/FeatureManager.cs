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
    public class FeatureManager : IFeatureService
    {
        private readonly IFeatureDAL _featuredal;

        public FeatureManager(IFeatureDAL featuredal)
        {
            _featuredal = featuredal;
        }

        public void TDelete(int id)
        {
           _featuredal.Delete(id);
        }

        public List<Feature> TGetAll()
        {
           return _featuredal.GetAll();
        }

        public Feature TGetByİd(int id)
        {
            return _featuredal.GetByİd(id);
        }

        public void TInsert(Feature entity)
        {
           _featuredal.Insert(entity);
        }

        public void TUpdate(Feature entity)
        {
           _featuredal.Update(entity);
        }
    }
}
