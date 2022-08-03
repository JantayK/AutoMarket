using AutoMapper;
using AutoMarket.BLL.Dtos.Generation;
using AutoMarket.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMarket.BLL.Profiles
{
    public  class GenerationProfile : Profile
    {
        public GenerationProfile()
        {
            CreateMap<GenerationDto, Generation>().ReverseMap();
        }
    }
}
