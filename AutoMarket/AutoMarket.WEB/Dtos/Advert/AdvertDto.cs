using AutoMarket.BLL.Dtos.Brand;
using AutoMarket.BLL.Dtos.Generation;
using AutoMarket.BLL.Dtos.Model;
using AutoMarket.BLL.Dtos.User;
using AutoMarket.DAL.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AutoMarket.BLL.Dtos.Advert
{
    /// <summary>
    /// Dto модель для Объявления
    /// </summary>
    public class AdvertDto
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
        /// Год выпуска авто
        /// </summary>

        [Display(Name = "Год выпуска")]
        [Required(ErrorMessage = "Обязательное поле")]
        [DataType(DataType.Date)]
        [StringLength(4, MinimumLength = 4, ErrorMessage = "Некорректный ввод")]
        public int ManufacturerYear { get; set; }

        /// <summary>
        /// Тип топлива авто
        /// </summary>

        [Display(Name = "Тип топлива")]
        [Required(ErrorMessage = "Обязательное поле")]
        public FuelType FuelType { get; set; }

        /// <summary>
        /// Тип кузова авто
        /// </summary>

        [Display(Name = "Тип кузова")]
        [Required(ErrorMessage = "Обязательное поле")]
        public BodyType BodyType { get; set; }

        /// <summary>
        /// Тип привода авто
        /// </summary>

        [Display(Name = "Тип привода")]
        [Required(ErrorMessage = "Обязательное поле")]
        public DriveType DriveType { get; set; }

        /// <summary>
        /// Объем двигателя
        /// </summary>

        [Display(Name = "Объем двигателя")]
        [Required(ErrorMessage = "Обязательное поле")]
        public double EngineVolume { get; set; }

        /// <summary>
        /// Тип коробки передая
        /// </summary>

        [Display(Name = "Тип КПП")]
        [Required(ErrorMessage = "Обязательное поле")]
        public GearBox GearBox { get; set; }

        /// <summary>
        /// Расположение руля
        /// </summary>

        [Display(Name = "Располодение руля")]
        [Required(ErrorMessage = "Обязательное поле")]
        public Steer Steer { get; set; }

        /// <summary>
        /// Цвет авто
        /// </summary>

        [Display(Name = "Цвет авто")]
        [Required(ErrorMessage = "Обязательное поле")]
        public Color Color { get; set; }

        /// <summary>
        /// Состояние авто
        /// </summary>

        [Display(Name = "Состояние авто")]
        [Required(ErrorMessage = "Обязательное поле")]
        public Condition Condition { get; set; }

        /// <summary>
        /// Пробег авто
        /// </summary>

        [Display(Name = "Пробег в (км)")]
        [Required(ErrorMessage = "Обязательное поле")]
        [StringLength(7, MinimumLength = 1, ErrorMessage = "Минимум 1, максимум  7 цифр")]
        public int Mileage { get; set; }

        /// <summary>
        /// Дополнительное описание для объявления
        /// </summary>

        [Display(Name = "Описание об автомобиле")]
        [Required(ErrorMessage = "Обязательное поле")]
        [DataType(DataType.Text)]
        [StringLength(1000, MinimumLength = 2, ErrorMessage = "Минимум 2, максимум 1000 символов")]
        public string Description { get; set; }

        /// <summary>
        /// Дата добавления объявления на сайте
        /// </summary>

        public DateTime DateOfAddition { get; set; }

        /// <summary>
        /// Цена для авто в $ (долларах)
        /// </summary>

        [Display(Name = "Цена в ($)")]
        [Required(ErrorMessage = "Обязательное поле")]
        [StringLength(10, MinimumLength = 1, ErrorMessage = "Минимум 1, максимум 10 цифр")]
        public Decimal Price { get; set; }
        public virtual BrandDto Brand { get; set; }
        public virtual ModelDto Model { get; set; }
        public virtual GenerationDto Generation { get; set; }
        public virtual UserDto User { get; set; }
    }
}
