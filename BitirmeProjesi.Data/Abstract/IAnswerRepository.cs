using BitirmeProjesi.Entities.Concrete;
using BitirmeProjesi.Entities.Dtos;
using BitirmeProjesi.Shared.Data.Abstract;
using BitirmeProjesi.Shared.Utilities.Results.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitirmeProjesi.Data.Abstract
{
    public interface IAnswerRepository : IEntityRepository<Answer>
    {
        
    }
}
