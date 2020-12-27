using BitirmeProjesi.Entities.Concrete;
using BitirmeProjesi.Entities.Dtos;
using BitirmeProjesi.Shared.Utilities.Results.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BitirmeProjesi.Services.Abstract
{
    public interface ISerieService
    {
        Task<IDataResult<SerieDto>> Get(int Id);
        Task<IDataResult<SerieListDto>> GetAll();
        Task<IDataResult<SerieUpdateDto>> GetSerieUpdateDto(int serieId);
        Task<IDataResult<SerieUpdateDto>> AddListSerie(int serieId);
        Task<IResult> AddComment(CommentAddDto commentAddDto);
        Task<IDataResult<SerieListDto>> GetCategories(int? id);

    }
}
