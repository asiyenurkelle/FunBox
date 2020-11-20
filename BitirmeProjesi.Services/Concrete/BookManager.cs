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
    public class BookManager : IBookService
    {
        private readonly IUnitOfWork _unitOfWork;
        public BookManager(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<IDataResult<BookDto>> Get(int bookId)
        {
            var book = await _unitOfWork.Books.GetAsync(b => b.Id == bookId, b => b.Category);
            if (book != null)
            {
                return new DataResult<BookDto>(ResultStatus.Success, new BookDto
                {
                    Book = book,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<BookDto>(ResultStatus.Error, "Böyle bir kitap bulunamadı.", null);

        }

        public async Task<IDataResult<BookListDto>> GetAll()
        {
            var books = await _unitOfWork.Books.GetAllAsync(null, b => b.Category, b=>b.Comments);
            if (books.Count > -1)
            {
                return new DataResult<BookListDto>(ResultStatus.Success, new BookListDto
                {
                    Books = books,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<BookListDto>(ResultStatus.Error, "Kitaplar bulunamadı.", new BookListDto
            {
                Books=null,
                ResultStatus=ResultStatus.Error,
                Message= "Kitaplar bulunamadı."
            });

        }

    }
}
