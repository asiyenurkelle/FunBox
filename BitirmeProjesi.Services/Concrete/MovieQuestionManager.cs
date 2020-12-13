using BitirmeProjesi.Data.Abstract;
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
    public class MovieQuestionManager : IMovieQuestionService
    {
        private readonly IUnitOfWork _unitOfWork;
        public MovieQuestionManager(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async  Task<IDataResult<MovieQuestionDto>> GetQuestions()
        {
            var questions = await _unitOfWork.MovieQuestions.GetAllAsync(null);
            if (questions.Count > -1)
            {
                return new DataResult<MovieQuestionDto>(ResultStatus.Success, new MovieQuestionDto
                {
                    MovieQuestions = questions,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<MovieQuestionDto>(ResultStatus.Error, Messages.Question.NotFound(isPlural: true), new MovieQuestionDto
            {
                MovieQuestions = null,
                ResultStatus = ResultStatus.Error,
                Message = Messages.Question.NotFound(isPlural: true)
            });
        }
    }
}
