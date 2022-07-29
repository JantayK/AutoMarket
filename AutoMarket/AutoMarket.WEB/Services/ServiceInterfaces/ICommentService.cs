using AutoMarket.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMarket.BLL.Services
{
    public interface ICommentService
    {
        public void Create(Comment comment);
        public void Delete(Comment comment);
    }
}
