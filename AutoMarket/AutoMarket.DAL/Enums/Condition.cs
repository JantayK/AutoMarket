using System;
using System.Collections.Generic;
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
        Emergency = 1,

        /// <summary>
        /// Средний
        /// </summary>
        Medium = 2,

        /// <summary>
        /// Хороший
        /// </summary>
        Good = 3,

        /// <summary>
        /// Идеальный
        /// </summary>
        Ideal = 4,

        /// <summary>
        /// Новый / Без пробега
        /// </summary>
        New = 5
    }
}
