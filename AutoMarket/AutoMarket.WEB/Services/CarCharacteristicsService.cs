using AutoMapper;
using AutoMarket.BLL.Dtos.CarCharacteristics;
using AutoMarket.DAL.Data;
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
        public async Task<CarCharacteristicsDto> CreateAsync(CarCharacteristicsDto carCharacteristicsDto)
        {
            throw new NotImplementedException();
        }

        public void Delete(CarCharacteristicsDto carCharacteristicsDto)
        {
            throw new NotImplementedException();
        }

        public void Edit(CarCharacteristicsDto carCharacteristicsDto)
        {
            throw new NotImplementedException();
        }
    }
}
