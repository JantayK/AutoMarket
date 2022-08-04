using AutoMarket.BLL.Dtos.CarCharacteristics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMarket.BLL.Services
{
    /// <summary>
    /// Интерфейс для сервиса Характеристик машины
    /// </summary>
    public interface ICarCharacteristicsService
    {
        public Task<CarCharacteristicsDto> CreateAsync(CarCharacteristicsDto carCharacteristicsDto);
        public void Edit(CarCharacteristicsDto carCharacteristicsDto);
        public void Delete(CarCharacteristicsDto carCharacteristicsDto);
    }
}
