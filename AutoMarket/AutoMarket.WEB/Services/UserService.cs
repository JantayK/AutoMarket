using AutoMapper;
using AutoMarket.BLL.Dtos.User;
using AutoMarket.DAL.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMarket.BLL.Services
{
    /// <summary>
    /// Сервис Пользователя
    /// </summary>
    public class UserService : IUserService
    {
        private readonly UnitOfWork _uow;
        private readonly IMapper _mapper;
        public UserService(UnitOfWork uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }

        /// <summary>
        /// Изменение Личной информации Пользователя 
        /// </summary>
        /// <param name="userDto"></param>
        public void EditPersonalData(UserDto userDto)
        {
            throw new NotImplementedException();
        }
    }
}
