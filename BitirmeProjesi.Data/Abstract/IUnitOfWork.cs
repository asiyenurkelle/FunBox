using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BitirmeProjesi.Data.Abstract
{
    public interface IUnitOfWork : IAsyncDisposable
    {
        IMovieRepository Movies { get; }
        ISerieRepository Series { get; }
        IBookRepository Books { get; }
        ICategoryRepository Categories { get; }
      
        ICommentRepository Comments { get; }

        IMovieQuestionRepository MovieQuestions { get; }
        ISerieQuestionRepository SerieQuestions { get; }

        IBookQuestionRepository BookQuestions { get; }
        Task<int> SaveAsync();
    }
}
