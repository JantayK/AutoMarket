using AutoMarket.DAL.Enums;
using AutoMarket.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMarket.DAL.Models
{
    public class Advert : IEntity<int>
    {
        public int Id { get; set; }

        [ForeignKey("User")]
        public string UserId { get; set; }

        [ForeignKey("Brand")]
        public int BrandId { get; set; }

        [ForeignKey("Model")]
        public int ModelId { get; set; }

        [ForeignKey("Generation")]
        public int GenerationId { get; set; }

        public int ManufacturerYear { get; set; }
        public FuelType FuelType { get; set; }
        public BodyType BodyType { get; set; }
        public DriveType DriveType { get; set; }
        public double EngineVolume { get; set; }
        public GearBox GearBox { get; set; }
        public Steer Steer { get; set; }
        public Color Color { get; set; }
        public Condition Condition { get; set; }
        public int Mileage { get; set; }
        public string Description { get; set; }
        public DateTime DateOfAddition { get; set; }
        public Decimal Price { get; set; }
        public virtual Brand Brand { get; set; }
        public virtual Model Model { get; set; }
        public virtual Generation Generation { get; set; }
        public virtual User User { get; set; }
        public ICollection<Comment> Comments { get; set; }
    }
}
