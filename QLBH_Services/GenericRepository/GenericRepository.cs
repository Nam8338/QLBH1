using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using QLBH_DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace QLBH_Services.GenericRepository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {

        protected readonly QLBH_ONLINEContext _context;
        public GenericRepository(QLBH_ONLINEContext context)
        {
            _context = context;
        }
        public void Add(T entity)
        {
            _context.Set<T>().Add(entity);
        }

        public void Delete(T entity)
        {
            _context.Set<T>().Remove(entity);
        }

        public List<T> GetAll()
        {
            List<T> lst = _context.Set<T>().ToList();
            return lst;

        }

        public T GetById(string id)
        {
            T lst = _context.Set<T>().Find(id);
            _context.Entry(lst).State = EntityState.Detached;
            return lst;
        }

        public List<T> Search(Expression<Func<T, bool>> predicate)
        {
           return _context.Set<T>().AsNoTracking().Where(predicate).ToList();
        }

        public void Update(T entity)
        {
            _context.Update(entity);
        }
    }
}
