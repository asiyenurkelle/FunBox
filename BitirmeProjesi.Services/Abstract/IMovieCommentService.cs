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
        Task<IResult> CommentDelete(int commentId);
      
        //Task<IDataResult<CommentUpdateDto>> UpdateComment(CommentUpdateDto commentUpdateDto);

        Task<IDataResult<CommentUpdateDto>> GetCommentUpdateDto(int commentId);

    }
}
