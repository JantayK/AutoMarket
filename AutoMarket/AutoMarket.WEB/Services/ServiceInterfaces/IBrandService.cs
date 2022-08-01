using AutoMarket.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMarket.BLL.Services
{
    public interface IBrandService
    {
        public Task<Brand> CreateAsync(Brand brand);
        public void Edit(Brand brand);
        public void Delete(Brand brand);
        public Task<List<Brand>> GetAllAsync();
        public Task<Brand> GetByNameAsync(string name);
    }
}
