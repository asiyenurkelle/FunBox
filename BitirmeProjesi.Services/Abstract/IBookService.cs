using BitirmeProjesi.Entities.Concrete;
using BitirmeProjesi.Entities.Dtos;
using BitirmeProjesi.Shared.Utilities.Results.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BitirmeProjesi.Services.Abstract
{
    public interface IBookService
    {
        Task<IDataResult<BookDto>> Get(int Id);
        Task<IDataResult<BookListDto>>GetAll();
        Task<IDataResult<BookUpdateDto>> AddListBook(int bookId);
        Task<IDataResult<BookListDto>> GetCategories(int? id);
        Task<IDataResult<BookListDto>> GetBookLessThanTwoHundredPage();
        Task<IDataResult<BookListDto>> GetBookMoreThanTwoHundredPage();
        Task<IDataResult<BookListDto>> GetBookClassical();
        Task<IDataResult<BookListDto>> GetBookNonClassical();
        Task<IDataResult<BookListDto>> GetBookDateLess1990();
        Task<IDataResult<BookListDto>> GetBookDateThan1990();






    }
}
