using AutoMapper;
using AutoMarket.BLL.Dtos.Generation;
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

        /// <summary>
        /// Создание Поколения
        /// </summary>
        /// <param name="generationDto"></param>
        /// <returns></returns>
        public async Task<GenerationDto> CreateAsync(GenerationDto generationDto)
        {
            var generation = _mapper.Map<Generation>(generationDto);
            var addedGeneration = await _uow.GenerationRepository.CreateAsync(generation);
            await _uow.GenerationRepository.SaveAsync();
            var result = _mapper.Map<GenerationDto>(addedGeneration);
            return result;
        }

        /// <summary>
        /// Удаление Поколения
        /// </summary>
        /// <param name="generationDto"></param>
        public void Delete(GenerationDto generationDto)
        {
            var generation = _mapper.Map<Generation>(generationDto);
            _uow.GenerationRepository.Delete(generation);
            _uow.Save();
        }

        /// <summary>
        /// Изменение Поколения 
        /// </summary>
        /// <param name="generationDto"></param>
        public void Edit(GenerationDto generationDto)
        {
            var generation = _mapper.Map<Generation>(generationDto);
            _uow.GenerationRepository.Edit(generation);
            _uow.Save();
        }

        /// <summary>
        /// Получение всех поколений
        /// </summary>
        /// <returns></returns>
        public async Task<List<GenerationDto>> GetAllAsync()
        {
            var list = await _uow.GenerationRepository.GetAsync();
            var result = _mapper.Map<List<GenerationDto>>(list);
            return result;
        }

        /// <summary>
        /// Получение поколения по Названию кузова
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<GenerationDto> GetByBodyNameAsync(int id)
        {
            var generation = await _uow.GenerationRepository.GetByIdAsync(id);
            var result = _mapper.Map<GenerationDto>(generation);
            return result;
        }
    }
}
