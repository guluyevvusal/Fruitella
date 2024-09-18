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
    public class ReviewManager : IReviewService
    {
        private readonly IReviewDAL _reviewdal;

        public ReviewManager(IReviewDAL reviewdal)
        {
            _reviewdal = reviewdal;
        }

        public void TDelete(int id)
        {
            _reviewdal.Delete(id);
        }

        public List<Review> TGetAll()
        {
           return _reviewdal.GetAll();
        }

        public Review TGetByİd(int id)
        {
            return _reviewdal.GetByİd(id);
                
        }

        public void TInsert(Review entity)
        {
          _reviewdal.Insert(entity);
        }

        public void TUpdate(Review entity)
        {
            _reviewdal.Update(entity);
        }
    }
}
