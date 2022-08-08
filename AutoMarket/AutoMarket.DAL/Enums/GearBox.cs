using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMarket.DAL.Enums
{
    /// <summary>
    /// Enum для типа коробки передач
    /// </summary>
    public enum GearBox
    {
        /// <summary>
        /// Автоматическая
        /// </summary>
        [Display(Name = "Автоматическая")]
        Automatical = 1,

        /// <summary>
        /// Механическая
        /// </summary>
        [Display(Name = "Механическая")]
        Mechanical = 2,

        /// <summary>
        /// Роботизированная
        /// </summary>
        [Display(Name = "Роботизированная")]
        Robotic = 3,

        /// <summary>
        /// Вариатор
        /// </summary>
        [Display(Name = "Вариатор")]
        Variator = 4
    }
}
