using AutoMapper;
using AutoMarket.BLL.Dtos.Generation;
using AutoMarket.DAL.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMarket.BLL.Services
{
    /// <summary>
    /// Сервис Поколения Машины
    /// </summary>
    public class GeneretionService : IGenerationService
    {
        private readonly UnitOfWork _uow;
        private readonly IMapper _mapper;
        public GeneretionService(UnitOfWork uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }
        public async Task<GenerationDto> CreateAsync(GenerationDto generationDto)
        {
            throw new NotImplementedException();
        }

        public void Delete(GenerationDto generationDto)
        {
            throw new NotImplementedException();
        }

        public void Edit(GenerationDto generationDto)
        {
            throw new NotImplementedException();
        }

        public async Task<List<GenerationDto>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<GenerationDto> GetByBodyNameAsync()
        {
            throw new NotImplementedException();
        }
    }
}
