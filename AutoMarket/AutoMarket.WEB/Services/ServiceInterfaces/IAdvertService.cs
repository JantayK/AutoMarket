using AutoMarket.DAL.Enums;
using AutoMarket.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMarket.BLL.Services
{
    /// <summary>
    /// Интерфейс для Сервиса Объявлений
    /// </summary>
    public interface IAdvertService
    {
        public Task<Advert> CreateAsync(Advert advert);
        public void Edit(Advert advert);
        public void Delete(Advert advert);
        public Task<List<Advert>> GetAllAsync();
        public Task<List<Advert>> GetByBrandAsync(string name);
        public Task<List<Advert>> GetByModelAsync(string name);
        public Task<List<Advert>> GetByGenerationAsync(int generationId);
        public Task<List<Advert>> GetByYearAsync(int yearFrom, int till);
        public Task<List<Advert>> GetByPriceAsync(decimal priceFrom, int till);
        public Task<List<Advert>> GetByGearBoxAsync(GearBox type);
        public Task<List<Advert>> GetByColorAsync(Color color);
        public Task<List<Advert>> GetByEngineVolumeAsync(double engineVolFrom, double till);
        public Task<List<Advert>> GetByConditionAsync(Condition condition);
    }
}
