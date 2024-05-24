using DataAccess.Abstract;
using DataAccess.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class GenericRepository<T> : IGeneric<T> where T : class
    {
     

        public void Delete(T t)
        {
            using var c = new Context();
            c.Remove(t);
            c.SaveChanges();
        }

        public List<T> GetAll()
        {
			using var c = new Context();
			return c.Set<T>().ToList();

        }

        public T GetById(int id)
        {
			using var c = new Context();
			return c.Set<T>().Find(id);
        }

        public void Insert(T t)
        {
			using var c = new Context();
			c.Add(t);
            c.SaveChanges();
        }

        public void Update(T t)
        {
			using var c = new Context();
			
            c.Update(t).State = EntityState.Modified;
            c.SaveChanges();
        }
    }
}
