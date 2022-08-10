﻿using AutoMapper;
using AutoMarket.BLL.Dtos.ImageModel;
using AutoMarket.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMarket.BLL.Profiles
{
    public class ImageModelProfile : Profile
    {
        public ImageModelProfile()
        {
            CreateMap<ImageModelDto, ImageModel>().ReverseMap();
        }
    }
}
