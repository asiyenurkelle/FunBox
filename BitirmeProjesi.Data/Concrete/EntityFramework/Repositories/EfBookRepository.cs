using BitirmeProjesi.Data.Abstract;
using BitirmeProjesi.Data.Concrete.EntityFramework.Contexts;
using BitirmeProjesi.Entities.Concrete;
using BitirmeProjesi.Shared.Data.Concrete.EntityFramework;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitirmeProjesi.Data.Concrete.EntityFramework.Repositories
{
    public class EfBookRepository:EfEntityRepositoryBase<Book>,IBookRepository
    {
        public EfBookRepository(DbContext context) : base(context)
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
