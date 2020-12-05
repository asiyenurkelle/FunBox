using BitirmeProjesi.Data.Abstract;
using BitirmeProjesi.Entities.Dtos;
using BitirmeProjesi.Services.Abstract;
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
    public class AnswerManager : IAnswerService
    {
        private readonly IUnitOfWork _unitOfWork;
        public AnswerManager(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<IDataResult<MovieListDto>> GetOneHourFilms()
        {
            var movies = await _unitOfWork.Movies.GetAllAsync(m => m.Time == 60, m => m.Category, m => m.Comments);
            var categories = await _unitOfWork.Categories.GetAllAsync(null, c => c.Movies);
            if (movies.Count > -1)
            {
                return new DataResult<MovieListDto>(ResultStatus.Success, new MovieListDto
                {
                    Movies = movies,
                    Categories = categories,
                    ResultStatus = ResultStatus.Success,
                    Message = "Başarılı"
                });
            }
            return new DataResult<MovieListDto>(ResultStatus.Error, "Böyle bir film bulunamadı", null);
        }
        public async Task<IDataResult<MovieListDto>> GetLessThanOneHourFilms()
        {
            var movies = await _unitOfWork.Movies.GetAllAsync(m => m.Time < 60, m => m.Category, m => m.Comments);
            var categories = await _unitOfWork.Categories.GetAllAsync(null, c => c.Movies);
            if (movies.Count > -1)
            {
                return new DataResult<MovieListDto>(ResultStatus.Success, new MovieListDto
                {
                    Movies = movies,
                    Categories = categories,
                    ResultStatus = ResultStatus.Success,
                    Message = "Başarılı"
                });
            }
            return new DataResult<MovieListDto>(ResultStatus.Error, "Böyle bir film bulunamadı", null);
        }
        public async Task<IDataResult<MovieListDto>> GetMoreThanOneHourFilms()
        {
            var movies = await _unitOfWork.Movies.GetAllAsync(m => m.Time > 60, m => m.Category, m => m.Comments);
            var categories = await _unitOfWork.Categories.GetAllAsync(null, c => c.Movies);
            if (movies.Count > -1)
            {
                return new DataResult<MovieListDto>(ResultStatus.Success, new MovieListDto
                {
                    Movies = movies,
                    Categories = categories,
                    ResultStatus = ResultStatus.Success,
                    Message = "Başarılı"
                });
            }
            return new DataResult<MovieListDto>(ResultStatus.Error, "Böyle bir film bulunamadı", null);
        }

        public async Task<IDataResult<MoodTestingDto>> GetAll()
        {
            var questions = await _unitOfWork.Questions.GetAllAsync(null, q => q.Answer );
            var answers = await _unitOfWork.Answers.GetAllAsync(null, a => a.Question);
            if(questions.Count>-1 && answers.Count > -1)
            {
                return new DataResult<MoodTestingDto>(ResultStatus.Success, new MoodTestingDto
                {
                    Questions = questions,
                    Answers = answers,
                    ResultStatus = ResultStatus.Success,
                    Message = "Başarılı"
                });
            }
            return new DataResult<MoodTestingDto>(ResultStatus.Error, "Böyle bir soru ve cevap bulunamadı", null);
           
        }
    }
}
