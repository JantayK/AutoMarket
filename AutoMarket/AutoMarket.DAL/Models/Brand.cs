using AutoMarket.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMarket.DAL.Models
{
    /// <summary>
    /// Модель Брэнда
    /// </summary>
    public class Brand : IEntity<int>
    {
        public int Id { get; set; }

        /// <summary>
        /// Название брэнда
        /// </summary>
        public string Name { get; set; }
        public ICollection<Model> Models { get; set; }
        public ICollection<Advert> Adverts { get; set; }
    }
}
