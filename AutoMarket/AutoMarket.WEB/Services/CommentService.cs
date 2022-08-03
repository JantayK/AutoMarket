using AutoMapper;
using AutoMarket.DAL.Data;
using AutoMarket.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMarket.BLL.Services
{
    public class CommentService : ICommentService
    {
        private readonly UnitOfWork _uow;
        private readonly IMapper _mapper;
        public CommentService(UnitOfWork uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }
        public async Task<Comment> CreateAsync(Comment comment)
        {
            throw new NotImplementedException();
        }

        public void Delete(Comment comment)
        {
            throw new NotImplementedException();
        }
    }
}
