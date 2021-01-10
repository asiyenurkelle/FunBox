using BitirmeProjesi.Entities.Concrete;
using BitirmeProjesi.Entities.Dtos;
using BitirmeProjesi.Shared.Utilities.Results.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BitirmeProjesi.Services.Abstract
{
    public interface IMovieService
    {
        Task<IDataResult<MovieDto>> Get(int movieId);
        Task<IDataResult<MovieListDto>> GetAll();
        Task<IDataResult<MovieUpdateDto>> AddListMovie(int movieId);
        Task<IDataResult<MovieListDto>> GetCategories(int? id);
        Task<IDataResult<MovieListDto>> GetAllLessThanTwoHour();
        Task<IDataResult<MovieListDto>> GetAllMoreThanTwoHour();
        Task<IDataResult<MovieListDto>> GetImdbGreaterThanSeven();
        Task<IDataResult<MovieListDto>> GetImdbAll();
        Task<IDataResult<MovieListDto>> GetMovieDateLess1990();
        Task<IDataResult<MovieListDto>> GetMovieDateThan1990();
        




    }
}
