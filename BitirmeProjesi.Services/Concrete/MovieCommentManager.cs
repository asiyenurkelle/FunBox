﻿using AutoMapper;
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
    public class MovieCommentManager : IMovieCommentService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public MovieCommentManager(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<IResult> AddComment(CommentAddMovieDto commentAddDto)
        {
            var comment = _mapper.Map<MovieComment>(commentAddDto);

            var movie = await _unitOfWork.Movies.GetAsync(m => m.Id == commentAddDto.MovieId);
            comment.Movie = movie;
            comment.AuthorName = commentAddDto.AuthorName;
            comment.Subject = commentAddDto.Subject;
            comment.Title = commentAddDto.Title;
            var addedComment = await _unitOfWork.MovieComments.AddAsync(comment);
            await _unitOfWork.SaveAsync();
            return new Result(ResultStatus.Success, "başarılı");

        }
        public async Task<IResult> CommentDelete(int commentId)
        {
            var comment = await _unitOfWork.MovieComments.GetAsync(c => c.Id == commentId);
            if (comment!=null)
            {
                await _unitOfWork.MovieComments.DeleteAsync(comment);
                await _unitOfWork.SaveAsync();
                return new Result(ResultStatus.Success, Messages.Comment.Delete(comment.Title));
            }
            return new Result(ResultStatus.Error, Messages.Comment.NotFound(isPlural: false));

        }
        public async Task<IDataResult<CommentUpdateDto>> GetCommentUpdateDto(int commentId)
        {
            var result = await _unitOfWork.MovieComments.AnyAsync(mc => mc.Id == commentId);
            if (result)
            {
                var comment = await _unitOfWork.MovieComments.GetAsync(mc => mc.Id == commentId);
                var commentUpdateDto = _mapper.Map<CommentUpdateDto>(comment);
                return new DataResult<CommentUpdateDto>(ResultStatus.Success, commentUpdateDto);
            }
            else
            {
                return new DataResult<CommentUpdateDto>(ResultStatus.Error, null);
            }
        }
        public async Task<IDataResult<CommentListDto>> GetAllComment()
        {
            var movieComments = await _unitOfWork.MovieComments.GetAllAsync(null, m => m.Movie);
            if (movieComments.Count > -1)
            {
                return new DataResult<CommentListDto>(ResultStatus.Success, new CommentListDto
                {
                    MovieComments = movieComments,
                    ResultStatus = ResultStatus.Success,

                });
            }
            return new DataResult<CommentListDto>(ResultStatus.Error, Messages.Comment.NotFound(isPlural: true), null);
        }

        public async Task<IDataResult<CommentDto>> UpdateComment(CommentUpdateDto commentUpdateDto)
        {
            var comment = _mapper.Map<MovieComment>(commentUpdateDto);
            var updatedComment = await _unitOfWork.MovieComments.UpdateAsync(comment);
            updatedComment.MovieId= comment.Id;
            await _unitOfWork.SaveAsync();
            return new DataResult<CommentDto>(ResultStatus.Success, $"{commentUpdateDto.Title} başlıklı yorum başarıyla güncellenmiştir.",
                new CommentDto
                {

                    MovieComment = updatedComment,
                    ResultStatus = ResultStatus.Success,
                    Message = $"{commentUpdateDto.Title} başlıklı yorum başarıyla güncellenmiştir."
                });

        }

    }
}
