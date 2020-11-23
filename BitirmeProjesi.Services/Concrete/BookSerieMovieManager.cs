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
            var series = await _unitOfWork.Series.GetAllAsync(null, b => b.Category);

            var movies = await _unitOfWork.Movies.GetAllAsync(null, b => b.Category);
            if (books.Count > -1 && series.Count > -1 && movies.Count > -1)
            {
                return new DataResult<BookSerieMovieDto>(ResultStatus.Success, new BookSerieMovieDto
                {
                    Books = books,
                    Series = series,
                    Movies = movies,
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
