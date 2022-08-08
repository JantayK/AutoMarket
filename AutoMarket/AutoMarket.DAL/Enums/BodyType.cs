using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMarket.DAL.Enums
{
    /// <summary>
    /// Enum для типа кузова
    /// </summary>
    public enum BodyType
    {
        /// <summary>
        /// Седан
        /// </summary>
        [Display(Name = "Седан")]
        Sedan = 1,

        /// <summary>
        /// Лифтбэк
        /// </summary>
        [Display(Name = "Лифтбэк")]
        Liftback = 2,

        /// <summary>
        /// Внедорожник
        /// </summary>
        [Display(Name = "Внедорожник")]
        SUV = 3,

        /// <summary>
        /// Купе
        /// </summary>
        [Display(Name = "Купе")]
        Coupe = 4,

        /// <summary>
        /// Кроссовер
        /// </summary>
        [Display(Name = "Кроссовер")]
        Crossover = 5,

        /// <summary>
        /// Лимузин
        /// </summary>
        [Display(Name = "Лимузин")]
        Limousine = 6,

        /// <summary>
        /// Кабриолет
        /// </summary>
        [Display(Name = "Кабриолет")]
        Cabriolet = 7,

        /// <summary>
        /// Хэтчбек
        /// </summary>
        [Display(Name = "Хэтчбек")]
        Hatchback = 8,

        /// <summary>
        /// Универсал
        /// </summary>
        [Display(Name = "Универсал")]
        Universal = 9,

        /// <summary>
        /// Пикап
        /// </summary>
        [Display(Name = "Пикап")]
        Pickup = 10,

        /// <summary>
        /// Фургон
        /// </summary>
        [Display(Name = "Фургон")]
        Van = 11,

        /// <summary>
        /// Минивэн
        /// </summary>
        [Display(Name = "Минивэн")]
        Minivan = 12
    }
}
