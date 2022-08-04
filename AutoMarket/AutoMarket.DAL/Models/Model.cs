using AutoMarket.DAL.Interfaces;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutoMarket.DAL.Models
{
    /// <summary>
    /// Модель Модели авто
    /// </summary>
    public class Model : IEntity<int>
    {
        public int Id { get; set; }

        [ForeignKey("Brand")]
        public int BrandId { get; set; }

        /// <summary>
        /// Название модели
        /// </summary>
        public string Name { get; set; }
        public virtual Brand Brand { get; set; }
        public ICollection<Generation> Generations { get; set; }
        public ICollection<Advert> Adverts { get; set; }
    }
}
