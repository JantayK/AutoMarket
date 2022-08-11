using AutoMarket.BLL.Dtos.Advert;
using AutoMarket.BLL.Dtos.Brand;
using AutoMarket.BLL.Dtos.Comment;
using AutoMarket.BLL.Dtos.Generation;
using AutoMarket.BLL.Dtos.ImageModel;
using AutoMarket.BLL.Dtos.Model;
using AutoMarket.BLL.Dtos.User;
using AutoMarket.DAL.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMarket.BLL.Dtos.GetDtos
{
    public class FullAdvertDtoModel
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
        public int ManufacturerYear { get; set; }

        /// <summary>
        /// Год выпуска авто ОТ
        /// </summary>

        [Display(Name = "Год выпуска от:")]
        [Range(1850, maximum: 2022, ErrorMessage = "от 1850 до 2022 года")]
        public int ManufacturerYearFrom { get; set; }

        /// <summary>
        /// Год выпуска авто ДО
        /// </summary>
        [Display(Name = "Год выпуска от:")]
        [Range(1850, maximum: 2022, ErrorMessage = "до 2022 года")]
        public int ManufacturerYearTill { get; set; }

        /// <summary>
        /// Тип топлива авто
        /// </summary>

        [Display(Name = "Тип топлива")]
        public FuelType FuelType { get; set; }

        /// <summary>
        /// Тип кузова авто
        /// </summary>

        [Display(Name = "Тип кузова")]
        public BodyType BodyType { get; set; }

        /// <summary>
        /// Тип привода авто
        /// </summary>

        [Display(Name = "Тип привода")]
        public DriveType DriveType { get; set; }

        /// <summary>
        /// Объем двигателя
        /// </summary>

        [Display(Name = "Объем двигателя")]
        [Range(0.5, maximum: 10.0, ErrorMessage = "Введите правильный объем (от 0.5)")]
        public double EngineVolume { get; set; }

        /// <summary>
        /// Объем двигателя ОТ
        /// </summary>

        [Display(Name = "Объем двигателя от:")]
        [Range(0.5, maximum: 10.0, ErrorMessage = "Введите правильный объем (от 0.5)")]
        public double EngineVolumeFrom { get; set; }

        /// <summary>
        /// Объем двигателя ДО
        /// </summary>
        [Display(Name = "Объем двигателя до:")]
        [Range(0.5, maximum: 10.0, ErrorMessage = "Введите правильный объем (до 10.0)")]
        public double EngineVolumeTill { get; set; }

        /// <summary>
        /// Тип коробки передая
        /// </summary>

        [Display(Name = "Тип КПП")]
        public GearBox GearBox { get; set; }

        /// <summary>
        /// Расположение руля
        /// </summary>

        [Display(Name = "Расположение руля")]
        public Steer Steer { get; set; }

        /// <summary>
        /// Цвет авто
        /// </summary>

        [Display(Name = "Цвет авто")]
        public Color Color { get; set; }

        /// <summary>
        /// Состояние авто
        /// </summary>

        [Display(Name = "Состояние авто")]
        public Condition Condition { get; set; }

        /// <summary>
        /// Пробег авто
        /// </summary>

        [Display(Name = "Пробег")]
        public int Mileage { get; set; }

        /// <summary>
        /// Пробег авто ОТ
        /// </summary>
        [Display(Name = "Пробег от:")]
        [Range(0, maximum: 9999999, ErrorMessage = "Введите правильный пробег")]
        public int MileageFrom { get; set; }

        /// <summary>
        /// Пробег авто ДО
        /// </summary>

        [Display(Name = "Пробег до:")]
        [Range(0, maximum: 9999999, ErrorMessage = "Введите правильный пробег")]
        public int MileageTill { get; set; }

        /// <summary>
        /// Цена для авто ОТ
        /// </summary>

        [Display(Name = "Цена от:")]
        [Range(0, maximum: 99999999999, ErrorMessage = "Введите правильную сумму")]
        public Decimal PriceFrom { get; set; }

        /// <summary>
        /// Цена для авто ДО
        /// </summary>

        [Display(Name = "Цена до:")]
        [Range(0, maximum: 99999999999, ErrorMessage = "Введите правильную сумму")]
        public Decimal PriceTill { get; set; }
        public virtual GetBrandModelGenerationDto GetBrandModelGeneration {get;set;}

        /// <summary>
        /// Цена для авто в долларах
        /// </summary>
        [Display(Name = "Цена")]
        public Decimal Price { get; set; }

        /// <summary>
        /// Цена для авто в сомах
        /// </summary>
        public Decimal PriceSom { get; set; }

        /// <summary>
        /// Название брэнда
        /// </summary>
        public string BrandName { get; set; }

        /// <summary>
        /// Название модели
        /// </summary>
        public string ModelName { get; set; }
        public virtual BrandDto Brand { get; set; }
        public virtual ModelDto Model { get; set; }
        public virtual GenerationDto Generation { get; set; }
        public ICollection<ImageModelDto> ImageModelDtoList { get; set; }
        public ImageModelDto ImageModelDto { get; set; }
        public List<AdvertDto> AdvertDtos { get; set; }
    }
}