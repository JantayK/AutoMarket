using System;
using System.Collections.Generic;
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

        [StringLength(1000)]
        public string Text { get; set; }
        public virtual User User { get; set; }
    }
}
