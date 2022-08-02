using AutoMarket.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMarket.DAL.Models
{
    public class Comment : IEntity<int>
    {
        public int Id { get; set; }

        [ForeignKey("User")]
        public string UserId { get; set; }
        [ForeignKey("Advert")]
        public string AdvertId { get; set; }

        [StringLength(1000)]
        public string Text { get; set; }
        public virtual User User { get; set; }
    }
}
