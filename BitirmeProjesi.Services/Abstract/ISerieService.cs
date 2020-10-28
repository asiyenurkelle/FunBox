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
        Task<IDataResult<SerieDto>> Get(int serieId);
        Task<IDataResult<SerieListDto>> GetAll();
       
    }
}
