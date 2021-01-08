using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using BitirmeProjesi.Entities.Concrete;
using BitirmeProjesi.Entities.Dtos;
namespace BitirmeProjesi.MVC.AutoMapper.Profiles
{
    public class BookCommentProfile:Profile
    {
        public BookCommentProfile()
        {
            CreateMap<CommentAddBookDto, BookComment>();
            CreateMap<BookComment, CommentUpdateDto>();
            CreateMap<CommentUpdateDto, BookComment>();

        }
    }

}
