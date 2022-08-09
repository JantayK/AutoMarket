using AutoMarket.BLL.Dtos.Advert;
using AutoMarket.BLL.Services.ServiceInterfaces;
using AutoMarket.DAL.Data;
using System.IO;
using System.Threading.Tasks;
using AutoMarket.DAL.Models;
using Microsoft.AspNetCore.Hosting;

namespace AutoMarket.BLL.Services
{
    public class ImageService : IImageService
    {
        private readonly UnitOfWork _uow;
        private readonly IWebHostEnvironment _appEnvironment;

        public ImageService(UnitOfWork uow, IWebHostEnvironment appEnviroment)
        {
            _uow = uow;
            _appEnvironment = appEnviroment;
        }

        public async Task AddFile(AdvertDto advertDto)
        {
            var uploads = advertDto.Images;
            foreach (var uploadedFile in uploads)
            {
                string path = "/Files/" + uploadedFile.FileName;
                using (var fileStream = new FileStream(_appEnvironment.WebRootPath + path, FileMode.Create))
                {
                    await uploadedFile.CopyToAsync(fileStream);
                }
                ImageModel image = new ImageModel {Name = uploadedFile.FileName, Path = path };
                await _uow.ImagesRepository.CreateAsync(image);
            }
            await _uow.ImagesRepository.SaveAsync();
        }
    }
}
