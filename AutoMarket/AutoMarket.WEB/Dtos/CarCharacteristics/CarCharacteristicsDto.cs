using AutoMarket.BLL.Dtos.Generation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AutoMarket.BLL.Dtos.CarCharacteristics
{
    /// <summary>
    /// Dto модель для характеристик авто
    /// </summary>
    public class CarCharacteristicsDto
    {
        public int Id { get; set; }

        [ForeignKey("Model")]
        public int ModelId { get; set; }

        /// <summary>
        /// Объем двигателя в см³
        /// </summary>

        [Display(Name = "Объем двигателя (см³)")]
        [Required(ErrorMessage = "Обязательное поле")]
        [StringLength(6, MinimumLength = 3, ErrorMessage = "Некорректный ввод")]
        public int EngineVolume { get; set; }

        /// <summary>
        /// Мощность двигателя в л.с
        /// </summary>

        [Display(Name = "Мощность двигателя (л.с)")]
        [Required(ErrorMessage = "Обязательное поле")]
        [StringLength(5, MinimumLength = 2, ErrorMessage = "Некорректный ввод")]
        public int EnginePower { get; set; }
        
        /// <summary>
        /// Крутящий момент в н*м
        /// </summary>

        [Display(Name = "Крутящий момент (н*м)")]
        [Required(ErrorMessage = "Обязательное поле")]
        [StringLength(5, MinimumLength = 2, ErrorMessage = "Некорректный ввод")]
        public int Torque { get; set; }

        /// <summary>
        /// Количество цилиндров
        /// </summary>

        [Display(Name = "Количество цилиндров")]
        [Required(ErrorMessage = "Обязательное поле")]
        [StringLength(2, MinimumLength = 1, ErrorMessage = "Некорректный ввод")]
        public int Cylinders { get; set; }

        /// <summary>
        /// Максимальная скорость авто в км/ч
        /// </summary>

        [Display(Name = "Максимальная скорость")]
        [Required(ErrorMessage = "Обязательное поле")]
        [StringLength(4, MinimumLength = 2, ErrorMessage = "Некорректный ввод")]
        public int MaxSpeed { get; set; }

        /// <summary>
        /// Время разгона до 100 км/ч
        /// </summary>

        [Display(Name = "Время разгона до 100 км/ч (сек)")]
        [Required(ErrorMessage = "Обязательное поле")]
        [StringLength(4, MinimumLength = 1, ErrorMessage = "Некорректный ввод")]
        public double AccelerationTime { get; set; }

        /// <summary>
        /// Средний расход топлива на 100 км
        /// </summary>

        [Display(Name = "Средний расход топлива")]
        [Required(ErrorMessage = "Обязательное поле")]
        [StringLength(4, MinimumLength = 1, ErrorMessage = "Некорректный ввод")]
        public double AverageFuelConsumption { get; set; }

        /// <summary>
        /// Длина авто в милиметрах
        /// </summary>

        [Display(Name = "Длина в (мм)")]
        [Required(ErrorMessage = "Обязательное поле")]
        [StringLength(6, MinimumLength = 4, ErrorMessage = "Некорректный ввод")]
        public int Length { get; set; }

        /// <summary>
        /// Ширина авто в милиметрах
        /// </summary>

        [Display(Name = "Ширина в (мм)")]
        [Required(ErrorMessage = "Обязательное поле")]
        [StringLength(6, MinimumLength = 4, ErrorMessage = "Некорректный ввод")]
        public int Width { get; set; }

        /// <summary>
        /// Высота авто в милиметрах
        /// </summary>

        [Display(Name = "Высота в (мм)")]
        [Required(ErrorMessage = "Обязательное поле")]
        [StringLength(4, MinimumLength = 3, ErrorMessage = "Некорректный ввод")]
        public int Height { get; set; }

        /// <summary>
        /// Клиренс авто в милиметрах
        /// </summary>

        [Display(Name = "Клиренс в (мм)")]
        [Required(ErrorMessage = "Обязательное поле")]
        [StringLength(4, MinimumLength = 2, ErrorMessage = "Некорректный ввод")]
        public int Clearance { get; set; }

        /// <summary>
        /// Масса авто в кг
        /// </summary>

        [Display(Name = "Масса в (кг)")]
        [Required(ErrorMessage = "Обязательное поле")]
        [StringLength(5, MinimumLength = 3, ErrorMessage = "Некорректный ввод")]
        public int Weight { get; set; }

        /// <summary>
        /// Объем топливного бака в литрах
        /// </summary>

        [Display(Name = "Объем топливного бака")]
        [Required(ErrorMessage = "Обязательное поле")]
        [StringLength(3, MinimumLength = 2, ErrorMessage = "Некорректный ввод")]
        public int FuelTankCapacity { get; set; }
        public virtual GenerationDto Generation { get; set; }
    }
}
