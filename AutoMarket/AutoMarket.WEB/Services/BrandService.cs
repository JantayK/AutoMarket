using AutoMapper;
using AutoMarket.BLL.Dtos.Brand;
using AutoMarket.DAL.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMarket.BLL.Services
{
    /// <summary>
    /// Сервис Марки Машины
    /// </summary>
    public class BrandService : IBrandService
    {
        private readonly UnitOfWork _uow;
        private readonly IMapper _mapper;
        public BrandService(UnitOfWork uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }
        public async Task<BrandDto> CreateAsync(BrandDto brandDto)
        {
            throw new NotImplementedException();
        }

        public void Delete(BrandDto brandDto)
        {
            throw new NotImplementedException();
        }

        public void Edit(BrandDto brandDto)
        {
            throw new NotImplementedException();
        }

        public async Task<List<BrandDto>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<BrandDto> GetByNameAsync(string name)
        {
            throw new NotImplementedException();
        }
    }
}
