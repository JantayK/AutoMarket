using AutoMapper;
using AutoMarket.BLL.Dtos.CarCharacteristics;
using AutoMarket.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMarket.BLL.Profiles
{
    public class CarCharacteristicsProfile : Profile
    {
        public CarCharacteristicsProfile()
        {
            CreateMap<CarCharacteristicsDto, CarCharacteristics>().ReverseMap();
        }
    }
}
