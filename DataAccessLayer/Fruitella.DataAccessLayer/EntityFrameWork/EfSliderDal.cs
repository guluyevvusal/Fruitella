using Fruitella.DataAccessLayer.Abstract;
using Fruitella.DataAccessLayer.Context;
using Fruitella.DataAccessLayer.Repository;
using Fruitella.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fruitella.DataAccessLayer.EntityFrameWork
{
    public class EfSliderDal : GenericRespository<Slider>, ISliderDAL
    {
        public EfSliderDal(FruitellaContext context) : base(context)
        {
        }
    }
}
