using AutoMapper;
using AutoMarket.DAL.Data;
using AutoMarket.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMarket.BLL.Services
{
    public class GeneretionService : IGenerationService
    {
        private readonly UnitOfWork _uow;
        private readonly IMapper _mapper;
        public GeneretionService(UnitOfWork uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }
        public async Task<Generation> CreateAsync(Generation generation)
        {
            throw new NotImplementedException();
        }

        public void Delete(Generation generation)
        {
            throw new NotImplementedException();
        }

        public void Edit(Generation generation)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Generation>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<Generation> GetByBodyNameAsync()
        {
            throw new NotImplementedException();
        }
    }
}
