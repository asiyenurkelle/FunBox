using BitirmeProjesi.Entities.Concrete;
using BitirmeProjesi.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace BitirmeProjesi.Entities.Dtos
{
    public class BookSerieMovieDto : DtoGetBase
    {
        public IList<Book> Books { get; set; }
        public IList<Serie> Series { get; set; }
        public IList<Movie> Movies { get; set; }
        public IList<Category> Categories { get; set; }
       public int? id   { get; set; }
    }
}
