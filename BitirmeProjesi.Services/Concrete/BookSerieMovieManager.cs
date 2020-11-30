using BitirmeProjesi.Data.Abstract;
using BitirmeProjesi.Entities.Dtos;
using BitirmeProjesi.Services.Abstract;
using BitirmeProjesi.Shared.Utilities.Results.Abstract;
using BitirmeProjesi.Shared.Utilities.Results.Complex_Types;
using BitirmeProjesi.Shared.Utilities.Results.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using PagedList.Core;

namespace BitirmeProjesi.Services.Concrete
{
    public class BookSerieMovieManager : IBookSerieMovieService
    {
        private readonly IUnitOfWork _unitOfWork;
        public BookSerieMovieManager(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<IDataResult<BookSerieMovieDto>> GetAll()
        {

            var books = await _unitOfWork.Books.GetAllAsync(null, b => b.Category);
            var series = await _unitOfWork.Series.GetAllAsync(null, s => s.Category);
            var movies = await _unitOfWork.Movies.GetAllAsync(null, m => m.Category);
            var categories = await _unitOfWork.Categories.GetAllAsync(null, c => c.Books, c => c.Movies, c => c.Series);
            if (books.Count > -1 && series.Count > -1 && movies.Count > -1)
            {
                return new DataResult<BookSerieMovieDto>(ResultStatus.Success, new BookSerieMovieDto
                {
                    Books = books,
                    Series = series,
                    Movies = movies,
                    Categories=categories,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<BookSerieMovieDto>(ResultStatus.Error, "Kitaplar bulunamadı.", new BookSerieMovieDto
            {
                Books = null,
                Series = null,
                Movies = null,
                Categories=null,
                ResultStatus = ResultStatus.Error,
                Message = "Kitaplar, diziler,filmler bulunamadı."
            });



        }

        public async Task<IDataResult<BookSerieMovieDto>> GetCategories(int? id)
        {
            var categoriesBook = await _unitOfWork.Books.GetAllAsync(b => b.CategoryId == id, b => b.Category);
            var categoriesMovie = await _unitOfWork.Movies.GetAllAsync(m => m.CategoryId == id, m => m.Category);
            var categoriesSerie = await _unitOfWork.Series.GetAllAsync(s => s.CategoryId == id, s => s.Category);
            var categories = await _unitOfWork.Categories.GetAllAsync(null, c => c.Books, c => c.Movies, c => c.Series);
            if (categoriesBook.Count > -1 && categoriesMovie.Count > -1 && categoriesSerie.Count > -1)
            {
                return new DataResult<BookSerieMovieDto>(ResultStatus.Success, new BookSerieMovieDto
                {
                    Books = categoriesBook,
                    Movies = categoriesMovie,
                    Series = categoriesSerie,
                    Categories=categories,
                    
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<BookSerieMovieDto>(ResultStatus.Error, "Kitaplar bulunamadı.", new BookSerieMovieDto
            {
                Books = null,
                Series = null,
                Movies = null,
                ResultStatus = ResultStatus.Error,
                Message = "Kitaplar, diziler,filmler bulunamadı."
            });
        }
    }
}

