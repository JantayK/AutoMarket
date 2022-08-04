using AutoMarket.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMarket.DAL.Models
{
    /// <summary>
    /// Модель поколения авто
    /// </summary>
    public class Generation : IEntity<int>
    {
        public int Id { get; set; }

        [ForeignKey("Model")]
        public int ModelId { get; set; }

        /// <summary>
        /// Название кузова (Например: "W222/С217")
        /// </summary>
        public string BodyName { get; set; }

        /// <summary>
        /// Нумерация поколения
        /// </summary>
        public int GenerationNumber { get; set; }

        /// <summary>
        /// Год начала производства данного поколения
        /// </summary>
        public int StartYear { get; set; }

        /// <summary>
        /// Год остоновки производства данного поколения
        /// </summary>
        public int EndYear { get; set; }

        /// <summary>
        /// Указывает на то, является ли это поколение рестайлингом
        /// </summary>
        public bool Restyling { get; set; }

        public virtual Model Model { get; set; }
        public ICollection<CarCharacteristics> CarCharacteristics { get; set; }
        public ICollection<Advert> Adverts { get; set; }
    }
}
