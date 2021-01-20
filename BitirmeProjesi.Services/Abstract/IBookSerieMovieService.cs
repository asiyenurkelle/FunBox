using BitirmeProjesi.Entities.Dtos;
using BitirmeProjesi.Shared.Utilities.Results.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BitirmeProjesi.Services.Abstract
{
    public interface IBookSerieMovieService
    {
        Task<IDataResult<BookSerieMovieDto>> GetAllByPagingAsync(int? id,int currentPage = 1, int pageSize = 3);
        Task<IDataResult<BookSerieMovieDto>> GetAll();
        Task<IDataResult<BookSerieMovieDto>> GetCategories(int? id);
        Task<IDataResult<BookSerieMovieDto>> Search(string searchString);
        Task<IDataResult<BookSerieMovieDto>> GetOrderByImdb();

    }
}
