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
    public class CarCharacteristicsService : ICarCharacteristicsService
    {
        private readonly UnitOfWork _uow;
        private readonly IMapper _mapper;
        public CarCharacteristicsService(UnitOfWork uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }
        public async Task<CarCharacteristics> CreateAsync(CarCharacteristics carCharacteristics)
        {
            throw new NotImplementedException();
        }

        public void Delete(CarCharacteristics carCharacteristics)
        {
            throw new NotImplementedException();
        }

        public void Edit(CarCharacteristics carCharacteristics)
        {
            throw new NotImplementedException();
        }
    }
}
