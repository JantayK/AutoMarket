using System;
using System.Collections.Generic;
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
        Automatical = 1,

        /// <summary>
        /// Механическая
        /// </summary>
        Mechanical = 2,
        
        /// <summary>
        /// Роботизированная
        /// </summary>
        Robotic = 3,

        /// <summary>
        /// Вариатор
        /// </summary>
        Variator = 4
    }
}
