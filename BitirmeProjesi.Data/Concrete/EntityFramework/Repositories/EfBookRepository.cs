﻿using BitirmeProjesi.Data.Abstract;
using BitirmeProjesi.Entities.Concrete;
using BitirmeProjesi.Shared.Data.Concrete.EntityFramework;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BitirmeProjesi.Data.Concrete.EntityFramework.Repositories
{
    public class EfBookRepository:EfEntityRepositoryBase<Book>,IBookRepository
    {
        public EfBookRepository(DbContext context) : base(context)
        {

        }
    }
}
