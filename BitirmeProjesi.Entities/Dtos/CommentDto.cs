using BitirmeProjesi.Entities.Concrete;
using BitirmeProjesi.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace BitirmeProjesi.Entities.Dtos
{
    public class CommentDto:DtoGetBase
    {
        public BookComment BookComment { get; set; }
        public SerieComment SerieComment { get; set; }
        public MovieComment MovieComment { get; set; }

    }
}
