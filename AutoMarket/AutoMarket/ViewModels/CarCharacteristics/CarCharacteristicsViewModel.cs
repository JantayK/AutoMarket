using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AutoMarket.WEB.ViewModels.CarCharacteristics
{
    public class CarCharacteristicsViewModel
    {
        public int Id { get; set; }

        [ForeignKey("Model")]
        public int ModelId { get; set; }

        [Display(Name = "Объем двигателя (см³)")]
        [Required(ErrorMessage = "Обязательное поле")]
        [StringLength(6, MinimumLength = 3, ErrorMessage = "Некорректный ввод")]
        public int EngineVolume { get; set; }

        [Display(Name = "Мощность двигателя (л.с)")]
        [Required(ErrorMessage = "Обязательное поле")]
        [StringLength(5, MinimumLength = 2, ErrorMessage = "Некорректный ввод")]
        public int EnginePower { get; set; }
        
        [Display(Name = "Крутящий момент (н*м)")]
        [Required(ErrorMessage = "Обязательное поле")]
        [StringLength(5, MinimumLength = 2, ErrorMessage = "Некорректный ввод")]
        public int Torque { get; set; }

        [Display(Name = "Количество цилиндров")]
        [Required(ErrorMessage = "Обязательное поле")]
        [StringLength(2, MinimumLength = 1, ErrorMessage = "Некорректный ввод")]
        public int Cylinders { get; set; }

        [Display(Name = "Максимальная скорость")]
        [Required(ErrorMessage = "Обязательное поле")]
        [StringLength(4, MinimumLength = 2, ErrorMessage = "Некорректный ввод")]
        public int MaxSpeed { get; set; }

        [Display(Name = "Время разгона до 100 км/ч (сек)")]
        [Required(ErrorMessage = "Обязательное поле")]
        [StringLength(4, MinimumLength = 1, ErrorMessage = "Некорректный ввод")]
        public double AccelerationTime { get; set; }

        [Display(Name = "Средний расход топлива")]
        [Required(ErrorMessage = "Обязательное поле")]
        [StringLength(4, MinimumLength = 1, ErrorMessage = "Некорректный ввод")]
        public double AverageFuelConsumption { get; set; }

        [Display(Name = "Длина в (мм)")]
        [Required(ErrorMessage = "Обязательное поле")]
        [StringLength(6, MinimumLength = 4, ErrorMessage = "Некорректный ввод")]
        public int Length { get; set; }

        [Display(Name = "Ширина в (мм)")]
        [Required(ErrorMessage = "Обязательное поле")]
        [StringLength(6, MinimumLength = 4, ErrorMessage = "Некорректный ввод")]
        public int Width { get; set; }

        [Display(Name = "Высота в (мм)")]
        [Required(ErrorMessage = "Обязательное поле")]
        [StringLength(4, MinimumLength = 3, ErrorMessage = "Некорректный ввод")]
        public int Height { get; set; }

        [Display(Name = "Клиренс в (мм)")]
        [Required(ErrorMessage = "Обязательное поле")]
        [StringLength(4, MinimumLength = 2, ErrorMessage = "Некорректный ввод")]
        public int Clearance { get; set; }

        [Display(Name = "Масса в (кг)")]
        [Required(ErrorMessage = "Обязательное поле")]
        [StringLength(5, MinimumLength = 3, ErrorMessage = "Некорректный ввод")]
        public int Weight { get; set; }

        [Display(Name = "Масса в (кг)")]
        [Required(ErrorMessage = "Обязательное поле")]
        [StringLength(3, MinimumLength = 2, ErrorMessage = "Некорректный ввод")]
        public int FuelTankCapacity { get; set; }
        public virtual GenerationViewModel Generation { get; set; }
    }
}
