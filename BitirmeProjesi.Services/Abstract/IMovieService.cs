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
        Task<IDataResult<MovieUpdateDto>> GetMovieUpdateDto(int movieId);
        Task<IDataResult<MovieUpdateDto>> AddListMovie(int movieId);
    }
}
