using AutoMapper;
using BitirmeProjesi.Data.Abstract;
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
    public class SerieManager : ISerieService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public SerieManager(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<IDataResult<SerieDto>> Get(int Id)
        {
            var serie = await _unitOfWork.Series.GetAsync(s => s.Id == Id, s => s.Category, s=>s.Comments);
            if (serie != null)
            {
                return new DataResult<SerieDto>(ResultStatus.Success, new SerieDto
                {
                    Serie = serie,
                    ResultStatus = ResultStatus.Success,
                    Message = Messages.Serie.NotFound(false)
                }) ;
            }
            return new DataResult<SerieDto>(ResultStatus.Error, Messages.Serie.NotFound(false), null);
        }

        public async Task<IDataResult<SerieListDto>> GetAll()
        {
            var series = await _unitOfWork.Series.GetAllAsync(null, s => s.Category, s => s.Comments);
            if (series.Count > -1)
            {
                return new DataResult<SerieListDto>(ResultStatus.Success, new SerieListDto
                {
                    Series = series,
                    ResultStatus = ResultStatus.Success,
                    Message = Messages.Serie.NotFound(true)
                });
            }
            return new DataResult<SerieListDto>(ResultStatus.Error, Messages.Serie.NotFound(true), null);
        }

        public async Task<IDataResult<SerieUpdateDto>> GetSerieUpdateDto(int serieId)
        {
            var result = await _unitOfWork.Series.AnyAsync(s => s.Id == serieId);
            if (result)
            {
                var serie = await _unitOfWork.Series.GetAsync(s => s.Id == serieId, s => s.Category);
                serie.Activities = false;
                await _unitOfWork.SaveAsync();
                var serieUpdateDto = _mapper.Map<SerieUpdateDto>(serie);
                return new DataResult<SerieUpdateDto>(ResultStatus.Success, serieUpdateDto);
            }
            else
            {
                return new DataResult<SerieUpdateDto>(ResultStatus.Error, "Dizi bulunamadı.", null);
            }
        }
        public async Task<IDataResult<SerieUpdateDto>> AddListSerie(int serieId)
        {
            var result = await _unitOfWork.Series.AnyAsync(s => s.Id == serieId);
            if (result)
            {
                var serie = await _unitOfWork.Series.GetAsync(s => s.Id == serieId, s => s.Category);
                serie.Activities = true;
                await _unitOfWork.SaveAsync();
                var serieUpdateDto = _mapper.Map<SerieUpdateDto>(serie);
                return new DataResult<SerieUpdateDto>(ResultStatus.Success, serieUpdateDto);
            }
            else
            {
                return new DataResult<SerieUpdateDto>(ResultStatus.Error, "Dizi bulunamadı.", null);
            }
        }
    }
}
