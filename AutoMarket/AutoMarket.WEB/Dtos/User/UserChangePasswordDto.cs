using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AutoMarket.BLL.Dtos.User
{
    public class UserChangePasswordDto
    {
        [Required]
        public string Id { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Обязательное поле")]
        [Display(Name = "Старый пароль")]
        public string OldPassword { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Обязательное поле")]
        [StringLength(20, MinimumLength = 4, ErrorMessage = "Минимум 4, максимум 20 символов")]
        [Display(Name = "Новый пароль")]
        public string NewPassword { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Обязательное поле")]
        [Compare("NewPassword", ErrorMessage = "Пороли не совпадают")]
        [Display(Name = "Повторите новый пароль")]
        public string ConfirmNewPassword { get; set; }
    }
}
