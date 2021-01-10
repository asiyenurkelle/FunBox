using BitirmeProjesi.Shared.Utilities.Results.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BitirmeProjesi.Entities.Dtos;

namespace BitirmeProjesi.Services.Abstract
{
    public interface IMovieCommentService
    {
        Task<IResult> AddComment(CommentAddMovieDto commentAddDto);
        Task<IResult> CommentDelete(int commentId);
        Task<IDataResult<CommentListDto>> GetAllComment();
        Task<IDataResult<CommentUpdateDto>> GetCommentUpdateDto(int commentId);
        Task<IDataResult<CommentDto>> UpdateComment(CommentUpdateDto commentUpdateDto);

    }
}
