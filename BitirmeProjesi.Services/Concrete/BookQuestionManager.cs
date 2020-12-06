using BitirmeProjesi.Data.Abstract;
using BitirmeProjesi.Entities.Dtos;
using BitirmeProjesi.Services.Abstract;
using BitirmeProjesi.Shared.Utilities.Results.Abstract;
using BitirmeProjesi.Shared.Utilities.Results.Complex_Types;
using BitirmeProjesi.Shared.Utilities.Results.Concrete;
using System.Threading.Tasks;

namespace BitirmeProjesi.Services.Concrete
{
    public class BookQuestionManager:IBookQuestionService
    {
        private readonly IUnitOfWork _unitOfWork;
        public BookQuestionManager( IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<IDataResult<BookQuestionDto>> GetQuestions()
        {
            var questions = await _unitOfWork.BookQuestions.GetAllAsync(null);
            if (questions.Count > -1)
            {
                return new DataResult<BookQuestionDto>(ResultStatus.Success, new BookQuestionDto
                {
                    BookQuestions = questions,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<BookQuestionDto>(ResultStatus.Error, "Sorular Bulunamadı", new BookQuestionDto
            {
                BookQuestions = null,
                ResultStatus = ResultStatus.Error,
                Message = "Sorular bulunamadı"
            });
        }
    }
}
