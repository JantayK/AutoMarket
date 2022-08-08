using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMarket.DAL.Enums
{
    /// <summary>
    /// Enum для типа топлива
    /// </summary>
    public enum FuelType
    {
        /// <summary>
        /// Бензин
        /// </summary>
        [Display(Name = "Бензин")]
        Gasoline = 1,

        /// <summary>
        /// Вин Дизель
        /// </summary>
        [Display(Name = "Вин Дизель")]
        Diesel = 2,

        /// <summary>
        /// Газ
        /// </summary>
        [Display(Name = "Газ")]
        Gas = 3
    }
}
