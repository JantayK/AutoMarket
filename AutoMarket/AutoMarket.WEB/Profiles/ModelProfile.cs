using AutoMapper;
using AutoMarket.BLL.Dtos.Model;
using AutoMarket.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMarket.BLL.Profiles
{
    public class ModelProfile : Profile
    {
        public ModelProfile()
        {
            CreateMap<ModelDto, Model>().ReverseMap();
        }
    }
}
