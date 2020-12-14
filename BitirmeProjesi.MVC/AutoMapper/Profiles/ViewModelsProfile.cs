using AutoMapper;
using BitirmeProjesi.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BitirmeProjesi.MVC.Areas.Admin.Models;

namespace BitirmeProjesi.MVC.AutoMapper.Profiles
{
    public class ViewModelsProfile:Profile
    {
        public ViewModelsProfile()
        {
            CreateMap<CommentAddViewModel, CommentAddDto>();
        }
    }
}
