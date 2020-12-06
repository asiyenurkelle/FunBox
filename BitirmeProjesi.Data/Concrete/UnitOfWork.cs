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
        private EfCommentRepository _commentRepository;
        private EfBookQuestionRepository _bookquestionRepository;
        private EfSerieQuestionRepository _seriequestionRepository;
        private EfMovieQuestionRepository _moviequestionRepository;
       
      
       
        public UnitOfWork(BitirmeProjesiContext bitirmeProjesiContext)
        {
            _bitirmeProjesiContext = bitirmeProjesiContext;
        }
        public IMovieRepository Movies => _movieRepository ?? new EfMovieRepository(_bitirmeProjesiContext);

        public ISerieRepository Series => _serieRepository ?? new EfSerieRepository(_bitirmeProjesiContext);

        public IBookRepository Books => _bookRepository ?? new EfBookRepository(_bitirmeProjesiContext);

        public ICategoryRepository Categories => _categoryRepository ?? new EfCategoryRepository(_bitirmeProjesiContext);
        public ICommentRepository Comments => _commentRepository ?? new EfCommentRepository(_bitirmeProjesiContext);
        public IBookQuestionRepository BookQuestions => _bookquestionRepository ?? new EfBookQuestionRepository(_bitirmeProjesiContext);
        public ISerieQuestionRepository SerieQuestions => _seriequestionRepository ?? new EfSerieQuestionRepository(_bitirmeProjesiContext);
        public IMovieQuestionRepository MovieQuestions => _moviequestionRepository ?? new EfMovieQuestionRepository(_bitirmeProjesiContext);


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
