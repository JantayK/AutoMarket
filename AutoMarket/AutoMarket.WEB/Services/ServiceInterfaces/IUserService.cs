using AutoMarket.BLL.Dtos.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMarket.BLL.Services
{
    /// <summary>
    /// Интерфейс для сервиса Пользователя
    /// </summary>
    public interface IUserService
    {
        public void EditPersonalData(UserDto userDto);
    }
}
