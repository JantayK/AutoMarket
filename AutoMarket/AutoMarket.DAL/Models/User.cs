using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMarket.DAL.Models
{
    public class User : IdentityUser
    {
        public string FirstName { get; set; }
        public ICollection<Comment> Comments { get; set; }
        public virtual Advert Advert { get; set; }
    }
}
