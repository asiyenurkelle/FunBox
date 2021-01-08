using BitirmeProjesi.Entities.Concrete;
using BitirmeProjesi.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitirmeProjesi.Entities.Dtos
{
    public class CommentUpdateDto:DtoGetBase
    {
        public string Title { get; set; }
        public string Subject { get; set; }
        public Movie Movie { get; set; }
        public string Name { get; set; }
        public Serie Serie { get; set; }
        public Book Book { get; set; }
        public MovieComment MovieComment { get; set; }
        public SerieComment SerieComment { get; set; }
        public BookComment BookComment { get; set; }
        public int SerieId { get; set; }
        public int BookId { get; set; }
        public int MovieId { get; set; }
        public int Id { get; set; }


    }
}
