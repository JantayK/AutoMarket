using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AutoMarket.WEB.ViewModels
{
    public class GenerationViewModel
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

        public virtual ModelViewModel Model { get; set; }
    }
}
