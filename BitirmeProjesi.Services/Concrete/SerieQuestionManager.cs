using BitirmeProjesi.Data.Abstract;
using BitirmeProjesi.Entities.Dtos;
using BitirmeProjesi.Services.Abstract;
using BitirmeProjesi.Shared.Utilities.Results.Abstract;
using BitirmeProjesi.Shared.Utilities.Results.Complex_Types;
using BitirmeProjesi.Shared.Utilities.Results.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitirmeProjesi.Services.Concrete
{
    public class SerieQuestionManager : ISerieQuestionService
    {
        private readonly IUnitOfWork _unitOfWork;
        public SerieQuestionManager(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<IDataResult<SerieQuestionDto>> GetQuestions()
        {
            var questions = await _unitOfWork.SerieQuestions.GetAllAsync(null);
            if (questions.Count > -1)
            {
                return new DataResult<SerieQuestionDto>(ResultStatus.Success, new SerieQuestionDto
                {
                    SerieQuestions = questions,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<SerieQuestionDto>(ResultStatus.Error, "Diziler Bulunamadı", new SerieQuestionDto
            {
                SerieQuestions = null,
                ResultStatus = ResultStatus.Error,
                Message = "Diziler bulunamadı"
            });
        }
    }
}
