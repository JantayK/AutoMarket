using AutoMarket.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMarket.BLL.Services
{
    public interface IAdvertService
    {
        public void Create(Advert advert);
        public void Edit(Advert advert);
        public void Delete(Advert advert);
        public List<Advert> GetAll();
        public List<Advert> GetByBrand(string Name);
        public List<Advert> GetByModel(string Name);
        public List<Advert> GetByGeneration(int Id);
        public List<Advert> GetByYear(int yearFrom, int till);
        public List<Advert> GetByPrice(decimal priceFrom, int till);
        public List<Advert> GetByGearBox(string type);
        public List<Advert> GetByColor(string color);
        public List<Advert> GetByEngineVolume(double engineVolFrom, double till);
        public List<Advert> GetByCondition(string condition);
    }
}
