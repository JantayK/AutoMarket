﻿using AutoMarket.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMarket.BLL.Services
{
    public class ModelService : IModelService
    {
        public async Task<Model> CreateAsync(Model model)
        {
            throw new NotImplementedException();
        }

        public void Delete(Model model)
        {
            throw new NotImplementedException();
        }

        public void Edit(Model model)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Model>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<Model> GetByNameAsync(string name)
        {
            throw new NotImplementedException();
        }
    }
}
