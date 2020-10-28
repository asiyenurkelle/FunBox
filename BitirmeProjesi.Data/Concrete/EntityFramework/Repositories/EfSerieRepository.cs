using BitirmeProjesi.Data.Abstract;
using BitirmeProjesi.Entities.Concrete;
using BitirmeProjesi.Shared.Data.Concrete.EntityFramework;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BitirmeProjesi.Data.Concrete.EntityFramework.Repositories
{
    public class EfSerieRepository:EfEntityRepositoryBase<Serie>,ISerieRepository
    {
        public EfSerieRepository(DbContext context) : base(context)
        {

        }
    }
}
