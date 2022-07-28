using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMarket.DAL.Models
{
    public class CarCharacteristics : IEntity<int>
    {
        public int Id { get; set; }

        [ForeignKey("Model")]
        public int ModelId { get; set; }
        public int EnginePower { get; set; }
        public int Torque { get; set; }
        public int Cylinders { get; set; }
        public int MaxSpeed { get; set; }
        public decimal AccelerationTime { get; set; }
        public decimal AverageFuelConsumption { get; set; }
        public int Length { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public int Clearance { get; set; }
        public int Weight { get; set; }
        public int FuelTankCapacity { get; set; }
        public virtual Model Model { get; set; }
    }
}
