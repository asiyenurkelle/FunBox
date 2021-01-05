using BitirmeProjesi.Entities.Concrete;
using BitirmeProjesi.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace BitirmeProjesi.Entities.Dtos
{
    public class CommentListDto:DtoGetBase
    {
        public IList<BookComment> BookComments { get; set; }
        public IList<SerieComment> SerieComments { get; set; }
        public IList<MovieComment> MovieComments { get; set; }

    }
}
