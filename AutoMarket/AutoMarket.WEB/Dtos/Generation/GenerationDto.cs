using AutoMarket.BLL.Dtos.Advert;
using AutoMarket.BLL.Dtos.CarCharacteristics;
using AutoMarket.BLL.Dtos.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AutoMarket.BLL.Dtos.Generation
{
    /// <summary>
    /// Dto модель для Поколения
    /// </summary>
    public class GenerationDto
    {
        public int Id { get; set; }

        [ForeignKey("Model")]
        public int ModelId { get; set; }

        [Display(Name = "Название кузова")]
        [Required(ErrorMessage = "Обязательное поле")]
        [StringLength(5, MinimumLength = 1, ErrorMessage = "Некорректные данные")]
        public string BodyName { get; set; }

        [Required(ErrorMessage = "Обязательное поле")]
        [Display(Name = "Номер поколения")]
        [StringLength(2, MinimumLength = 1, ErrorMessage = "Некорректные данные")]
        public int GenerationNumber { get; set; }

        [Required(ErrorMessage = "Обязательное поле")]
        [Display(Name = "Год начала выпуска")]
        [StringLength(4, MinimumLength = 4, ErrorMessage = "Некорректные данные")]
        [DataType(DataType.Date)]
        public int StartYear { get; set; }

        [Required(ErrorMessage = "Обязательное поле")]
        [Display(Name = "Год оканчания выпуска")]
        [StringLength(4, MinimumLength = 4, ErrorMessage = "Некорректные данные")]
        [DataType(DataType.Date)]
        public int EndYear { get; set; }

        [Display(Name = "Рестайлинг")]
        public bool Restyling { get; set; }

        public virtual ModelDto Model { get; set; }
        public ICollection<CarCharacteristicsDto> CarCharacteristics { get; set; }
        public ICollection<AdvertDto> Adverts { get; set; }
    }
}
