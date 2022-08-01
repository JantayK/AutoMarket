using AutoMarket.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMarket.DAL.Models
{
    public class Brand : IEntity<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Model> Models { get; set; }
        public virtual Advert Advert { get; set; }
    }
}
