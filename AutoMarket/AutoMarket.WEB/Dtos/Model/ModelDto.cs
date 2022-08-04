using AutoMarket.DAL.Models;
using AutoMarket.BLL.Dtos.Brand;
using AutoMarket.BLL.Dtos.Advert;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AutoMarket.BLL.Dtos.Model
{
    /// <summary>
    /// Dto модель для Модели машины
    /// </summary>
    public class ModelDto
    {
        public int Id { get; set; }

        [ForeignKey("Brand")]
        public int BrandId { get; set; }

        /// <summary>
        /// Название модели
        /// </summary>

        [StringLength(50, MinimumLength = 2, ErrorMessage = "Минимум 2, максимум 50 символов")]
        [Required(ErrorMessage = "Обязательное поле")]
        [Display(Name = "Название модели")]
        public string Name { get; set; }
        public virtual BrandDto Brand { get; set; }
        public ICollection<AdvertDto> Adverts { get; set; }
    }
}
