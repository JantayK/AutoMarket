using AutoMarket.BLL.Dtos.Brand;
using AutoMarket.BLL.Dtos.Comment;
using AutoMarket.BLL.Dtos.Generation;
using AutoMarket.BLL.Dtos.Model;
using AutoMarket.BLL.Dtos.User;
using AutoMarket.DAL.Enums;
using Microsoft.AspNetCore.Http;
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
        [Required(ErrorMessage = "Заполните это поле")]
        [Range(1850, maximum: 2022, ErrorMessage = "от 1850 до 2022 года")]
        public int ManufacturerYear { get; set; }

        /// <summary>
        /// Тип топлива авто
        /// </summary>

        [Display(Name = "Тип топлива")]
        [Required(ErrorMessage = "Заполните это поле")]
        public FuelType FuelType { get; set; }

        /// <summary>
        /// Тип кузова авто
        /// </summary>

        [Display(Name = "Тип кузова")]
        [Required(ErrorMessage = "Заполните это поле")]
        public BodyType BodyType { get; set; }

        /// <summary>
        /// Тип привода авто
        /// </summary>

        [Display(Name = "Тип привода")]
        [Required(ErrorMessage = "Заполните это поле")]
        public DriveType DriveType { get; set; }

        /// <summary>
        /// Объем двигателя
        /// </summary>

        [Display(Name = "Объем двигателя")]
        [Required(ErrorMessage = "Заполните это поле")]
        [Range(0.6, maximum: 30.5, ErrorMessage = "Введите правильный объем (0.6 - 30.5)")]
        public double EngineVolume { get; set; }

        /// <summary>
        /// Тип коробки передая
        /// </summary>

        [Display(Name = "Тип КПП")]
        [Required(ErrorMessage = "Заполните это поле")]
        public GearBox GearBox { get; set; }

        /// <summary>
        /// Расположение руля
        /// </summary>

        [Display(Name = "Расположение руля")]
        [Required(ErrorMessage = "Заполните это поле")]
        public Steer Steer { get; set; }

        /// <summary>
        /// Цвет авто
        /// </summary>

        [Display(Name = "Цвет авто")]
        [Required(ErrorMessage = "Заполните это поле")]
        public Color Color { get; set; }

        /// <summary>
        /// Состояние авто
        /// </summary>

        [Display(Name = "Состояние авто")]
        [Required(ErrorMessage = "Заполните это поле")]
        public Condition Condition { get; set; }

        /// <summary>
        /// Пробег авто
        /// </summary>

        [Display(Name = "Пробег в (км)")]
        [Required(ErrorMessage = "Заполните это поле")]
        [Range(0, maximum: 9999999, ErrorMessage = "Введите правильный пробег")]
        public int Mileage { get; set; }

        /// <summary>
        /// Дополнительное описание для объявления
        /// </summary>

        [Display(Name = "Описание об автомобиле")]
        [Required(ErrorMessage = "Обязательное поле")]
        [DataType(DataType.Text)]
        [StringLength(2000, MinimumLength = 2, ErrorMessage = "Минимум 2, максимум 2000 символов")]
        public string Description { get; set; }

        /// <summary>
        /// Фото машины 
        /// </summary>
        [Required]
        public IFormFileCollection Images { get; set; }

        /// <summary>
        /// Дата добавления объявления на сайте
        /// </summary>
        public DateTime DateOfAddition { get; set; }

        /// <summary>
        /// Цена для авто в $ (долларах)
        /// </summary>

        [Display(Name = "Цена в ($)")]
        [Required(ErrorMessage = "Заполните это поле ")]
        [Range(0, maximum: 9999999999, ErrorMessage = "Введите правильную сумму")]
        public Decimal Price { get; set; }
        public virtual BrandDto Brand { get; set; }
        public virtual ModelDto Model { get; set; }
        public virtual GenerationDto Generation { get; set; }
        public virtual UserDto User { get; set; }
        public ICollection<CommentDto> Comments { get; set; }
    }
}
