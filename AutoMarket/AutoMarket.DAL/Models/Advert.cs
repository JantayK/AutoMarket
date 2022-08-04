using AutoMarket.DAL.Enums;
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
    /// Модель объявления
    /// </summary>
    public class Advert : IEntity<int>
    {
        public int Id { get; set; }

        [ForeignKey("User")]
        public string UserId { get; set; }

        [ForeignKey("Brand")]
        public int BrandId { get; set; }

        [ForeignKey("Model")]
        public int ModelId { get; set; }

        [ForeignKey("Generation")]
        public int GenerationId { get; set; }

        /// <summary>
        /// Год производства / Выпуска авто
        /// </summary>
        public int ManufacturerYear { get; set; }

        /// <summary>
        /// Тип топлива
        /// </summary>
        public FuelType FuelType { get; set; }

        /// <summary>
        /// Тип кузова
        /// </summary>
        public BodyType BodyType { get; set; }

        /// <summary>
        /// Тип привода
        /// </summary>
        public DriveType DriveType { get; set; }

        /// <summary>
        /// Объем двигателя
        /// </summary>
        public double EngineVolume { get; set; }

        /// <summary>
        /// Тип коробки передач
        /// </summary>
        public GearBox GearBox { get; set; }
        
        /// <summary>
        /// Расположение руля
        /// </summary>
        public Steer Steer { get; set; }

        /// <summary>
        /// Цвет авто
        /// </summary>
        public Color Color { get; set; }

        /// <summary>
        /// Состояние авто
        /// </summary>
        public Condition Condition { get; set; }

        /// <summary>
        /// Пробег авто в километрах
        /// </summary>
        public int Mileage { get; set; }

        /// <summary>
        /// Допонительное описание для объявления
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Дата добавления объявления на сайте
        /// </summary>
        public DateTime DateOfAddition { get; set; }

        /// <summary>
        /// Цена для авто в $ (долларах)
        /// </summary>
        public Decimal Price { get; set; }
        public virtual Brand Brand { get; set; }
        public virtual Model Model { get; set; }
        public virtual Generation Generation { get; set; }
        public virtual User User { get; set; }
        public ICollection<Comment> Comments { get; set; }
    }
}
