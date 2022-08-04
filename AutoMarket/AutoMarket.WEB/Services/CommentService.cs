using AutoMapper;
using AutoMarket.BLL.Dtos.Comment;
using AutoMarket.DAL.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMarket.BLL.Services
{
    /// <summary>
    /// Сервис Комментариев
    /// </summary>
    public class CommentService : ICommentService
    {
        private readonly UnitOfWork _uow;
        private readonly IMapper _mapper;
        public CommentService(UnitOfWork uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }
        public async Task<CommentDto> CreateAsync(CommentDto commentDto)
        {
            throw new NotImplementedException();
        }

        public void Delete(CommentDto commentDto)
        {
            throw new NotImplementedException();
        }
    }
}
