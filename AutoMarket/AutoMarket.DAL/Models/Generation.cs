using AutoMarket.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMarket.DAL.Models
{
    public class Generation : IEntity<int>
    {
        public int Id { get; set; }

        [ForeignKey("Model")]
        public int ModelId { get; set; }
        public string BodyName { get; set; }
        public int GenerationNumber { get; set; }
        public int StartYear { get; set; }
        public int EndYear { get; set; }
        public bool Restyling { get; set; }

        public virtual Model Model { get; set; }
        public ICollection<CarCharacteristics> CarCharacteristics { get; set; }
        public ICollection<Advert> Adverts { get; set; }
    }
}
