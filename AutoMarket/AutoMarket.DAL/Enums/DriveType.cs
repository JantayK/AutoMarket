using System;
using System.Collections.Generic;
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
        Forward = 1,

        /// <summary>
        /// Задний привод
        /// </summary>
        Rear = 2,

        /// <summary>
        /// Полный привод / 4WD
        /// </summary>
        All = 3
    }
}
