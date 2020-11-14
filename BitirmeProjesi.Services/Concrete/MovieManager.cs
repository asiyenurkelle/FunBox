﻿using BitirmeProjesi.Data.Abstract;
using BitirmeProjesi.Data.Concrete;
using BitirmeProjesi.Entities.Concrete;
using BitirmeProjesi.Entities.Dtos;
using BitirmeProjesi.Services.Abstract;
using BitirmeProjesi.Shared.Utilities.Results.Abstract;
using BitirmeProjesi.Shared.Utilities.Results.Complex_Types;
using BitirmeProjesi.Shared.Utilities.Results.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BitirmeProjesi.Services.Concrete
{
    public class MovieManager : IMovieService
    {
        private readonly IUnitOfWork _unitOfWork;
        public MovieManager(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async  Task<IDataResult<MovieDto>> Get(int movieId)
        {
            var movie = await _unitOfWork.Movies.GetAsync(m => m.Id == movieId, m => m.Category);
            if (movie != null)
            {
                return new DataResult<MovieDto>(ResultStatus.Success, new MovieDto
                {
                    Movie=movie,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<MovieDto>(ResultStatus.Error, "Böyle bir kitap bulunamadı.", null);
        }

        public async  Task<IDataResult<MovieListDto>> GetAll()
        {
            var movies = await _unitOfWork.Movies.GetAllAsync(null, m => m.Category);
            if (movies.Count > -1)
            {
                return new DataResult<MovieListDto>(ResultStatus.Success, new MovieListDto
                {
                    Movies=movies,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<MovieListDto>(ResultStatus.Error, "Filmler bulunamadı.", null);
        }
    }
}