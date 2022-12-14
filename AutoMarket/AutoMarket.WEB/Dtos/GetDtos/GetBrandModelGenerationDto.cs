using AutoMarket.BLL.Dtos.Brand;
using AutoMarket.BLL.Dtos.Generation;
using AutoMarket.BLL.Dtos.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMarket.BLL.Dtos.Advert
{
    /// <summary>
    /// Dto модель получения Марок, Моделей и Поколений
    /// </summary>
    public class GetBrandModelGenerationDto
    {
        public List<BrandDto> GetBrandsDto { get; set; }
        public List<ModelDto> GetModelsDto { get; set; }
        public List<GenerationDto> GetGenerationsDto { get; set; }
    }
}
