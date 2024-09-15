using Fruitella.DataAccessLayer.Abstract;
using Fruitella.DataAccessLayer.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fruitella.DataAccessLayer.Repository
{
    public class GenericRespository<T> : IGenericDAL<T> where T : class
    {

        private readonly FruitellaContext _context;

        public GenericRespository(FruitellaContext context)
        {
            _context = context;
        }

        public void Delete(int id)
        {
            var value = _context.Set<T>().Find(id);
            _context.Set<T>().Remove(value);
            _context.SaveChanges();
        }

        public List<T> GetAll()
        {
           return _context.Set<T>().ToList();
        }

        public T GetByİd(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public void Insert(T entity)
        {
           _context.Set<T>().Add(entity);
            _context.SaveChanges();
        }

        public void Update(T entity)
        {
            _context.Set<T>().Update(entity);
            _context.SaveChanges();
        }
    }
}
