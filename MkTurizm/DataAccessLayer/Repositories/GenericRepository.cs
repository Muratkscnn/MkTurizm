using DataAccessLayer.Abstract;
using System;
using DataAccessLayer.Concrete;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        public void Delete(T t)
        {
            using var c = new MKContext();
            c.Remove(t);
            c.SaveChanges();
        }

        public T GetByID(int id)
        {
            using var c = new MKContext();
            return c.Set<T>().Find(id);
        }

        public List<T> GetListAll()
        {
            using var c = new MKContext();
            return c.Set<T>().ToList();
        }

        public void Add(T t)
        {
            using var c = new MKContext();
            c.Add(t);
            c.SaveChanges();
        }

        public void Update(T t)
        {
            using var c = new MKContext();
            c.Update(t);
            c.SaveChanges();
        }

    }
}
