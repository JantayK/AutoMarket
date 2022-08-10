using AutoMarket.BLL.Dtos.Advert;
using AutoMarket.BLL.Dtos.ImageModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMarket.BLL.Dtos.GetDtos
{
    /// <summary>
    /// Dto модель получния Объявлений и Изображений
    /// </summary>
    public class GetAdvertImageModelDto
    {
        public List<AdvertDto> AdvertDtos { get; set; }
        public List<ImageModelDto> ImageModelDtos { get; set; }
    }
}
