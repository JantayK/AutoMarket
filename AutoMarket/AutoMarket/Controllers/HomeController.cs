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

        public HomeController(ILogger<HomeController> logger, IImageService imageService, IAdvertService advertService)
        {
            _logger = logger;
            _imageService = imageService;
            _advertService = advertService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var advertsDto = await _advertService.GetAllAsync();
            var imageModelsDto = await _imageService.GetAllAsync();

            var listAdvertDtos = new List<AdvertDto>();
            var listImageModelDtos = new List<ImageModelDto>();

            listAdvertDtos.AddRange(advertsDto);
            listImageModelDtos.AddRange(imageModelsDto);

            var advertImageModelList = new GetAdvertImageModelDto()
            {
                AdvertDtos = listAdvertDtos,
                ImageModelDtos = listImageModelDtos
            };

            return View(advertImageModelList);
        }


        public IActionResult Privacy()
        {
            return View();
        }
    }
}