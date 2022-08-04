using AutoMapper;
using AutoMarket.BLL.Dtos.Model;
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

        /// <summary>
        /// Создание Модели
        /// </summary>
        /// <param name="modelDto"></param>
        /// <returns></returns>
        public async Task<ModelDto> CreateAsync(ModelDto modelDto)
        {
            var model = _mapper.Map<Model>(modelDto);
            var addedModel = await _uow.ModelRepository.CreateAsync(model);
            await _uow.ModelRepository.SaveAsync();
            var result = _mapper.Map<ModelDto>(addedModel);
            return result;
        }

        /// <summary>
        /// Удаление модели
        /// </summary>
        /// <param name="modelDto"></param>
        public void Delete(ModelDto modelDto)
        {
            var model = _mapper.Map<Model>(modelDto);
            _uow.ModelRepository.Delete(model);
            _uow.Save();
        }

        /// <summary>
        /// Изменение модели 
        /// </summary>
        /// <param name="modelDto"></param>
        public void Edit(ModelDto modelDto)
        {
            var model = _mapper.Map<Model>(modelDto);
            _uow.ModelRepository.Edit(model);
            _uow.Save();
        }

        /// <summary>
        /// Получение всех моделей
        /// </summary>
        /// <returns></returns>
        public async Task<List<ModelDto>> GetAllAsync()
        {
            var list = await _uow.ModelRepository.GetAsync();
            var result = _mapper.Map<List<ModelDto>>(list);
            return result;
        }

        /// <summary>
        /// Получение модели по имени
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public async Task<ModelDto> GetByNameAsync(int id)
        {
            var model = await _uow.ModelRepository.GetByIdAsync(id);
            var result = _mapper.Map<ModelDto>(model);
            return result;
        }
    }
}
