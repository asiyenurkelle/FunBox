using BitirmeProjesi.Entities.Dtos;
using BitirmeProjesi.Shared.Utilities.Results.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitirmeProjesi.Services.Abstract
{
    public interface IActivityService
    {
        Task<IDataResult<BookSerieMovieDto>> GetActivities();
        Task<IDataResult<MovieUpdateDto>> DeleteActivitiesMovie(int movieId);
        Task<IDataResult<SerieUpdateDto>> DeleteActivitiesSerie(int serieId);
        Task<IDataResult<BookUpdateDto>> DeleteActivitiesBook(int bookId);
    }
}
