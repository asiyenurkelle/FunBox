using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using BitirmeProjesi.Entities.Concrete;
using BitirmeProjesi.Entities.Dtos;

namespace BitirmeProjesi.MVC.AutoMapper.Profiles
{
    public class CategoryProfile:Profile
    {
        public CategoryProfile()
        {
            CreateMap<CategoryDto, Category>();
            //CreateMap<CategoryListDto,>
        }
    }
}
