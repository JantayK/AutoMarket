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
        public void Create(Brand brand);
        public void Edit(Brand brand);
        public void Delete(Brand brand);
        public List<Brand> GetAll();
        public Brand GetByName(string name);
    }
}
