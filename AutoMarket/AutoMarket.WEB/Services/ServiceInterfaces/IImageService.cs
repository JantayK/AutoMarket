using AutoMarket.BLL.Dtos.Advert;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMarket.BLL.Services.ServiceInterfaces
{
    /// <summary>
    /// Интерфейс для сервиса Фотографий
    /// </summary>
    public interface IImageService
    {
        public Task AddFile(AdvertDto advertDto);
    }
}
