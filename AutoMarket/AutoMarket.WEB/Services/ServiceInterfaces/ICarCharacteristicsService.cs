using AutoMarket.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMarket.BLL.Services
{
    public interface ICarCharacteristicsService
    {
        public void Create(CarCharacteristics carCharacteristics);
        public void Edit(CarCharacteristics carCharacteristics);
        public void Delete(CarCharacteristics carCharacteristics);
    }
}
