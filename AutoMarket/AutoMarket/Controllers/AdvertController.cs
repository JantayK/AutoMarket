using AutoMapper;
using AutoMarket.BLL.Dtos.Advert;
using AutoMarket.BLL.Dtos.Brand;
using AutoMarket.BLL.Dtos.Generation;
using AutoMarket.BLL.Dtos.Model;
using AutoMarket.BLL.Services;
using AutoMarket.DAL.Enums;
using AutoMarket.DAL.Models;
using AutoMarket.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace AutoMarket.WEB.Controllers
{
    [Authorize]
    public class AdvertController : Controller
    {
        private readonly IAdvertService _advertService;
        private readonly IBrandService _brandService;
        private readonly IModelService _modelService;
        private readonly IGenerationService _generationService;
        private readonly IMapper _mapper;

        public AdvertController(IAdvertService advertService, IBrandService brandService, IModelService modelService, IGenerationService generationService, IMapper mapper)
        {
            _advertService = advertService;
            _brandService = brandService;
            _modelService = modelService;
            _generationService = generationService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> ChooseVehicle()
        {
            var brands = await _brandService.GetAllAsync();
            var models = await _modelService.GetAllAsync();
            var generations = await _generationService.GetAllAsync();

            var brandViewModel = new List<BrandDto>();
            var modelViewModel = new List<ModelDto>();
            var generationsViewModel = new List<GenerationDto>();

            brandViewModel.AddRange(brands);
            modelViewModel.AddRange(models);
            generationsViewModel.AddRange(generations);

            var allList = new GetBrandModelGenerationDto()
            {
                GetBrandsDto = brandViewModel,
                GetModelsDto = modelViewModel,
                GetGenerationsDto = generationsViewModel,
            };

            return View(allList);
        }

        [HttpGet]
        public async Task<IActionResult> GetModelsByBrand(int id)
        {
            var models = await _modelService.GetAllAsync();

            var filterredList = new GetBrandModelGenerationDto()
            {
                GetModelsDto = models.Where(x => x.BrandId == id).ToList(),
            };

            return PartialView(filterredList);
        }

        [HttpGet]
        public async Task<IActionResult> GetGenerationByModel(int id)
        {
            var generations = await _generationService.GetAllAsync();

            var filterredList = new GetBrandModelGenerationDto()
            {
                GetGenerationsDto = generations.Where(x => x.ModelId == id).ToList(),
            };

            return PartialView(filterredList);
        }

        [HttpGet]
        public IActionResult Create(int BrandId, int ModelId, int GenerationId)
        {
            var advertViewModel = new AdvertDto()
            {
                BrandId = BrandId,
                ModelId = ModelId,
                GenerationId = GenerationId,
                UserId = User.FindFirstValue(ClaimTypes.NameIdentifier)
            };
            return PartialView(advertViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Create(AdvertDto advertDto)
        {
            if (ModelState.IsValid)  
            {
                advertDto.DateOfAddition = DateTime.Now;
                await _advertService.CreateAsync(advertDto);

                return RedirectToAction("Index", "Home");
            }
            return View(advertDto);
        }
    }
}
