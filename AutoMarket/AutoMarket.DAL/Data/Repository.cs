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

        /// <summary>
        /// Создание Объекта
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public async Task<T> CreateAsync(T model)
        {
            if (model == null)
            {
                return null;
            }

            try
            {
                await _set.AddAsync(model);
            }
            catch (Exception ex)
            {
                throw;
            }

            return model;
        }

        /// <summary>
        /// Удаление Объекта
        /// </summary>
        /// <param name="model"></param>
        public void Delete(T model)
        {
            if (_set.Any(x => x.Id == model.Id))
            {
                _set.Remove(model);
            }
        }

        /// <summary>
        /// Изменение Объекта
        /// </summary>
        /// <param name="model"></param>
        public void Edit(T model)
        {
            if (_set.Any(x => x.Id == model.Id))
            {
                _set.Update(model);
            }
        }

        /// <summary>
        /// Получение всех Объектов
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        public async Task<List<T>> GetAsync(Func<T, bool> predicate = null)
        {
            var items = _set.AsQueryable();
            if (predicate != null)
            {
                items = items.Where(predicate).AsQueryable();
            }
            return await items.ToListAsync();
        }

        /// <summary>
        /// Получение одного объекта по Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<T> GetByIdAsync(int id)
        {
            return await _set.FindAsync(id);
        }

        /// <summary>
        /// Сохранение изменений
        /// </summary>
        /// <returns></returns>
        public async Task SaveAsync()
        {
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
