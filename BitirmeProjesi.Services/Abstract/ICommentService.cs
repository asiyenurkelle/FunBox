using BitirmeProjesi.Entities.Concrete;
using BitirmeProjesi.Entities.Dtos;
using BitirmeProjesi.Shared.Utilities.Results.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BitirmeProjesi.Services.Abstract
{
    public interface ICommentService
    {
        Task<IDataResult<CommentDto>> Get(int commentId);
        Task<IDataResult<CommentListDto>>GetAll();
        Task<IDataResult<CommentDto>> Add(CommentAddDto commentAddDto);
        //Dto lar frontend tarafında sadece ihtiyacımız olan dataları barındırı viewmodeller gibi düşünebiliriz.
        Task<IResult> Delete(int commentId);

    }
}
