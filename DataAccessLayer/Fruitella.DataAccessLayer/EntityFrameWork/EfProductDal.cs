using Fruitella.DataAccessLayer.Abstract;
using Fruitella.DataAccessLayer.Context;
using Fruitella.DataAccessLayer.Repository;
using Fruitella.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fruitella.DataAccessLayer.EntityFrameWork
{
    public class EfProductDal : GenericRespository<Product>, IProductDAL
    {
        private readonly FruitellaContext _context;

        public EfProductDal(FruitellaContext context) : base(context)
        {
            _context = context;
        }


        public List<Product> ProductListWithCategory()
        {
            var values = _context.Products.Include(x=>x.Category).ToList();
            return values;
        }
    }
}
