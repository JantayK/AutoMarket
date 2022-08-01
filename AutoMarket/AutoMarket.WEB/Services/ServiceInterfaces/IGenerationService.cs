using AutoMarket.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMarket.BLL.Services
{
    public interface IGenerationService
    {
        public Task<Generation> CreateAsync(Generation generation);
        public void Edit(Generation generation);
        public void Delete(Generation generation);
        public Task<List<Generation>> GetAllAsync();
        public Task<Generation> GetByBodyNameAsync();
    }
}
