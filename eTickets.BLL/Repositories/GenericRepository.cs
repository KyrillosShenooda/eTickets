using eTickets.BLL.Interfaces;
using eTickets.DAL.Context;
using eTickets.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eTickets.BLL.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
    {
        private readonly eTicketsDbContext _context;

        public GenericRepository(eTicketsDbContext context)
        {
            _context = context;
        }

        public T GetById(int? id)
            => _context.Set<T>().Find(id);

        public IEnumerable<T> GetAll()
            => _context.Set<T>().ToList();

        public int Add(T entity)
        {
            _context.Set<T>().Add(entity);
            return _context.SaveChanges();
        }

        public int Update(T entity)
        {
            _context.Set<T>().Update(entity);
            return _context.SaveChanges();
        }

        public int Delete(T entity)
        {
            _context.Set<T>().Remove(entity);
            return _context.SaveChanges();
        }
    }
}
