using AutoMapper;
using AutoMarket.BLL.Dtos.Comment;
using AutoMarket.DAL.Data;
using AutoMarket.DAL.Models;
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

        /// <summary>
        /// Создание Комментария
        /// </summary>
        /// <param name="commentDto"></param>
        /// <returns></returns>
        public async Task<CommentDto> CreateAsync(CommentDto commentDto)
        {
            var comment = _mapper.Map<Comment>(commentDto);
            var addedComments = await _uow.CommentRepository.CreateAsync(comment);
            await _uow.CommentRepository.SaveAsync();
            var result = _mapper.Map<CommentDto>(addedComments);
            return result;
        }

        /// <summary>
        /// Удаление комментария
        /// </summary>
        /// <param name="commentDto"></param>
        public void Delete(CommentDto commentDto)
        {
            var comment = _mapper.Map<Comment>(commentDto);
            _uow.CommentRepository.Delete(comment);
            _uow.Save();
        }
    }
}
