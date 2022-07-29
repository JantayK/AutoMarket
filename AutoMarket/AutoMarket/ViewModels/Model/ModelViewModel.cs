using AutoMarket.DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AutoMarket.WEB.ViewModels
{
    public class ModelViewModel
    {
        public int Id { get; set; }

        [ForeignKey("Brand")]
        public int BrandId { get; set; }

        [StringLength(50, MinimumLength = 2, ErrorMessage = "Минимум 2, максимум 50 символов")]
        [Required(ErrorMessage = "Обязательное поле")]
        [Display(Name = "Название модели")]
        public string Name { get; set; }
        public virtual BrandViewModel Brand { get; set; }
    }
}
