using BitirmeProjesi.Data.Abstract;
using BitirmeProjesi.Entities.Concrete;
using BitirmeProjesi.Entities.Dtos;
using BitirmeProjesi.Services.Abstract;
using BitirmeProjesi.Shared.Utilities.Results.Abstract;
using BitirmeProjesi.Shared.Utilities.Results.Complex_Types;
using BitirmeProjesi.Shared.Utilities.Results.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BitirmeProjesi.Services.Concrete
{
    public class SerieManager : ISerieService 
    {
        private readonly IUnitOfWork _unitOfWork;
        public SerieManager(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<IDataResult<SerieDto>> Get(int serieId)
        {
            var serie = await _unitOfWork.Series.GetAsync(s=> s.Id == serieId, s => s.Category);
            if (serie != null)
            {
                return new DataResult<SerieDto>(ResultStatus.Success, new SerieDto
                {
                   Serie=serie,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<SerieDto>(ResultStatus.Error, "Böyle bir dizi bulunamadı.", null);
        }

        public async  Task<IDataResult<SerieListDto>> GetAll()
        {
            var series = await _unitOfWork.Series.GetAllAsync(null, s => s.Category);
            if (series.Count > -1)
            {
                return new DataResult<SerieListDto>(ResultStatus.Success, new SerieListDto
                {
                    Series=series,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<SerieListDto>(ResultStatus.Error, "Diziler bulunamadı.", null);
        }
    }
}
