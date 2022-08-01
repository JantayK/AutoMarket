using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMarket.DAL.Interfaces
{
    /// <summary>
    /// Интерфейс для Generic Repository
    /// </summary>
    /// <typeparam name="T"></typeparam>
        public interface IRepository<T>
            where T : class
        {
            Task<T> CreateAsync(T model);
            Task<T> GetByIdAsync(int id);
            Task<List<T>> GetAsync(Func<T, bool> predicate = null);
            void Delete(T model);
            void Edit(T model);
            Task SaveAsync();
        }
}
