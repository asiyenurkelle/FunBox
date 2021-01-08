using AutoMapper;
using BitirmeProjesi.Data.Abstract;
using BitirmeProjesi.Entities.Concrete;
using BitirmeProjesi.Entities.Dtos;
using BitirmeProjesi.Services.Abstract;
using BitirmeProjesi.Services.Utilities;
using BitirmeProjesi.Shared.Utilities.Results.Abstract;
using BitirmeProjesi.Shared.Utilities.Results.Complex_Types;
using BitirmeProjesi.Shared.Utilities.Results.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitirmeProjesi.Services.Concrete
{
    public class SerieCommentManager:ISerieCommentService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public SerieCommentManager(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<IResult> CommentDelete(int commentId)
        {
            var comment = await _unitOfWork.SerieComments.GetAsync(c => c.Id == commentId);
            if (comment != null)
            {
                await _unitOfWork.SerieComments.DeleteAsync(comment);
                await _unitOfWork.SaveAsync();
                return new Result(ResultStatus.Success, Messages.Comment.Delete(comment.Title));
            }
            return new Result(ResultStatus.Error, Messages.Comment.NotFound(isPlural: false));

        }



        public async Task<IDataResult<CommentDto>> UpdateComment(CommentUpdateDto commentUpdateDto)
        {
            var comment = _mapper.Map<SerieComment>(commentUpdateDto);
            var updatedComment = await _unitOfWork.SerieComments.UpdateAsync(comment);
            await _unitOfWork.SaveAsync();
            return new DataResult<CommentDto>(ResultStatus.Success, $"{commentUpdateDto.Title} başlıklı yorum başarıyla güncellenmiştir.",
                new CommentDto
                {

                    SerieComment = updatedComment,
                    ResultStatus = ResultStatus.Success,
                    Message = $"{commentUpdateDto.Title} başlıklı yorum başarıyla güncellenmiştir."
                });

        }
        public async Task<IDataResult<CommentUpdateDto>> GetCommentUpdateDto(int commentId)
        {
            var result = await _unitOfWork.SerieComments.AnyAsync(mc => mc.Id == commentId);
            if (result)
            {
                var comment = await _unitOfWork.SerieComments.GetAsync(mc => mc.Id == commentId);
                var commentUpdateDto = _mapper.Map<CommentUpdateDto>(comment);
                return new DataResult<CommentUpdateDto>(ResultStatus.Success, commentUpdateDto);
            }
            else
            {
                return new DataResult<CommentUpdateDto>(ResultStatus.Error, null);
            }
        }

        public async Task<IDataResult<CommentListDto>> GetAll()
        {
            var serieComments = await _unitOfWork.SerieComments.GetAllAsync(null, m => m.Serie);
            if (serieComments.Count > -1)
            {
                return new DataResult<CommentListDto>(ResultStatus.Success, new CommentListDto
                {
                    SerieComments = serieComments,
                    ResultStatus = ResultStatus.Success,

                });
            }
            return new DataResult<CommentListDto>(ResultStatus.Error, Messages.Comment.NotFound(isPlural: true), null);
        }
    }
}
