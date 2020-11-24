﻿using BitirmeProjesi.Entities.Concrete;
using BitirmeProjesi.Shared.Data.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BitirmeProjesi.Data.Abstract
{
    public interface ICommentRepository:IEntityRepository<Comment>
    {
        Task<Comment> GetById(int commentId);
    }
}
