using DAL.Repositories.Intefaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public abstract class BaseRepository<T> : IRepository<T> where T : class
    {
        protected readonly DbSet<T> _set;
        private readonly DbContext _context;
        public BaseRepository(DbContext context)
        {
            _context = context;
            _set = context.Set<T>();
        }
        public void Create(T item)
        {
            _set.Add(item);
        }
        public void Delete(int id)
        {
            var item = Get(id);
            _set.Remove(item);
        }
        public T Get(int id)
        {
            return _set.Find(id);
        }
        public IEnumerable<T> GetAll()
        {
            return _set.ToList();
        }
        public void Update(T item)
        {
            _context.Entry(item).State = EntityState.Modified;
        }
    }
}
