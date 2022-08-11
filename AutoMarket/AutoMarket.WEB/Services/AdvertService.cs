using AutoMapper;
using AutoMarket.BLL.Dtos.Advert;
using AutoMarket.DAL.Data;
using AutoMarket.DAL.Enums;
using AutoMarket.DAL.Models;
using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
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
        private readonly IMapper _mapper;
        private readonly IWebHostEnvironment _appEnvironment;
        public AdvertService(UnitOfWork uow, IMapper mapper, IWebHostEnvironment appEnvironment)
        {
            _uow = uow;
            _mapper = mapper;
            _appEnvironment = appEnvironment;
        }

        /// <summary>
        /// Создание Объявления
        /// </summary>
        /// <param name="advert"></param>
        /// <returns></returns>
        public async Task<AdvertDto> CreateAsync(AdvertDto advertDto)
        {
                var advert = _mapper.Map<Advert>(advertDto);
                var ad = await _uow.AdvertRepository.CreateAsync(advert);
                await _uow.AdvertRepository.SaveAsync();

                var uploads = advertDto.Images;
                foreach (var uploadedFile in uploads)
                {
                    string path = "/Files/" + uploadedFile.FileName;
                    using (var fileStream = new FileStream(_appEnvironment.WebRootPath + path, FileMode.Create))
                    {
                        await uploadedFile.CopyToAsync(fileStream);
                    }
                    ImageModel image = new ImageModel { Name = uploadedFile.FileName, Path = path, AdvertId = ad.Id };
                    await _uow.ImagesRepository.CreateAsync(image);
                }
                await _uow.ImagesRepository.SaveAsync();

                var result = _mapper.Map<AdvertDto>(ad);
                return result;
        }

        /// <summary>
        /// Удаление Объявления
        /// </summary>
        /// <param name="advert"></param>
        public void Delete(AdvertDto advertDto)
        {
            var advert = _mapper.Map<Advert>(advertDto);
            if (advert != null)
            {
                _uow.AdvertRepository.Delete(advert);
                _uow.Save();
            }
        }

        /// <summary>
        /// Изменение Объявления
        /// </summary>
        /// <param name="advert"></param>
        public void Edit(AdvertDto advertDto)
        {
            var advert = _mapper.Map<Advert>(advertDto);
            _uow.AdvertRepository.Edit(advert);
            _uow.Save();
        }

        /// <summary>
        /// Получение всех Объявлений
        /// </summary>
        /// <returns></returns>
        public async Task<List<AdvertDto>> GetAllAsync()
        {
            var ad = await _uow.AdvertRepository.GetAsync();
            var result = _mapper.Map<List<AdvertDto>>(ad);
            return result;
        }

        /// <summary>
        /// Поиск Объявлений по Кузову машины
        /// </summary>
        /// <param name="bodyType"></param>
        /// <returns></returns>
        public async Task<List<AdvertDto>> GetByBodyTypeAsync(BodyType bodyType)
        {
            var list = await _uow.AdvertRepository.GetAsync();
            var filterredList = list.Where(x => x.BodyType == bodyType).ToList();
            var result = _mapper.Map<List<AdvertDto>>(filterredList);
            return result;
        }

        /// <summary>
        /// Поиск объявлений по Марке машины
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public async Task<List<AdvertDto>> GetByBrandAsync(int id)
        {
            if (id != 0)
            {
                var list = await _uow.AdvertRepository.GetAsync();
                var filterredList = list.Where(x => x.Brand.Id == id).ToList();
                var result = _mapper.Map<List<AdvertDto>>(filterredList);
                return result;
            }
            throw new ArgumentNullException("This field can't be empty!");
        }

        /// <summary>
        /// Получение Объявлений по цвету Машины
        /// </summary>
        /// <param name="color"></param>
        /// <returns></returns>
        public async Task<List<AdvertDto>> GetByColorAsync(Color color)
        {
            var list = await _uow.AdvertRepository.GetAsync();
            var filterredList = list.Where(x => x.Color == color).ToList();
            var result = _mapper.Map<List<AdvertDto>>(filterredList);
            return result;
        }

        /// <summary>
        /// Получение Объявлений по состоянию машины
        /// </summary>
        /// <param name="condition"></param>
        /// <returns></returns>
        public async Task<List<AdvertDto>> GetByConditionAsync(Condition condition)
        {
            var list = await _uow.AdvertRepository.GetAsync();
            var filterredList = list.Where(x => x.Condition == condition).ToList();
            var result = _mapper.Map<List<AdvertDto>>(filterredList);
            return result;
        }

        /// <summary>
        /// Поиск объявлений по типу Привода машины
        /// </summary>
        /// <param name="driveType"></param>
        /// <returns></returns>
        public async Task<List<AdvertDto>> GetByDriveTypeAsync(DAL.Enums.DriveType driveType)
        {
            var list = await _uow.AdvertRepository.GetAsync();
            var filterredList = list.Where(x => x.DriveType == driveType).ToList();
            var result = _mapper.Map<List<AdvertDto>>(filterredList);
            return result;
        }

        /// <summary>
        /// Получение по Объему двигателя, при помощи ОТ и ДО
        /// </summary>
        /// <param name="engineVolFrom"></param>
        /// <param name="till"></param>
        /// <returns></returns>
        public async Task<List<AdvertDto>> GetByEngineVolumeAsync(double engineVolFrom, double till)
        {
            var list = await _uow.AdvertRepository.GetAsync();
            var filterredList = list.Where(x => x.EngineVolume >= engineVolFrom && x.EngineVolume <= till).ToList();
            var result = _mapper.Map<List<AdvertDto>>(filterredList);
            return result;
        }

        /// <summary>
        /// Поиск объявлений по типу Топлива машины
        /// </summary>
        /// <param name="fuelType"></param>
        /// <returns></returns>
        public async Task<List<AdvertDto>> GetByFuelTypeAsync(FuelType fuelType)
        {
            var list = await _uow.AdvertRepository.GetAsync();
            var filterredList = list.Where(x => x.FuelType == fuelType).ToList();
            var result = _mapper.Map<List<AdvertDto>>(filterredList);
            return result;
        }

        /// <summary>
        /// Получение Объявлений по Коробке Передач машины
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public async Task<List<AdvertDto>> GetByGearBoxAsync(GearBox type)
        {
            var list = await _uow.AdvertRepository.GetAsync();
            var filterredList = list.Where(x => x.GearBox == type).ToList();
            var result = _mapper.Map<List<AdvertDto>>(filterredList);
            return result;
        }

        /// <summary>
        /// Получение Объявлений по Поколению машины
        /// </summary>
        /// <param name="generationId"></param>
        /// <returns></returns>
        public async Task<List<AdvertDto>> GetByGenerationAsync(int generationId)
        {
            var list = await _uow.AdvertRepository.GetAsync();
            var filterredList = list.Where(x => x.Generation.Id == generationId).ToList();
            var result = _mapper.Map<List<AdvertDto>>(filterredList);
            return result;
        }

        /// <summary>
        /// Поиск объявлений по Пробегу ОТ и ДО
        /// </summary>
        /// <param name="mileageFrom"></param>
        /// <param name="till"></param>
        /// <returns></returns>
        public async Task<List<AdvertDto>> GetByMileageAsync(int mileageFrom, int till)
        {
            var list = await _uow.AdvertRepository.GetAsync();
            var filterredList = list.Where(x => x.Mileage >= mileageFrom && x.Mileage <= till).ToList();
            var result = _mapper.Map<List<AdvertDto>>(filterredList);
            return result;
        }

        /// <summary>
        /// Получение Объявлений по Модели машины
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public async Task<List<AdvertDto>> GetByModelAsync(int id)
        {
            var list = await _uow.AdvertRepository.GetAsync();
            var filterredList = list.Where(x => x.Model.Id == id).ToList();
            var result = _mapper.Map<List<AdvertDto>>(filterredList);
            return result;
        }

        /// <summary>
        /// Получение Объявлений по цене ОТ и ДО
        /// </summary>
        /// <param name="priceFrom"></param>
        /// <param name="till"></param>
        /// <returns></returns>
        public async Task<List<AdvertDto>> GetByPriceAsync(decimal priceFrom, decimal till)
        {
            var list = await _uow.AdvertRepository.GetAsync();
            var filterredList = list.Where(x => x.Price >= priceFrom && x.Price <= till).ToList();
            var result = _mapper.Map<List<AdvertDto>>(filterredList);
            return result;
        }

        /// <summary>
        /// Поиск объявлений по расположению руля у машины
        /// </summary>
        /// <param name="steer"></param>
        /// <returns></returns>
        public async Task<List<AdvertDto>> GetBySteeringWheelAsync(Steer steer)
        {
            var list = await _uow.AdvertRepository.GetAsync();
            var filterredList = list.Where(x => x.Steer == steer).ToList();
            var result = _mapper.Map<List<AdvertDto>>(filterredList);
            return result;
        }

        /// <summary>
        /// Получение Объявлений По году выпуска ОТ и ДО
        /// </summary>
        /// <param name="yearFrom"></param>
        /// <param name="till"></param>
        /// <returns></returns>
        public async Task<List<AdvertDto>> GetByYearAsync(int yearFrom, int till)
        {
            var list = await _uow.AdvertRepository.GetAsync();
            var filterredList = list.Where(x => x.ManufacturerYear >= yearFrom && x.ManufacturerYear <= till).ToList();
            var result = _mapper.Map<List<AdvertDto>>(filterredList);
            return result;
        }
    }
}