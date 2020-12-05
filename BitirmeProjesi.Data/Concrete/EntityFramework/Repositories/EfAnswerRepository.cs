using BitirmeProjesi.Data.Abstract;
using BitirmeProjesi.Entities.Concrete;
using BitirmeProjesi.Entities.Dtos;
using BitirmeProjesi.Shared.Data.Concrete.EntityFramework;
using BitirmeProjesi.Shared.Utilities.Results.Abstract;
using BitirmeProjesi.Shared.Utilities.Results.Complex_Types;
using BitirmeProjesi.Shared.Utilities.Results.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitirmeProjesi.Data.Concrete.EntityFramework.Repositories
{
    public class EfAnswerRepository : EfEntityRepositoryBase<Answer>, IAnswerRepository
    {
        public EfAnswerRepository(DbContext context) : base(context)
        {
           
        }
       
       
    }

}
