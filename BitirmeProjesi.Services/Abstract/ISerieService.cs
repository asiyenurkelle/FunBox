using BitirmeProjesi.Entities.Concrete;
using BitirmeProjesi.Shared.Utilities.Results.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BitirmeProjesi.Services.Abstract
{
    public interface ISerieService
    {
        Task<IDataResult<Serie>> Get(int seriId);
        Task<IDataResult<IList<Book>>> GetAll();
        Task<IResult> Delete(int serieId);
    }
}
