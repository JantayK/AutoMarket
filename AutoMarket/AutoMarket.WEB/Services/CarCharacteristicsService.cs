using AutoMapper;
using AutoMarket.BLL.Dtos.CarCharacteristics;
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
    /// Сервис Характеристик Машины
    /// </summary>
    public class CarCharacteristicsService : ICarCharacteristicsService
    {
        private readonly UnitOfWork _uow;
        private readonly IMapper _mapper;
        public CarCharacteristicsService(UnitOfWork uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }

        /// <summary>
        /// Создание Характеристик машины
        /// </summary>
        /// <param name="carCharacteristicsDto"></param>
        /// <returns></returns>
        public async Task<CarCharacteristicsDto> CreateAsync(CarCharacteristicsDto carCharacteristicsDto)
        {
            var carCharacteristics = _mapper.Map<CarCharacteristics>(carCharacteristicsDto);
            var addedCarCharacteristics = await _uow.CarCharacteristicsRepository.CreateAsync(carCharacteristics);
            await _uow.CarCharacteristicsRepository.SaveAsync();
            var result = _mapper.Map<CarCharacteristicsDto>(addedCarCharacteristics);
            return result;
        }

        /// <summary>
        /// Удаление Характеристик машин
        /// </summary>
        /// <param name="carCharacteristicsDto"></param>
        public void Delete(CarCharacteristicsDto carCharacteristicsDto)
        {
            var carCharacteristics = _mapper.Map<CarCharacteristics>(carCharacteristicsDto);
            _uow.CarCharacteristicsRepository.Delete(carCharacteristics);
            _uow.Save();
        }

        /// <summary>
        /// Изменение характеристик машины
        /// </summary>
        /// <param name="carCharacteristicsDto"></param>
        public void Edit(CarCharacteristicsDto carCharacteristicsDto)
        {
            var carCharacteristics = _mapper.Map<CarCharacteristics>(carCharacteristicsDto);
            _uow.CarCharacteristicsRepository.Edit(carCharacteristics);
            _uow.Save();
        }
    }
}
