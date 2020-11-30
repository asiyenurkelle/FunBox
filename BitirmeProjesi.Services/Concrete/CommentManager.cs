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
using System.Text;
using System.Threading.Tasks;

namespace BitirmeProjesi.Services.Concrete
{
    public class CommentManager : ICommentService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public CommentManager(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<IDataResult<CommentDto>> Add(CommentAddDto commentAddDto)
        {
            var comment = _mapper.Map<Comment>(commentAddDto);
            var addedComment = await _unitOfWork.Comments.AddAsync(comment); 
            await _unitOfWork.SaveAsync();
            //USERID EKLENCEK BUNUN İÇİNDE USER İSLEMLERİNİ EKLE.KİMİN YORUM YAPTIGINI GÖRMEK İÇİN.
            return new DataResult<CommentDto>(ResultStatus.Success, Messages.Comment.Add(addedComment.Title), new CommentDto
            {
                Comment = addedComment,
                ResultStatus = ResultStatus.Success,
                Message = Messages.Comment.Add(addedComment.Title)
            });
        }

        public async Task<IResult> Delete(int commentId)
        {
            var result = await _unitOfWork.Comments.AnyAsync(c => c.Id == commentId);
            if (result)
            {
                var comment = await _unitOfWork.Comments.GetAsync(c => c.Id == commentId);
                await _unitOfWork.Comments.DeleteAsync(comment);
                await _unitOfWork.SaveAsync();
                return new Result(ResultStatus.Success, Messages.Comment.Delete(comment.Title));
            }
            return new Result(ResultStatus.Error, Messages.Comment.NotFound(isPlural:false));
        }

        public async Task<IDataResult<CommentDto>> Get(int commentId)
        {
            var comment = await _unitOfWork.Comments.GetAsync(c => c.Id == commentId, c=>c.Serie);
            if (comment != null)
            {
                return new DataResult<CommentDto>(ResultStatus.Success, new CommentDto
                {
                    Comment = comment,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<CommentDto>(ResultStatus.Error, Messages.Comment.NotFound(isPlural: false), new CommentDto
            {
                Comment=null,
                ResultStatus=ResultStatus.Error,
                Message= Messages.Comment.NotFound(isPlural: false)
            });
        }

        public async Task<IDataResult<CommentListDto>> GetAll()
        {
            var comments = await _unitOfWork.Comments.GetAllAsync();
            if (comments.Count > -1)
            {
                return new DataResult<CommentListDto>(ResultStatus.Success, new CommentListDto
                {
                    Comments = comments,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<CommentListDto>(ResultStatus.Error, Messages.Comment.NotFound(isPlural:true), new CommentListDto
            {
                Comments = null,
                ResultStatus = ResultStatus.Error,
                Message = Messages.Comment.NotFound(isPlural: true)
            });
        }


    }
}
