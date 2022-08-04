using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using AutoMarket.BLL.Dtos.User;
using AutoMarket.DAL.Models;

namespace AutoMarket.BLL.Dtos.Comment
{
    /// <summary>
    /// Dto модель для Комментариев
    /// </summary>
    public class CommentDto
    {
        public int Id { get; set; }

        [ForeignKey("User")]
        public string UserId { get; set; }
        [ForeignKey("Advert")]
        public string AdvertId { get; set; }

        /// <summary>
        /// Текст комментария
        /// </summary>

        [StringLength(1000, MinimumLength = 2, ErrorMessage = "Минимум 2, максимум 1000 символов")]
        [Required(ErrorMessage = "Заполните это поле")]
        [Display(Name = "Текст комментария")]
        [DataType(DataType.Text)]
        public string Text { get; set; }
        public virtual UserDto User { get; set; }
    }
}
