using AutoMarket.BLL.Dtos.Advert;
using AutoMarket.DAL.Enums;
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
        public Task<AdvertDto> CreateAsync(AdvertDto advert);
        public void Edit(AdvertDto advert);
        public void Delete(AdvertDto advert);
        public Task<List<AdvertDto>> GetAllAsync();
        public Task<List<AdvertDto>> GetByBrandAsync(string name);
        public Task<List<AdvertDto>> GetByModelAsync(string name);
        public Task<List<AdvertDto>> GetByGenerationAsync(int generationId);
        public Task<List<AdvertDto>> GetByYearAsync(int yearFrom, int till);
        public Task<List<AdvertDto>> GetByPriceAsync(decimal priceFrom, int till);
        public Task<List<AdvertDto>> GetByGearBoxAsync(GearBox type);
        public Task<List<AdvertDto>> GetByColorAsync(Color color);
        public Task<List<AdvertDto>> GetByEngineVolumeAsync(double engineVolFrom, double till);
        public Task<List<AdvertDto>> GetByConditionAsync(Condition condition);
        public Task<List<AdvertDto>> GetByBodyTypeAsync(BodyType bodyType);
        public Task<List<AdvertDto>> GetByDriveTypeAsync(DriveType driveType);
        public Task<List<AdvertDto>> GetBySteeringWheelAsync(Steer steer);
        public Task<List<AdvertDto>> GetByFuelTypeAsync(FuelType fuelType);
        public Task<List<AdvertDto>> GetByMileageAsync(int mileageFrom, int till);
    }
}
