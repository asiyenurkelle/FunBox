using BitirmeProjesi.Data.Abstract;
using BitirmeProjesi.Data.Concrete.EntityFramework.Contexts;
using BitirmeProjesi.Entities.Concrete;
using BitirmeProjesi.Shared.Data.Concrete.EntityFramework;
using BitirmeProjesi.Shared.Entities.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BitirmeProjesi.Data.Concrete.EntityFramework.Repositories
{
    public class EfMovieRepository : EfEntityRepositoryBase<Movie>, IMovieRepository
    {

        public EfMovieRepository(DbContext context) : base(context)
        {

        }
       
        private BitirmeProjesiContext BitirmeProjesiContext
        {
            get
            {
                return _context as BitirmeProjesiContext;
            }
        }
    }
}
