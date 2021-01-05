using BitirmeProjesi.Data.Abstract;
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
    public class EfSerieCommentRepository: EfEntityRepositoryBase<SerieComment>, ISerieCommentRepository
    {
        public EfSerieCommentRepository(DbContext context) : base(context)
        {

        }
    }
}
