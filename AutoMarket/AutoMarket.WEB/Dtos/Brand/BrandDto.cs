using AutoMarket.BLL.Dtos.Advert;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AutoMarket.BLL.Dtos.Brand
{
    /// <summary>
    /// Dto модель для Брэнда
    /// </summary>
    public class BrandDto
    {
        public int Id { get; set; }

        /// <summary>
        /// Название Брэнда
        /// </summary>

        [Required(ErrorMessage = "Обязательное поле")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Минимум 2, максимум 50 символов")]
        [Display(Name = "Название брэнда")]
        public string Name { get; set; }
        public ICollection<AdvertDto> Adverts { get; set; }
    }
}
