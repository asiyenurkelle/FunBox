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
    public class EfCommentRepository:EfEntityRepositoryBase<Comment>,ICommentRepository
    {
        public EfCommentRepository(DbContext context) : base(context)
        {

        }

        public async Task<Comment> GetById(int commentId)
        {
            return await BitirmeProjesiContext.Comments.SingleOrDefaultAsync(c => c.Id == commentId);
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
