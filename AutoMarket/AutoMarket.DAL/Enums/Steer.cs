using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMarket.DAL.Enums
{
    /// <summary>
    /// Enum для расположения руля
    /// </summary>
    public enum Steer
    {
        /// <summary>
        /// Правый
        /// </summary>
        [Display(Name = "Правый руль")]
        Right = 1,

        /// <summary>
        /// Левый
        /// </summary>
        [Display(Name = "Левый руль")]
        Left = 2
    }
}
