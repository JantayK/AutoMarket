using AutoMapper;
using AutoMarket.BLL.Dtos.ImageModel;
using AutoMarket.BLL.Services.ServiceInterfaces;
using AutoMarket.DAL.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMarket.BLL.Services
{
    /// <summary>
    /// Сервис Изображений
    /// </summary>
    public class ImageService : IImageService
    {
        private readonly UnitOfWork _uow;
        private readonly IMapper _mapper;

        public ImageService(UnitOfWork uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }

        /// <summary>
        /// Получение всех изображений одного объявления
        /// </summary>
        /// <returns></returns>
        public async Task<List<ImageModelDto>> GetAllByIdAsync(int advertId)
        {
            var advert = await _uow.AdvertRepository.GetByIdAsync(advertId);
            var imageModels = advert.ImageModels.Where(x => x.AdvertId == advertId).ToList();
            var result = _mapper.Map<List<ImageModelDto>>(imageModels);
            return result;
        }

        /// <summary>
        /// Получение всех изображений 
        /// </summary>
        /// <returns></returns>
        public async Task<List<ImageModelDto>> GetAllAsync()
        {
            var imageModels = await _uow.ImagesRepository.GetAsync();
            var result = _mapper.Map<List<ImageModelDto>>(imageModels);
            return result;
        }

        /// <summary>
        /// Получение одного изображения по Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<ImageModelDto> GetById(int id)
        {
            var imageModel = await _uow.ImagesRepository.GetByIdAsync(id);
            var result = _mapper.Map<ImageModelDto>(imageModel);
            return result;
        }

        /// <summary>
        /// Получение одного изображения по Id объявления
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<ImageModelDto> GetByAdvertId(int advertId)
        {
            var advert = await _uow.AdvertRepository.GetByIdAsync(advertId);
            var imageModel = advert.ImageModels.FirstOrDefault(x => x.AdvertId == advertId);
            var result = _mapper.Map<ImageModelDto>(imageModel);
            return result;
        }
    }
}
