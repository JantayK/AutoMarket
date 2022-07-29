using AutoMarket.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMarket.BLL.Services
{
    public interface IModelService
    {
        public void Create(Model model);
        public void Edit(Model model);
        public void Delete(Model model);
        public List<Model> GetAll();
        public Model GetByName(string name);
    }
}
