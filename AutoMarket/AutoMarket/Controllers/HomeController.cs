using AutoMarket.BLL.Dtos.Advert;
using AutoMarket.BLL.Dtos.Brand;
using AutoMarket.BLL.Dtos.Generation;
using AutoMarket.BLL.Dtos.GetDtos;
using AutoMarket.BLL.Dtos.ImageModel;
using AutoMarket.BLL.Dtos.Model;
using AutoMarket.BLL.Services;
using AutoMarket.BLL.Services.ServiceInterfaces;
using AutoMarket.DAL.Enums;
using AutoMarket.DAL.Models;
using AutoMarket.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace AutoMarket.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IImageService _imageService;
        private readonly IAdvertService _advertService;
        private readonly IBrandService _brandService;
        private readonly IModelService _modelService;
        private readonly IGenerationService _generationService;

        public HomeController(ILogger<HomeController> logger, IImageService imageService, IAdvertService advertService, IBrandService brandService, IModelService modelService, IGenerationService generationService)
        {
            _logger = logger;
            _imageService = imageService;
            _advertService = advertService;
            _brandService = brandService;
            _modelService = modelService;
            _generationService = generationService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var advertsDto = await _advertService.GetAllAsync();
            var imageModelsDto = await _imageService.GetAllAsync();
            var brands = await _brandService.GetAllAsync();
            var models = await _modelService.GetAllAsync();
            var generations = await _generationService.GetAllAsync();

            foreach (var item in advertsDto)
            {
                var result = imageModelsDto.FirstOrDefault(x => x.AdvertId == item.Id);

                var brandName = brands.FirstOrDefault(x => x.Id == item.BrandId);
                item.BrandName = brandName.Name;

                var modelName = models.FirstOrDefault(x => x.Id == item.ModelId);
                item.ModelName = modelName.Name;

                item.PriceSom = item.Price * (decimal)82.48;
                item.ImageModelDto = result;
            }

            var allList = new GetBrandModelGenerationDto();

            allList.GetBrandsDto = brands;
            allList.GetModelsDto = models;
            allList.GetGenerationsDto = generations;

            FullAdvertDtoModel fullAdvertDto = new FullAdvertDtoModel()
            {
                AdvertDtos = advertsDto,
                GetBrandModelGeneration = allList
            };
            return View(fullAdvertDto);
        }

        [HttpGet]
        public async Task<IActionResult> FilterredAdverts(FullAdvertDtoModel fullModel)
        {
            var filteredList = new FullAdvertDtoModel();
            if (fullModel.BrandId != 0)
            {
                var adverts = await _advertService.GetByBrandAsync(fullModel.BrandId);
                filteredList.AdvertDtos.AddRange(adverts);
            }
            if (fullModel.ModelId != 0)
            {
                var adverts = await _advertService.GetByModelAsync(fullModel.ModelId);
                filteredList.AdvertDtos.AddRange(adverts);
            }
            if (fullModel.GenerationId != 0)
            {
                var adverts = await _advertService.GetByGenerationAsync(fullModel.GenerationId);
                filteredList.AdvertDtos.AddRange(adverts);
            }
            if (fullModel.BodyType != 0)
            {
                var adverts = await _advertService.GetByBodyTypeAsync(fullModel.BodyType);
                filteredList.AdvertDtos.AddRange(adverts);
            }
            if (fullModel.ManufacturerYearFrom != 0 && fullModel.ManufacturerYearTill != 0)
            {
                var adverts = await _advertService.GetByYearAsync(fullModel.ManufacturerYearFrom, fullModel.ManufacturerYearTill);
                filteredList.AdvertDtos.AddRange(adverts);
            }
            if (fullModel.ManufacturerYearFrom != 0)
            {
                var adverts = await _advertService.GetAllAsync();
                var filterredList = adverts.Where(x => x.ManufacturerYear >= fullModel.ManufacturerYearFrom).ToList();
                filteredList.AdvertDtos.AddRange(adverts);
            }
            if (fullModel.ManufacturerYearTill != 0)
            {
                var adverts = await _advertService.GetAllAsync();
                var filterredList = adverts.Where(x => x.ManufacturerYear <= fullModel.ManufacturerYearTill).ToList();
                filteredList.AdvertDtos.AddRange(adverts);
            }
            if (fullModel.MileageFrom != 0 && fullModel.MileageTill != 0)
            {
                var adverts = await _advertService.GetByMileageAsync(fullModel.MileageFrom, fullModel.MileageTill);
                filteredList.AdvertDtos.AddRange(adverts);
            }
            if (fullModel.MileageFrom != 0)
            {
                var adverts = await _advertService.GetAllAsync();
                var filterredList = adverts.Where(x => x.Mileage >= fullModel.MileageFrom).ToList();
                filteredList.AdvertDtos.AddRange(filterredList);
            }
            if (fullModel.MileageTill != 0)
            {
                var adverts = await _advertService.GetAllAsync();
                var filterredList = adverts.Where(x => x.Mileage <= fullModel.MileageTill).ToList();
                filteredList.AdvertDtos.AddRange(filterredList);
            }
            if (fullModel.GearBox != 0)
            {
                var adverts = await _advertService.GetByGearBoxAsync(fullModel.GearBox);
                filteredList.AdvertDtos.AddRange(adverts);
            }
            if (fullModel.DriveType != 0)
            {
                var adverts = await _advertService.GetByDriveTypeAsync(fullModel.DriveType);
                filteredList.AdvertDtos.AddRange(adverts);
            }
            if (fullModel.FuelType != 0)
            {
                var adverts = await _advertService.GetByFuelTypeAsync(fullModel.FuelType);
                filteredList.AdvertDtos.AddRange(adverts);
            }
            if (fullModel.Steer != 0)
            {
                var adverts = await _advertService.GetBySteeringWheelAsync(fullModel.Steer);
                filteredList.AdvertDtos.AddRange(adverts);
            }
            if (fullModel.Condition != 0)
            {
                var adverts = await _advertService.GetByConditionAsync(fullModel.Condition);
                filteredList.AdvertDtos.AddRange(adverts);
            }
            if (fullModel.Color != 0)
            {
                var adverts = await _advertService.GetByColorAsync(fullModel.Color);
                filteredList.AdvertDtos.AddRange(adverts);
            }
            if (fullModel.EngineVolumeFrom != 0 && fullModel.EngineVolumeTill != 0)
            {
                var adverts = await _advertService.GetByEngineVolumeAsync(fullModel.EngineVolumeFrom, fullModel.EngineVolumeTill);
                filteredList.AdvertDtos.AddRange(adverts);
            }
            if (fullModel.EngineVolumeFrom != 0)
            {
                var adverts = await _advertService.GetAllAsync();
                var filterredList = adverts.Where(x => x.EngineVolume >= fullModel.EngineVolumeFrom).ToList();
                filteredList.AdvertDtos.AddRange(filterredList);
            }
            if (fullModel.EngineVolumeTill != 0)
            {
                var adverts = await _advertService.GetAllAsync();
                var filterredList = adverts.Where(x => x.EngineVolume <= fullModel.EngineVolumeTill).ToList();
                filteredList.AdvertDtos.AddRange(filterredList);
            }
            if (fullModel.PriceFrom != 0 && fullModel.PriceTill != 0)
            {
                var adverts = await _advertService.GetByPriceAsync(fullModel.PriceFrom, fullModel.PriceTill);
                filteredList.AdvertDtos.AddRange(adverts);
            }
            if (fullModel.PriceFrom != 0)
            {
                var adverts = await _advertService.GetAllAsync();
                var filterredList = adverts.Where(x => x.Price >= fullModel.PriceFrom).ToList();
                filteredList.AdvertDtos.AddRange(filterredList);
            }
            if (fullModel.PriceTill != 0)
            {
                var adverts = await _advertService.GetAllAsync();
                var filterredList = adverts.Where(x => x.Price <= fullModel.PriceTill).ToList();
                filteredList.AdvertDtos.AddRange(filterredList);
            }

            return PartialView(filteredList);
        }

        [HttpGet]
        public async Task<IActionResult> GetModelsByBrand(int id)
        {
            var models = await _modelService.GetAllAsync();

            var filterredList = new GetBrandModelGenerationDto()
            {
                GetModelsDto = models.Where(x => x.BrandId == id).ToList()
            };

            return PartialView(filterredList);
        }

        [HttpGet]
        public async Task<IActionResult> GetGenerationByModel(int id)
        {
            var generations = await _generationService.GetAllAsync();

            var filterredList = new GetBrandModelGenerationDto()
            {
                GetGenerationsDto = generations.Where(x => x.ModelId == id).ToList()
            };

            return PartialView(filterredList);
        }
        public IActionResult Privacy()
        {
            return View();
        }
    }
}