using AutoMarket.BLL.Dtos.Generation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMarket.BLL.Services
{
     /// <summary>
     /// Интерфейс для сервиса Поколений
     /// </summary>
    public interface IGenerationService
    {
        public Task<GenerationDto> CreateAsync(GenerationDto generationDto);
        public void Edit(GenerationDto generationDto);
        public void Delete(GenerationDto generationDto);
        public Task<List<GenerationDto>> GetAllAsync();
        public Task<GenerationDto> GetByBodyNameAsync(int id);
    }
}
