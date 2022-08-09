using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMarket.DAL.Models
{
    /// <summary>
    /// Модель юзера
    /// </summary>
    public class User : IdentityUser
    {
        /// <summary>
        /// Имя
        /// </summary>
        public string FirstName { get; set; }
        public ICollection<Comment> Comments { get; set; }
        public ICollection<Advert> Adverts { get; set; }
    }
}
