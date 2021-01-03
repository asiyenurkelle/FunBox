using AutoMapper;
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
        private readonly IMapper _mapper;
        public ActivityManager(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
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
        public async Task<IDataResult<MovieUpdateDto>> DeleteActivitiesMovie(int movieId)
        {
            var result = await _unitOfWork.Movies.AnyAsync(m => m.Id == movieId);
            if (result)
            {
                var movie = await _unitOfWork.Movies.GetAsync(m => m.Id == movieId);
                movie.Activities = false;
                await _unitOfWork.SaveAsync();
                var movieUpdateDto = _mapper.Map<MovieUpdateDto>(movie);
                return new DataResult<MovieUpdateDto>(ResultStatus.Success, movieUpdateDto);
            }
            else
            {
                return new DataResult<MovieUpdateDto>(ResultStatus.Error, Messages.Movie.NotFound(isPlural: false), null);
            }
        }
        public async Task<IDataResult<SerieUpdateDto>> DeleteActivitiesSerie(int serieId)
        {
            var result = await _unitOfWork.Series.AnyAsync(s => s.Id == serieId);
            if (result)
            {
                var serie = await _unitOfWork.Series.GetAsync(s => s.Id == serieId);
                serie.Activities = false;
                await _unitOfWork.SaveAsync();
                var serieUpdateDto = _mapper.Map<SerieUpdateDto>(serie);
                return new DataResult<SerieUpdateDto>(ResultStatus.Success, serieUpdateDto);
            }
            else
            {
                return new DataResult<SerieUpdateDto>(ResultStatus.Error, Messages.Serie.NotFound(isPlural: false), null);
            }
        }
        public async Task<IDataResult<BookUpdateDto>> DeleteActivitiesBook(int bookId)
        {
            var result = await _unitOfWork.Books.AnyAsync(b => b.Id == bookId);
            if (result)
            {
                var book = await _unitOfWork.Books.GetAsync(b => b.Id == bookId);
                book.Activities = false;
                await _unitOfWork.SaveAsync();
                var bookUpdateDto = _mapper.Map<BookUpdateDto>(book);
                return new DataResult<BookUpdateDto>(ResultStatus.Success, bookUpdateDto);
            }
            else
            {
                return new DataResult<BookUpdateDto>(ResultStatus.Error, Messages.Book.NotFound(isPlural: false), null);
            }
        }
    }
}
