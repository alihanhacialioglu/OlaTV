using DataAccessLayer.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        OlaTvDBContext context = new OlaTvDBContext();

        DbSet<T> _objects;

        public GenericRepository()
        {
            _objects = context.Set<T>();
        }

        public void Add(T entity)
        {
            _objects.Add(entity);
            context.SaveChanges();
        }

        public void Update(T entity)
        {
            _objects.Update(entity);
            context.SaveChanges();
        }

        public void Delete(T entity)
        {
            _objects.Remove(entity);
            context.SaveChanges();
        }

        public List<T> GetAll(Expression<Func<T, bool>> filter = null)
        {
            return filter == null
                ? _objects.ToList()
                : _objects.Where(filter).ToList();
        }

        public T Get(Expression<Func<T, bool>> filter)
        {
            return _objects.SingleOrDefault(filter);
        }
    }
}

