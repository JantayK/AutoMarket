using AutoMarket.DAL.Data;
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
    /// Сервис Объявлений 
    /// </summary>
    public class AdvertService : IAdvertService
    {
        private readonly UnitOfWork _uow;
        public AdvertService(UnitOfWork uow)
        {
            _uow = uow;
        }
        public async Task<Advert> CreateAsync(Advert advert)
        {
            var ad = await _uow.AdvertRepository.CreateAsync(advert);
            await _uow.AdvertRepository.SaveAsync();
            return ad;
        }

        public void Delete(Advert advert)
        {
            if(advert != null)
            {
                _uow.AdvertRepository.Delete(advert);
                _uow.Save();
            }
        }

        public void Edit(Advert advert)
        {
            _uow.AdvertRepository.Edit(advert);
            _uow.Save();
        }

        public async Task<List<Advert>> GetAllAsync()
        {
            var ad = await _uow.AdvertRepository.GetAsync();
            return ad;
        }

        public async Task<List<Advert>> GetByBrandAsync(string name)
        {
            if(name != null)
            {
                var list = await _uow.AdvertRepository.GetAsync();
                var filterredList = list.Where(x => x.Brand.Name == name).ToList();
                return filterredList;
            }
            throw new ArgumentNullException("This field can't be empty!");
        }

        public async Task<List<Advert>> GetByColorAsync(Color color)
        {
            var list = await _uow.AdvertRepository.GetAsync();
            var filterredList = list.Where(x => x.Color == color).ToList();
            return filterredList;
        }

        public async Task<List<Advert>> GetByConditionAsync(Condition condition)
        {
            var list = await _uow.AdvertRepository.GetAsync();
            var filterredList = list.Where(x => x.Condition == condition).ToList();
            return filterredList;
        }

        public async Task<List<Advert>> GetByEngineVolumeAsync(double engineVolFrom, double till)
        {
            var list = await _uow.AdvertRepository.GetAsync();
            var filterredList = list.Where(x => x.EngineVolume >= engineVolFrom && x.EngineVolume <= till).ToList();
            return filterredList;
        }

        public async Task<List<Advert>> GetByGearBoxAsync(GearBox type)
        {
            var list = await _uow.AdvertRepository.GetAsync();
            var filterredList = list.Where(x => x.GearBox == type).ToList();
            return filterredList;
        }

        public async Task<List<Advert>> GetByGenerationAsync(int generationId)
        {
            var list = await _uow.AdvertRepository.GetAsync();
            var filterredList = list.Where(x => x.Generation.Id == generationId).ToList();
            return filterredList;
        }

        public async Task<List<Advert>> GetByModelAsync(string name)
        {
            var list = await _uow.AdvertRepository.GetAsync();
            var filterredList = list.Where(x => x.Model.Name == name).ToList();
            return filterredList;
        }

        public async Task<List<Advert>> GetByPriceAsync(decimal priceFrom, int till)
        {
            var list = await _uow.AdvertRepository.GetAsync();
            var filterredList = list.Where(x => x.Price >= priceFrom && x.Price <= till).ToList();
            return filterredList;
        }

        public async Task<List<Advert>> GetByYearAsync(int yearFrom, int till)
        {
            var list = await _uow.AdvertRepository.GetAsync();
            var filterredList = list.Where(x => x.ManufacturerYear >= yearFrom && x.ManufacturerYear <= till).ToList();
            return filterredList;
        }
    }
}
