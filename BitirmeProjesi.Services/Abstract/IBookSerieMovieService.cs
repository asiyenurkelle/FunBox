﻿using BitirmeProjesi.Entities.Dtos;
using BitirmeProjesi.Shared.Utilities.Results.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BitirmeProjesi.Services.Abstract
{
    public interface IBookSerieMovieService
    {
        Task<IDataResult<BookSerieMovieDto>> GetAll();

    }
}
