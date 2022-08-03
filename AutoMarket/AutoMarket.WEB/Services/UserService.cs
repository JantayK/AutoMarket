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
    public class UserService : IUserService
    {
        private readonly UnitOfWork _uow;
        private readonly IMapper _mapper;
        public UserService(UnitOfWork uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }
        public void EditPersonalData(User user)
        {
            throw new NotImplementedException();
        }
    }
}
