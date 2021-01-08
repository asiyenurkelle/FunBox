using BitirmeProjesi.Entities.Dtos;
using BitirmeProjesi.Shared.Utilities.Results.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitirmeProjesi.Services.Abstract
{
    public interface IBookCommentService
    {
        Task<IResult> CommentDelete(int commentId);

        Task<IDataResult<CommentDto>> UpdateComment(CommentUpdateDto commentUpdateDto);
        Task<IDataResult<CommentUpdateDto>> GetCommentUpdateDto(int commentId);
        Task<IDataResult<CommentListDto>> GetAll();
    }
}
