using BitirmeProjesi.Entities.Dtos;
using BitirmeProjesi.Shared.Utilities.Results.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitirmeProjesi.Services.Abstract
{
    public interface IAnswerService
    {
        //film için olanlar
        Task<IDataResult<MovieListDto>> GetOneHourFilms();
        Task<IDataResult<MovieListDto>> GetLessThanOneHourFilms();
        Task<IDataResult<MovieListDto>> GetMoreThanOneHourFilms();
        Task<IDataResult<MoodTestingDto>> GetAll();
    }
}
