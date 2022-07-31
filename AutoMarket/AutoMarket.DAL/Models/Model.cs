using AutoMarket.DAL.Interfaces;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutoMarket.DAL.Models
{
    public class Model : IEntity<int>
    {
        public int Id { get; set; }

        [ForeignKey("Brand")]
        public int BrandId { get; set; }
        public string Name { get; set; }
        public virtual Brand Brand { get; set; }
        public ICollection<Generation> Generations { get; set; }
    }
}
