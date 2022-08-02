using AutoMarket.WEB.ViewModels.Advert;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AutoMarket.WEB.ViewModels
{
    public class BrandViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Обязательное поле")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Минимум 2, максимум 50 символов")]
        [Display(Name = "Название брэнда")]
        public string Name { get; set; }
        public ICollection<AdvertViewModel> Adverts { get; set; }
    }
}
