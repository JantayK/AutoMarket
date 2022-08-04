using AutoMarket.BLL.Dtos.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMarket.BLL.Services
{
    /// <summary>
    /// Интерфейс для сервиса Моделей
    /// </summary>
    public interface IModelService
    {
        public Task<ModelDto> CreateAsync(ModelDto modelDto);
        public void Edit(ModelDto modelDto);
        public void Delete(ModelDto modelDto);
        public Task<List<ModelDto>> GetAllAsync();
        public Task<ModelDto> GetByNameAsync(string name);
    }
}
