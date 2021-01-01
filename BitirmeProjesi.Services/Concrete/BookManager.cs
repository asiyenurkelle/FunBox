using AutoMapper;
using BitirmeProjesi.Data.Abstract;
using BitirmeProjesi.Entities.Concrete;
using BitirmeProjesi.Entities.Dtos;
using BitirmeProjesi.Services.Abstract;
using BitirmeProjesi.Services.Utilities;
using BitirmeProjesi.Shared.Utilities.Results.Abstract;
using BitirmeProjesi.Shared.Utilities.Results.Complex_Types;
using BitirmeProjesi.Shared.Utilities.Results.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System;
using System.Threading.Tasks;

namespace BitirmeProjesi.Services.Concrete
{
    public class BookManager : IBookService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public BookManager(IUnitOfWork unitOfWork, IMapper mapper, UserManager<User> userManager)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<IDataResult<BookDto>> Get(int Id)
        {
            var book = await _unitOfWork.Books.GetAsync(b => b.Id == Id, b => b.Category, b => b.Comments);

            if (book != null)
            {
                return new DataResult<BookDto>(ResultStatus.Success, new BookDto
                {
                    Book = book,
                    ResultStatus = ResultStatus.Success,
                    Message = Messages.Book.NotFound(isPlural: false)

                });
            }
            return new DataResult<BookDto>(ResultStatus.Error, Messages.Book.NotFound(isPlural: false), null);

        }

        public async Task<IDataResult<BookListDto>> GetAll()
        {
            var books = await _unitOfWork.Books.GetAllAsync(null, b => b.Category, b => b.Comments);
            var categories = await _unitOfWork.Categories.GetAllAsync(null, c => c.Books);
            if (books.Count > -1)
            {
                return new DataResult<BookListDto>(ResultStatus.Success, new BookListDto
                {
                    Books = books,
                    Categories = categories,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<BookListDto>(ResultStatus.Error, Messages.Book.NotFound(isPlural: true), new BookListDto
            {
                Books = null,
                Categories = null,
                ResultStatus = ResultStatus.Error,
                Message = Messages.Book.NotFound(isPlural: true)
            });

        }

        public async Task<IDataResult<BookUpdateDto>> GetBookUpdateDto(int bookId)
        {
            var result = await _unitOfWork.Books.AnyAsync(b => b.Id == bookId);
            if (result)
            {
                var book = await _unitOfWork.Books.GetAsync(b => b.Id == bookId, b => b.Category);
                book.Activities = false;
                await _unitOfWork.SaveAsync();
                var bookUpdateDto = _mapper.Map<BookUpdateDto>(book);
                return new DataResult<BookUpdateDto>(ResultStatus.Success, bookUpdateDto);
            }
            else
            {
                return new DataResult<BookUpdateDto>(ResultStatus.Error, Messages.Book.NotFound(isPlural: false), null);
            }
        }

        public async Task<IDataResult<BookUpdateDto>> AddListBook(int bookId)
        {
            var result = await _unitOfWork.Books.AnyAsync(b => b.Id == bookId);
            if (result)
            {
                var book = await _unitOfWork.Books.GetAsync(b => b.Id == bookId, b => b.Category);
                book.Activities = true;
                await _unitOfWork.SaveAsync();
                var bookUpdateDto = _mapper.Map<BookUpdateDto>(book);
                return new DataResult<BookUpdateDto>(ResultStatus.Success, bookUpdateDto);
            }
            else
            {
                return new DataResult<BookUpdateDto>(ResultStatus.Error, Messages.Book.NotFound(isPlural: false), null);
            }
        }
        public async Task<IDataResult<BookListDto>> GetCategories(int? id)
        {
            var categoriesBook = await _unitOfWork.Books.GetAllAsync(b => b.CategoryId == id, b => b.Category);
            var categories = await _unitOfWork.Categories.GetAllAsync(null, c => c.Books, c => c.Movies, c => c.Series);
            if (categoriesBook != null)
            {
                return new DataResult<BookListDto>(ResultStatus.Success, new BookListDto
                {
                    Books = categoriesBook,
                    Categories = categories,

                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<BookListDto>(ResultStatus.Error, Messages.Book.NotFound(isPlural: true), new BookListDto
            {
                Books = null,

                ResultStatus = ResultStatus.Error,
                Message = Messages.Book.NotFound(isPlural: true)
            });
        }

        public async Task<IDataResult<BookListDto>> GetBookLessThanTwoHundredPage()
        {
            var books = await _unitOfWork.Books.GetAllAsync(s => s.Page <= 200);

            if (books != null)
            {
                return new DataResult<BookListDto>(ResultStatus.Success, new BookListDto
                {
                    Books = books,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<BookListDto>(ResultStatus.Error, Messages.Book.NotFound(isPlural: true), new BookListDto
            {
                Books = null,
                ResultStatus = ResultStatus.Error,
                Message = Messages.Book.NotFound(isPlural: true)
            });
        }

        public async Task<IDataResult<BookListDto>> GetBookMoreThanTwoHundredPage()
        {
            var books = await _unitOfWork.Books.GetAllAsync(s => s.Page > 200);

            if (books != null)
            {
                return new DataResult<BookListDto>(ResultStatus.Success, new BookListDto
                {
                    Books = books,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<BookListDto>(ResultStatus.Error, Messages.Book.NotFound(isPlural: true), new BookListDto
            {
                Books = null,
                ResultStatus = ResultStatus.Error,
                Message = Messages.Book.NotFound(isPlural: true)
            });
        }

        public async Task<IDataResult<BookListDto>> GetBookClassical()
        {
            var books = await _unitOfWork.Books.GetAllAsync(s => s.IsClassical);

            if (books != null)
            {
                return new DataResult<BookListDto>(ResultStatus.Success, new BookListDto
                {
                    Books = books,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<BookListDto>(ResultStatus.Error, Messages.Book.NotFound(isPlural: true), new BookListDto
            {
                Books = null,
                ResultStatus = ResultStatus.Error,
                Message = Messages.Book.NotFound(isPlural: true)
            });
        }

        public async Task<IDataResult<BookListDto>> GetBookNonClassical()
        {
            var books = await _unitOfWork.Books.GetAllAsync(s => s.IsClassical == false);

            if (books != null)
            {
                return new DataResult<BookListDto>(ResultStatus.Success, new BookListDto
                {
                    Books = books,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<BookListDto>(ResultStatus.Error, Messages.Book.NotFound(isPlural: true), new BookListDto
            {
                Books = null,
                ResultStatus = ResultStatus.Error,
                Message = Messages.Book.NotFound(isPlural: true)
            });
        }

        public async Task<IDataResult<BookListDto>> GetBookDateLess1990()
        {
            var books = await _unitOfWork.Books.GetAllAsync(s => s.Date <= new DateTime(1990, 01, 01));

            if (books != null)
            {
                return new DataResult<BookListDto>(ResultStatus.Success, new BookListDto
                {
                    Books = books,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<BookListDto>(ResultStatus.Error, Messages.Book.NotFound(isPlural: true), new BookListDto
            {
                Books = null,
                ResultStatus = ResultStatus.Error,
                Message = Messages.Book.NotFound(isPlural: true)
            });
        }

        public async Task<IDataResult<BookListDto>> GetBookDateThan1990()
        {
            var books = await _unitOfWork.Books.GetAllAsync(s => s.Date > new DateTime(1990, 01, 01));

            if (books != null)
            {
                return new DataResult<BookListDto>(ResultStatus.Success, new BookListDto
                {
                    Books = books,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<BookListDto>(ResultStatus.Error, Messages.Book.NotFound(isPlural: true), new BookListDto
            {
                Books = null,
                ResultStatus = ResultStatus.Error,
                Message = Messages.Book.NotFound(isPlural: true)
            });
        }
    }
}
