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
       
        IUserRepository Users { get; }
        ICommentRepository Comments { get; }
        Task<int> SaveAsync();
    }
}
