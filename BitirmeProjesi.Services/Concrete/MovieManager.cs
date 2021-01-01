using AutoMapper;
using BitirmeProjesi.Data.Abstract;
using BitirmeProjesi.Data.Concrete;
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
    public class MovieManager : IMovieService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
      
        public MovieManager(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
           
        }

        public async Task<IDataResult<MovieDto>> Get(int movieId)
        {
            var movie = await _unitOfWork.Movies.GetAsync(m => m.Id == movieId, m => m.Category, m => m.Comments);
          
            if (movie != null)
            {
                return new DataResult<MovieDto>(ResultStatus.Success, new MovieDto
                {
                    Movie = movie,
                    ResultStatus = ResultStatus.Success,
                    Message = "basarılı"

                });
            }
            return new DataResult<MovieDto>(ResultStatus.Error, Messages.Movie.NotFound(isPlural: false), null);
        }

        public async Task<IDataResult<MovieListDto>> GetAll()
        {
            var movies = await _unitOfWork.Movies.GetAllAsync(null, m => m.Category);
            var categories = await _unitOfWork.Categories.GetAllAsync(null, m => m.Movies);
            if (movies.Count > -1)
            {
                return new DataResult<MovieListDto>(ResultStatus.Success, new MovieListDto
                {
                    Movies = movies,
                    Categories=categories,
                    ResultStatus = ResultStatus.Success,

                });
            }
            return new DataResult<MovieListDto>(ResultStatus.Error, Messages.Movie.NotFound(isPlural: true), null);
        }

        public async Task<IDataResult<MovieUpdateDto>> GetMovieUpdateDto(int movieId)
        {
            var result = await _unitOfWork.Movies.AnyAsync(m => m.Id == movieId);
            if (result)
            {
                var movie = await _unitOfWork.Movies.GetAsync(m => m.Id == movieId, m => m.Category);
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

        public async Task<IDataResult<MovieUpdateDto>> AddListMovie(int movieId)
        {
            var result = await _unitOfWork.Movies.AnyAsync(m => m.Id == movieId);
            if (result)
            {
                var movie = await _unitOfWork.Movies.GetAsync(m => m.Id == movieId, b => b.Category);
                movie.Activities = true;
                await _unitOfWork.SaveAsync();
                var movieUpdateDto = _mapper.Map<MovieUpdateDto>(movie);
                return new DataResult<MovieUpdateDto>(ResultStatus.Success, movieUpdateDto);
            }
            else
            {
                return new DataResult<MovieUpdateDto>(ResultStatus.Error, Messages.Movie.NotFound(isPlural: false), null);
            }
        }

        public async Task<IResult> AddComment(CommentAddDto commentAddDto)
        {
            var comment = _mapper.Map<Comment>(commentAddDto);

            var movie = await _unitOfWork.Movies.GetAsync(m => m.Id == commentAddDto.MovieId);
            comment.MovieId = movie.Id;
            comment.Subject = commentAddDto.Subject;
            comment.Title = commentAddDto.Title;
            var addedComment = await _unitOfWork.Comments.AddAsync(comment);
            await _unitOfWork.SaveAsync();
            return new Result(ResultStatus.Success, "başarılı");

        }
        public async Task<IDataResult<MovieListDto>> GetCategories(int? id)
        {
            var categoriesMovie = await _unitOfWork.Movies.GetAllAsync(m => m.CategoryId == id, m => m.Category);
            var categories = await _unitOfWork.Categories.GetAllAsync(null, c => c.Books, c => c.Movies, c => c.Series);
            if (categoriesMovie != null)
            {
                return new DataResult<MovieListDto>(ResultStatus.Success, new MovieListDto
                {
                    Movies = categoriesMovie,
                    Categories = categories,
                    ResultStatus = ResultStatus.Success
                   
                });
            }
            return new DataResult<MovieListDto>(ResultStatus.Error, Messages.Movie.NotFound(isPlural: true), new MovieListDto
            {
                Movies = null,
                ResultStatus = ResultStatus.Error,
                Message = Messages.Movie.NotFound(isPlural: true)
            });
        }

        public async Task<IDataResult<MovieListDto>> GetAllLessThanTwoHour()
        {
            var movie = await _unitOfWork.Movies.GetAllAsync(m => m.Time <= 120);
            if (movie != null)
            {
                 return new DataResult<MovieListDto>(ResultStatus.Success, new MovieListDto
                {
                    Movies=movie,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<MovieListDto>(ResultStatus.Error, Messages.Movie.NotFound(isPlural: true), new MovieListDto
            {
                Movies = null,
                ResultStatus = ResultStatus.Error,
                Message = Messages.Movie.NotFound(isPlural: true)
            });

        }

        public async Task<IDataResult<MovieListDto>> GetAllMoreThanTwoHour()
        {
            var movie = await _unitOfWork.Movies.GetAllAsync(m => m.Time > 120);
            if (movie != null)
            {
                return new DataResult<MovieListDto>(ResultStatus.Success, new MovieListDto
                {
                    Movies = movie,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<MovieListDto>(ResultStatus.Error, Messages.Movie.NotFound(isPlural: true), new MovieListDto
            {
                Movies = null,
                ResultStatus = ResultStatus.Error,
                Message = Messages.Movie.NotFound(isPlural: true)
            });
        }

        public async Task<IDataResult<MovieListDto>> GetImdbGreaterThanSeven()
        {
            var movie = await _unitOfWork.Movies.GetAllAsync(m => m.Imdb > 7);
            if (movie != null)
            {
                return new DataResult<MovieListDto>(ResultStatus.Success, new MovieListDto
                {
                    Movies = movie,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<MovieListDto>(ResultStatus.Error, Messages.Movie.NotFound(isPlural: true), new MovieListDto
            {
                Movies = null,
                ResultStatus = ResultStatus.Error,
                Message = Messages.Movie.NotFound(isPlural: true)
            });

        }
        public async Task<IDataResult<MovieListDto>> GetImdbAll()
        {
            var movie = await _unitOfWork.Movies.GetAllAsync(null);
            if (movie != null)
            {
                return new DataResult<MovieListDto>(ResultStatus.Success, new MovieListDto
                {
                    Movies = movie,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<MovieListDto>(ResultStatus.Error, Messages.Movie.NotFound(isPlural: true), new MovieListDto
            {
                Movies = null,
                ResultStatus = ResultStatus.Error,
                Message = Messages.Movie.NotFound(isPlural: true)
            });
        }

        public async Task<IDataResult<MovieListDto>> GetMovieDateLess1990()
        {
            var movie = await _unitOfWork.Movies.GetAllAsync(m => m.Date <= new DateTime(1990, 01, 01));
            if (movie != null)
            {
                return new DataResult<MovieListDto>(ResultStatus.Success, new MovieListDto
                {
                    Movies = movie,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<MovieListDto>(ResultStatus.Error, Messages.Movie.NotFound(isPlural: true), new MovieListDto
            {
                Movies = null,
                ResultStatus = ResultStatus.Error,
                Message = Messages.Movie.NotFound(isPlural: true)
            });

        }

        public async Task<IDataResult<MovieListDto>> GetMovieDateThan1990()
        {
            var movie = await _unitOfWork.Movies.GetAllAsync(m => m.Date > new DateTime(1990, 01, 01));
            if (movie != null)
            {
                return new DataResult<MovieListDto>(ResultStatus.Success, new MovieListDto
                {
                    Movies = movie,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<MovieListDto>(ResultStatus.Error, Messages.Movie.NotFound(isPlural: true), new MovieListDto
            {
                Movies = null,
                ResultStatus = ResultStatus.Error,
                Message = Messages.Movie.NotFound(isPlural: true)
            });
        }

        
    }
}
