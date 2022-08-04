using AutoMapper;
using AutoMarket.BLL.Dtos.Model;
using AutoMarket.DAL.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMarket.BLL.Services
{
    /// <summary>
    /// Сервис Модели Машины
    /// </summary>
    public class ModelService : IModelService
    {
        private readonly UnitOfWork _uow;
        private readonly IMapper _mapper;
        public ModelService(UnitOfWork uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }
        public async Task<ModelDto> CreateAsync(ModelDto modelDto)
        {
            throw new NotImplementedException();
        }

        public void Delete(ModelDto modelDto)
        {
            throw new NotImplementedException();
        }

        public void Edit(ModelDto modelDto)
        {
            throw new NotImplementedException();
        }

        public async Task<List<ModelDto>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<ModelDto> GetByNameAsync(string name)
        {
            throw new NotImplementedException();
        }
    }
}
