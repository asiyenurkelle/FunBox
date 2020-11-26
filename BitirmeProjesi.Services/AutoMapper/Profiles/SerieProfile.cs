using AutoMapper;
using BitirmeProjesi.Entities.Concrete;
using BitirmeProjesi.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitirmeProjesi.Services.AutoMapper.Profiles
{
    public class SerieProfile:Profile
    {
        public SerieProfile()
        {
            CreateMap<Serie, SerieUpdateDto>();
        }
    }
}
