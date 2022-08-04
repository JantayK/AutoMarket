using AutoMarket.BLL.Dtos.Brand;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMarket.BLL.Services
{
    /// <summary>
    /// Интерфейс для сервиса Марки(Брэнда)
    /// </summary>
    public interface IBrandService
    {
        public Task<BrandDto> CreateAsync(BrandDto brandDto);
        public void Edit(BrandDto brandDto);
        public void Delete(BrandDto brandDto);
        public Task<List<BrandDto>> GetAllAsync();
        public Task<BrandDto> GetByNameAsync(int id);
    }
}
