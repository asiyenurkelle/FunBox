using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using BitirmeProjesi.Entities.Concrete;
using BitirmeProjesi.Entities.Dtos;

namespace BitirmeProjesi.MVC.AutoMapper.Profiles
{
    public class CommentProfile:Profile
    {
        public CommentProfile()
        {
            CreateMap<CommentAddDto, Comment>();
            
        }
    }
}
