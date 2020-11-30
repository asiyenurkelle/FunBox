using BitirmeProjesi.Entities.Concrete;
using BitirmeProjesi.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace BitirmeProjesi.Entities.Dtos
{
    public class BookListDto:DtoGetBase
    {
        public IList<Book> Books { get; set; }
        public IList<Category> Categories { get; set; }
       
    }
}
