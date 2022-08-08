using AutoMarket.BLL.Dtos.Advert;
using AutoMarket.BLL.Services.ServiceInterfaces;
using AutoMarket.DAL.Data;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using AutoMarket.DAL.Models;

namespace AutoMarket.BLL.Services
{
    public class ImageService : IImageService
    {
        private readonly UnitOfWork _uow;
        private IWebHostEnvironment _appEnviroment;

        public ImageService(UnitOfWork uow)
        {
            _uow = uow;
        }

        public async Task AddFile(AdvertDto advertDto)
        {
            var uploads = advertDto.Images;
            foreach (var uploadedFile in uploads)
            {
                string path = "/Files/" + uploadedFile.FileName;
                using (var fileStream = new FileStream(_appEnviroment.WebRootPath + path, FileMode.Create))
                {
                    await uploadedFile.CopyToAsync(fileStream);
                }
                ImageModel image = new ImageModel { Name = uploadedFile.FileName, Path = path };
                await _uow.ImagesRepository.CreateAsync(image);
            }
            await _uow.ImagesRepository.SaveAsync();
        }
    }
}
