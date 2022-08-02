using AutoMarket.DAL.Enums;
using AutoMarket.WEB.ViewModels.User;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AutoMarket.WEB.ViewModels.Advert
{
    public class AdvertViewModel
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

        [Display(Name = "Год выпуска")]
        [Required(ErrorMessage = "Обязательное поле")]
        [DataType(DataType.Date)]
        [StringLength(4, MinimumLength = 4, ErrorMessage = "Некорректный ввод")]
        public int ManufacturerYear { get; set; }

        [Display(Name = "Тип топлива")]
        [Required(ErrorMessage = "Обязательное поле")]
        public FuelType FuelType { get; set; }

        [Display(Name = "Тип кузова")]
        [Required(ErrorMessage = "Обязательное поле")]
        public BodyType BodyType { get; set; }

        [Display(Name = "Тип привода")]
        [Required(ErrorMessage = "Обязательное поле")]
        public DriveType DriveType { get; set; }
        public double EngineVolume { get; set; }

        [Display(Name = "Тип КПП")]
        [Required(ErrorMessage = "Обязательное поле")]
        public GearBox GearBox { get; set; }

        [Display(Name = "Руль")]
        [Required(ErrorMessage = "Обязательное поле")]
        public Steer Steer { get; set; }

        [Display(Name = "Цвет")]
        [Required(ErrorMessage = "Обязательное поле")]
        public Color Color { get; set; }

        [Display(Name = "Состояние автомобиля")]
        [Required(ErrorMessage = "Обязательное поле")]
        public Condition Condition { get; set; }

        [Display(Name = "Пробег в (км)")]
        [Required(ErrorMessage = "Обязательное поле")]
        [StringLength(7, MinimumLength = 1, ErrorMessage = "Минимум 1, максимум  7 цифр")]
        public int Mileage { get; set; }

        [Display(Name = "Описание об автомобиле")]
        [Required(ErrorMessage = "Обязательное поле")]
        [DataType(DataType.Text)]
        [StringLength(1000, MinimumLength = 2, ErrorMessage = "Минимум 2, максимум 1000 символов")]
        public string Description { get; set; }
        public DateTime DateOfAddition { get; set; }

        [Display(Name = "Цена в ($)")]
        [Required(ErrorMessage = "Обязательное поле")]
        [StringLength(10, MinimumLength = 1, ErrorMessage = "Минимум 1, максимум 10 цифр")]
        public Decimal Price { get; set; }
        public virtual BrandViewModel Brand { get; set; }
        public virtual ModelViewModel Model { get; set; }
        public virtual GenerationViewModel Generation { get; set; }
        public virtual UserViewModel User { get; set; }
    }
}
