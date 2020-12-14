using AutoMapper;
using BitirmeProjesi.Entities.Concrete;
using BitirmeProjesi.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitirmeProjesi.MVC.AutoMapper.Profiles
{
   public  class MovieProfile:Profile
    {
        public MovieProfile()
        {
            CreateMap<Movie, MovieUpdateDto>();
        }
    }
}
