using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMarket.DAL.Enums
{
    /// <summary>
    /// Enum для цвета машины
    /// </summary>
    public enum Color
    {
        /// <summary>
        /// Белый
        /// </summary>
        [Display(Name = "Белый")]
        White = 1,

        /// <summary>
        /// Черный
        /// </summary>
        [Display(Name = "Черный")]
        Black = 2,

        /// <summary>
        /// Серый
        /// </summary>
        [Display(Name = "Серый")]
        Gray = 3,

        /// <summary>
        /// Синий
        /// </summary>
        [Display(Name = "Синий")]
        Blue = 4,

        /// <summary>
        /// Красный
        /// </summary>
        [Display(Name = "Красный")]
        Red = 5,

        /// <summary>
        /// Жёлтый
        /// </summary>
        [Display(Name = "Жёлтый")]
        Yellow = 6,

        /// <summary>
        /// Зеленый
        /// </summary>
        [Display(Name = "Зеленый")]
        Green = 7,

        /// <summary>
        /// Голубой
        /// </summary>
        [Display(Name = "Голубой")]
        Cyan = 8,

        /// <summary>
        /// Мокрый асфальт
        /// </summary>
        [Display(Name = "Мокрый асфальт")]
        WetAsphalt = 9,

        /// <summary>
        /// Оранжевый
        /// </summary>
        [Display(Name = "Оранжевый")]
        Orange = 10,

        /// <summary>
        /// Песочный
        /// </summary>
        [Display(Name = "Песочный")]
        Sand = 11,

        /// <summary>
        /// Кориченевый
        /// </summary>
        [Display(Name = "Кориченевый")]
        Brown = 12,

        /// <summary>
        /// Розовый
        /// </summary>
        [Display(Name = "Розовый")]
        Pink = 13,

        /// <summary>
        /// Фиолетовый
        /// </summary>
        [Display(Name = "Фиолетовый")]
        Violet = 14
    }
}
