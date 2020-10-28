using BitirmeProjesi.Entities.Concrete;
using BitirmeProjesi.Shared.Data.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace BitirmeProjesi.Data.Abstract
{
    public interface IBookRepository:IEntityRepository<Book>
    {
    }
}
