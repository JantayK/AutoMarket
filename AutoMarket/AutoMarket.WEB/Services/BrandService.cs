using AutoMapper;
using AutoMarket.BLL.Dtos.Brand;
using AutoMarket.DAL.Data;
using AutoMarket.DAL.Models;
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

        /// <summary>
        /// Добавление Марки машины
        /// </summary>
        /// <param name="brandDto"></param>
        /// <returns></returns>
        public async Task<BrandDto> CreateAsync(BrandDto brandDto)
        {
            var brand = _mapper.Map<Brand>(brandDto);
            var addedBrand = await _uow.BrandRepository.CreateAsync(brand);
            await _uow.BrandRepository.SaveAsync();
            var result = _mapper.Map<BrandDto>(addedBrand);
            return result;
        }

        /// <summary>
        /// Удаление марки машины
        /// </summary>
        /// <param name="brandDto"></param>
        public void Delete(BrandDto brandDto)
        {
            var brand = _mapper.Map<Brand>(brandDto);
            _uow.BrandRepository.Delete(brand);
            _uow.Save();
        }

        /// <summary>
        /// Изменение Марки машины
        /// </summary>
        /// <param name="brandDto"></param>
        public void Edit(BrandDto brandDto)
        {
            var brand = _mapper.Map<Brand>(brandDto);
            _uow.BrandRepository.Edit(brand);
            _uow.Save();
        }

        /// <summary>
        /// Получение всех Марок машин
        /// </summary>
        /// <returns></returns>
        public async Task<List<BrandDto>> GetAllAsync()
        {
            var list = await _uow.BrandRepository.GetAsync();
            var result = _mapper.Map<List<BrandDto>>(list);
            return result;
        }

        /// <summary>
        /// Получение марок машин по Названию
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public async Task<BrandDto> GetByNameAsync(int id)
        {
            var brand = await _uow.BrandRepository.GetByIdAsync(id);
            var result = _mapper.Map<BrandDto>(brand);
            return result;
        }
    }
}
