using BitirmeProjesi.Data.Abstract;
using BitirmeProjesi.Data.Concrete.EntityFramework.Contexts;
using BitirmeProjesi.Data.Concrete.EntityFramework.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BitirmeProjesi.Data.Concrete
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly BitirmeProjesiContext _bitirmeProjesiContext;
        private EfMovieRepository _movieRepository;
        private EfSerieRepository _serieRepository;
        private EfBookRepository _bookRepository;
        private EfCategoryRepository _categoryRepository;
     
        private EfBookCommentRepository _bookcommentRepository;
        private EfSerieCommentRepository _seriecommentRepository;
        private EfMovieCommentRepository _moviecommentRepository;

        public UnitOfWork(BitirmeProjesiContext bitirmeProjesiContext)
        {
            _bitirmeProjesiContext = bitirmeProjesiContext;
        }
        public IMovieRepository Movies => _movieRepository ?? new EfMovieRepository(_bitirmeProjesiContext);

        public ISerieRepository Series => _serieRepository ?? new EfSerieRepository(_bitirmeProjesiContext);

        public IBookRepository Books => _bookRepository ?? new EfBookRepository(_bitirmeProjesiContext);

        public ICategoryRepository Categories => _categoryRepository ?? new EfCategoryRepository(_bitirmeProjesiContext);
        public IBookCommentRepository BookComments => _bookcommentRepository ?? new EfBookCommentRepository(_bitirmeProjesiContext);
        public ISerieCommentRepository SerieComments => _seriecommentRepository ?? new EfSerieCommentRepository(_bitirmeProjesiContext);
        public IMovieCommentRepository MovieComments => _moviecommentRepository ?? new EfMovieCommentRepository(_bitirmeProjesiContext);

     


        public async ValueTask DisposeAsync()
        {
            await _bitirmeProjesiContext.DisposeAsync();
        }

        public async Task<int> SaveAsync()
        {
            return await _bitirmeProjesiContext.SaveChangesAsync();
        }
    }
}
