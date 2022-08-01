using AutoMarket.DAL.Interfaces;
using AutoMarket.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMarket.DAL.Data
{
    /// <summary>
    /// Generic Repository
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Repository<T> : IRepository<T>
                where T : class, IEntity<int>
    {
        private readonly ApplicationDbContext _context;
        private DbSet<T> _set;
        public Repository(ApplicationDbContext context)
        {
            _context = context;
            _set = _context.Set<T>();
        }

        public async Task<T> CreateAsync(T model)
        {
            if (model == null)
            {
                return null;
            }

            await _set.AddAsync(model);
            return model; ;
        }

        public void Delete(T model)
        {
            if (_set.Any(x => x.Id == model.Id))
            {
                _set.Remove(model);
            }
        }

        public void Edit(T model)
        {
            if (_set.Any(x => x.Id == model.Id))
            {
                _set.Update(model);
            }
        }

        public async Task<List<T>> GetAsync(Func<T, bool> predicate = null)
        {
            var items = _set.AsQueryable();
            if(predicate != null)
            {
                items = items.Where(predicate).AsQueryable();
            }
            return await items.ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _set.FindAsync(id);
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
