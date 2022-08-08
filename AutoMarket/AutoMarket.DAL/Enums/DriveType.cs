using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMarket.DAL.Enums
{
    /// <summary>
    /// Enum для типа привода
    /// </summary>
    public enum DriveType
    {
        /// <summary>
        /// Передний привод
        /// </summary>
        [Display(Name = "Передний привод")]
        Forward = 1,

        /// <summary>
        /// Задний привод
        [Display(Name = "Задний привод")]
        /// </summary>
        Rear = 2,

        /// <summary>
        /// Полный привод / 4WD
        /// </summary>
        [Display(Name = "Полный привод / 4WD")]
        All = 3
    }
}
