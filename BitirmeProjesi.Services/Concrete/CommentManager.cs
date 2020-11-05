using AutoMapper;
using BitirmeProjesi.Data.Abstract;
using BitirmeProjesi.Entities.Concrete;
using BitirmeProjesi.Entities.Dtos;
using BitirmeProjesi.Services.Abstract;
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
            return new DataResult<CommentDto>(ResultStatus.Success, $"{commentAddDto.Title} başlıklı yorum başarıyla eklendi.", new CommentDto
            {
                Comment = addedComment,
                ResultStatus = ResultStatus.Success,
                Message = $"{commentAddDto.Title} başlıklı yorum başarıyla eklendi."
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
                return new Result(ResultStatus.Success, $"{comment.Title} başlıklı yorum başarıyla silinmiştir.");
            }
            return new Result(ResultStatus.Error, "Böyle bir yorum bulunamadı");
        }

        public async Task<IDataResult<CommentDto>> Get(int commentId)
        {
            var comment = await _unitOfWork.Comments.GetAsync(c => c.Id == commentId);
            if (comment != null)
            {
                return new DataResult<CommentDto>(ResultStatus.Success, new CommentDto
                {
                    Comment = comment,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<CommentDto>(ResultStatus.Error, "Böyle bir yorum bulunamadı", new CommentDto
            {
                Comment=null,
                ResultStatus=ResultStatus.Error,
                Message="Böyle bir yorum bulunamadı."
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
            return new DataResult<CommentListDto>(ResultStatus.Error, "Yorumlar bulunamadı.", new CommentListDto
            {
                Comments = null,
                ResultStatus = ResultStatus.Error,
                Message = "Yorumlar bulunamadı."
            });
        }

    }
}
