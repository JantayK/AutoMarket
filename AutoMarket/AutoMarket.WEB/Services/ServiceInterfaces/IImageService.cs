using AutoMarket.BLL.Dtos.ImageModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMarket.BLL.Services.ServiceInterfaces
{
    /// <summary>
    /// Интерфейс сервиса Изображений
    /// </summary>
    public interface IImageService
    {
        public Task<List<ImageModelDto>> GetAllAsync();
        public Task<ImageModelDto> GetById(int id);
    }
}
