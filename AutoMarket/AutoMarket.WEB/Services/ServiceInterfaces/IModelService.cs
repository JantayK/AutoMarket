using AutoMarket.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMarket.BLL.Services
{
    public interface IModelService
    {
        public Task<Model> CreateAsync(Model model);
        public void Edit(Model model);
        public void Delete(Model model);
        public Task<List<Model>> GetAllAsync();
        public Task<Model> GetByNameAsync(string name);
    }
}
