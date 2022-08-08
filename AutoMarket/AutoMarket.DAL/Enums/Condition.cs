using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMarket.DAL.Enums
{
    /// <summary>
    /// Enum для состоянии машины
    /// </summary>
    public enum Condition
    {
        /// <summary>
        /// Аварийный / Не на ходу
        /// </summary>
        [Display(Name = "Аварийный / Не на ходу")]
        Emergency = 1,

        /// <summary>
        /// Среднее
        [Display(Name = "Среднее")]
        /// </summary>
        Medium = 2,

        /// <summary>
        /// Хорошее
        [Display(Name = "Хорошее")]
        /// </summary>
        Good = 3,

        /// <summary>
        /// Идеальное
        [Display(Name = "Идеальное")]
        /// </summary>
        Ideal = 4,

        /// <summary>
        /// Новый / Без пробега
        /// </summary>
        [Display(Name = "Новый / Без пробега")]
        New = 5
    }
}
