using AutoMarket.BLL.Dtos.Advert;
using AutoMarket.BLL.Dtos.Comment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoMarket.BLL.Dtos.User
{
    public class UserDto
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public virtual CommentDto Comment { get; set; }
        public virtual AdvertDto Advert { get; set; }
    }
}
