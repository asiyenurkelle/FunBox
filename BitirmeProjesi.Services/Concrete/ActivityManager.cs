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
    public class ActivityManager : IActivityService
    {
        private readonly IUnitOfWork _unitOfWork;
        public ActivityManager(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<IDataResult<BookSerieMovieDto>> GetActivities()
        {
            var books = await _unitOfWork.Books.GetAllAsync(b => b.Activities==true, b=>b.Category);
            var movies = await _unitOfWork.Movies.GetAllAsync(m => m.Activities == true, m => m.Category);
            var series = await _unitOfWork.Series.GetAllAsync(s => s.Activities == true, s => s.Category);
            if (books.Count > -1 && series.Count > -1 && movies.Count > -1)
            {
                return new DataResult<BookSerieMovieDto>(ResultStatus.Success, new BookSerieMovieDto
                {
                    Books = books,
                    Series = series,
                    Movies = movies,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<BookSerieMovieDto>(ResultStatus.Error, Messages.Activity.NotFound(isPlural: true), new BookSerieMovieDto
            {
                Books = null,
                Series=null,
                Movies=null,
                ResultStatus = ResultStatus.Error,
                Message = Messages.Activity.NotFound(isPlural: true)
            });
        }
    }
}
