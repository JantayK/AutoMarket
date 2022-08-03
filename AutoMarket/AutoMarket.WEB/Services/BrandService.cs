using AutoMapper;
using AutoMarket.DAL.Data;
using AutoMarket.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMarket.BLL.Services
{
    public class BrandService : IBrandService
    {
        private readonly UnitOfWork _uow;
        private readonly IMapper _mapper;
        public BrandService(UnitOfWork uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }
        public async Task<Brand> CreateAsync(Brand brand)
        {
            throw new NotImplementedException();
        }

        public void Delete(Brand brand)
        {
            throw new NotImplementedException();
        }

        public void Edit(Brand brand)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Brand>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<Brand> GetByNameAsync(string name)
        {
            throw new NotImplementedException();
        }
    }
}
