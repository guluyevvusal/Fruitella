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
    public class SocialMediaManager : ISocialMediaService
    {
        private readonly ISocialMediaDAL _socialmedia;

        public SocialMediaManager(ISocialMediaDAL socialmedia)
        {
            _socialmedia = socialmedia;
        }

        public void TDelete(int id)
        {
           _socialmedia.Delete(id); 
        }

        public List<SocialMedia> TGetAll()
        {
          return _socialmedia.GetAll();
        }

        public SocialMedia TGetByİd(int id)
        {
            return _socialmedia.GetByİd(id);
        }

        public void TInsert(SocialMedia entity)
        {
            _socialmedia.Update(entity);
        }

        public void TUpdate(SocialMedia entity)
        {
            _socialmedia.Update(entity);
        }
    }
}
