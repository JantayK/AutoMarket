using AutoMarket.BLL.Dtos.Comment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMarket.BLL.Services
{
    /// <summary>
    /// Интерфейс для сервиса Комментариев
    /// </summary>
    public interface ICommentService
    {
        public Task<CommentDto> CreateAsync(CommentDto commentDto);
        public void Delete(CommentDto commentDto);
    }
}
