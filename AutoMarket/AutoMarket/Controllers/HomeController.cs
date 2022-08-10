using AutoMarket.BLL.Dtos.Advert;
using AutoMarket.BLL.Dtos.GetDtos;
using AutoMarket.BLL.Dtos.ImageModel;
using AutoMarket.BLL.Services;
using AutoMarket.BLL.Services.ServiceInterfaces;
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

        public HomeController(ILogger<HomeController> logger, IImageService imageService, IAdvertService advertService, IBrandService brandService, IModelService modelService)
        {
            _logger = logger;
            _imageService = imageService;
            _advertService = advertService;
            _brandService = brandService;
            _modelService = modelService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var advertsDto = await _advertService.GetAllAsync();
            var imageModelsDto = await _imageService.GetAllAsync();
            var brands = await _brandService.GetAllAsync();
            var models = await _modelService.GetAllAsync();

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

            return View(advertsDto);
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}