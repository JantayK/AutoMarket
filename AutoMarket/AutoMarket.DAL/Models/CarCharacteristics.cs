using AutoMarket.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMarket.DAL.Models
{
    /// <summary>
    /// Модель характеристик авто
    /// </summary>
    public class CarCharacteristics : IEntity<int>
    {
        public int Id { get; set; }

        [ForeignKey("Generation")]
        public int GenerationId { get; set; }

        /// <summary>
        /// Объем двигателя
        /// </summary>
        public int EngineVolume { get; set; }

        /// <summary>
        /// Мощность двигателя в Л.С
        /// </summary>
        public int EnginePower { get; set; }

        /// <summary>
        /// Крутящий момент в н*м
        /// </summary>
        public int Torque { get; set; }

        /// <summary>
        /// Количество цилиндров
        /// </summary>
        public int Cylinders { get; set; }

        /// <summary>
        /// Максимальная скорость авто
        /// </summary>
        public int MaxSpeed { get; set; }

        /// <summary>
        /// Время разгона до 100 км/ч
        /// </summary>
        public double AccelerationTime { get; set; }

        /// <summary>
        /// Средний расход топлива на 100 км
        /// </summary>
        public double AverageFuelConsumption { get; set; }

        /// <summary>
        /// Длина авто в милиметрах
        /// </summary>
        public int Length { get; set; }

        /// <summary>
        /// Ширина авто в милиметрах
        /// </summary>
        public int Width { get; set; }

        /// <summary>
        /// Высота авто в милиметрах
        /// </summary>
        public int Height { get; set; }

        /// <summary>
        /// Клиренс авто в милиметрах
        /// </summary>
        public int Clearance { get; set; }

        /// <summary>
        /// Масса авто в кг
        /// </summary>
        public int Weight { get; set; }

        /// <summary>
        /// Объем топливного бака в литрах
        /// </summary>
        public int FuelTankCapacity { get; set; }
        public virtual Generation Generation { get; set; }
    }
}
