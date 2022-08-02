using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using AutoMarket.DAL.Models;
using AutoMarket.WEB.ViewModels.User;

namespace AutoMarket.WEB.ViewModels.Comment
{
    public class CommentViewModel
    {
        public int Id { get; set; }

        [ForeignKey("User")]
        public string UserId { get; set; }
        [ForeignKey("Advert")]
        public string AdvertId { get; set; }

        [StringLength(1000, MinimumLength = 2, ErrorMessage = "Минимум 2, максимум 1000 символов")]
        [Required(ErrorMessage = "Заполните это поле")]
        [Display(Name = "Текст комментария")]
        [DataType(DataType.Text)]
        public string Text { get; set; }
        public virtual UserViewModel User { get; set; }
    }
}
