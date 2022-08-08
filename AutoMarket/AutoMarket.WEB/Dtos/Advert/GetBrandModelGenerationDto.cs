using AutoMarket.BLL.Dtos.Brand;
using AutoMarket.BLL.Dtos.Generation;
using AutoMarket.BLL.Dtos.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace AutoMarket.BLL.Dtos.Advert
{
    public class GetBrandModelGenerationDto
    {
        public List<BrandDto> GetBrandsDto { get; set; }
        public List<ModelDto> GetModelsDto { get; set; }
        public List<GenerationDto> GetGenerationsDto { get; set; }
    }
}
